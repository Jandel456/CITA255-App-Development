using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SharkBehavior : MonoBehaviour
{
    public float idleMovementRange = 3f;
    public float minIdleTime = 2f;
    public float maxIdleTime = 5f;
    public GameObject playerShip;
    public Transform playerShipPosition; // we get the position of the playership here
    private bool isChasing = false;
    public Vector3 targetPosition;
    public float damageAmount = 10f;
    public float destroyAfter = 60f;


    private void Start()
    {
        playerShip = GameObject.Find("Ship");
        playerShipPosition = playerShip.transform;
        Destroy(gameObject, destroyAfter);

        StartIdleMovement();
        
    }

    private void StartIdleMovement()
    {
        // Choose a random time to move and call MoveRandomly
        float idleTime = Random.Range(minIdleTime, maxIdleTime);
        InvokeRepeating("MoveRandomly", 0f, idleTime);
    }

private void MoveRandomly()
{
    if (isChasing) return;

    float randomx = Random.Range(-idleMovementRange, idleMovementRange);
    float randomy = Random.Range(-idleMovementRange, idleMovementRange);
    Vector3 randomDirection = new Vector3(randomx, randomy, 0);

    Vector3 newTargetPosition = transform.position + randomDirection;


    targetPosition = newTargetPosition;
    StartCoroutine(MoveToTargetPosition(targetPosition));
}

    private IEnumerator MoveToTargetPosition(Vector3 newposition)
    {
        float timeToMove = Random.Range(.5f, 2f);
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(startPosition, newposition, elapsedTime / timeToMove);

            // annoying solution to rotate the shark
            Vector3 direction = newposition - transform.position; // Direction from shark to target position
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Get angle in degrees
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle)); // Apply the rotation

            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == playerShip)
        {
            CancelInvoke("MoveRandomly");
            isChasing = true;
            StartCoroutine(ChaseTarget());
        }
    }

    private IEnumerator ChaseTarget()
    {
        float chaseDuration = 3f;
        float timeElapsed = 0f;

        while (timeElapsed < chaseDuration)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerShipPosition.position, 5f * Time.deltaTime);

            // annoying solution to rotate the shark
            Vector3 direction = playerShipPosition.position - transform.position; // Direction from shark to target
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Get angle in degrees
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle)); // Apply the rotation

            timeElapsed += Time.deltaTime;
            yield return null;
        }

        // Stop chasing after 3 seconds and return to idle
        isChasing = false;
        StartIdleMovement();
    }

    //handles damage
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform == playerShipPosition)
        {
            ShipHealthManager ship = collision.gameObject.GetComponent<ShipHealthManager>();
            if (ship != null)
            {
                ship.TakeDamage(damageAmount);
                Destroy(gameObject);
            }
        }
    }
}

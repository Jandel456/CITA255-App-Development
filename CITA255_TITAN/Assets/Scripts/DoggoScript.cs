using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoggoScript : MonoBehaviour
{
    public SpriteRenderer dogSprite;
    public TextMeshProUGUI dogText;
    public DogBreed dogBreed;
    public enum DogBreed
    {
        AustralianShepherd,
        Beagle,
        BorderCollie,
        ChowChow,
        Corgi,
        ShibaInu,
        GoldenRetriever,
        LabradorRetriever,
        ShetlandSheepDog
    }

    void Start()
    {
    UpdateDogInfo();
    }

    public void UpdateDogInfo()
    {
        switch(dogBreed)
        {
            case DogBreed.AustralianShepherd:
                dogText.text = "Australian Shepherd \nVery Good Dog.";
                dogSprite.sprite = Resources.Load<Sprite>("australian");
                break;

            case DogBreed.Beagle:
                dogText.text = "Beagle \nVery Mid Dog. Nah, they're actually pretty happy.";
                dogSprite.sprite = Resources.Load<Sprite>("beagle");
                break;

            case DogBreed.BorderCollie:
                dogText.text = "Border Collie \nVery Eh Dog. I just prefer every other kind of dog.";
                dogSprite.sprite = Resources.Load<Sprite>(path:"border");
                break;
            
            case DogBreed.ChowChow:
                dogText.text = "ChowChow \nVery scrumdiddlyumptious.";
                dogSprite.sprite = Resources.Load<Sprite>(path:"chow");
                break;

            case DogBreed.Corgi:
                dogText.text = "Corgi \nWhat is the dog doing.";
                dogSprite.sprite = Resources.Load<Sprite>(path:"corgi");
                break;

            case DogBreed.ShibaInu:
                dogText.text = "Shiba Inu \nA very recognizable look, it reminds me of 2012.";
                dogSprite.sprite = Resources.Load<Sprite>(path:"doge");
                break;

            case DogBreed.GoldenRetriever:
                dogText.text = "Golden Retriever \nThis dog is iconic in nuclear families.";
                dogSprite.sprite = Resources.Load<Sprite>(path:"golden");
                break;
            
            case DogBreed.LabradorRetriever:
                dogText.text = "Labrador Retriever \nAn imposter of the golden.";
                dogSprite.sprite = Resources.Load<Sprite>(path:"labrador");
                break;

            case DogBreed.ShetlandSheepDog:
                dogText.text = "Shetland Sheep Dog \nThe farmers Dog.";
                dogSprite.sprite = Resources.Load<Sprite>(path:"shetland");
                break;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionClass
{
    class InvalidInputException : Exception
    {
        private string message = "You probably put in an inalid name here.";
    }

    public void TestCustomException()
    {
        throw new InvalidInputException();
    }
}

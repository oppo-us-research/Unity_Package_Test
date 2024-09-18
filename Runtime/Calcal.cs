using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcal : MonoBehaviour
{
    public static float Calculate(float a, float b, string op)
    {
        switch (op)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                return a / b;
            default:
                return 0;
        }
    }
}

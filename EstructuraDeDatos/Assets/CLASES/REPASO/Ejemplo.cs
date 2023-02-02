using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    int num1 = 7;
    int num2 = 5;
    int num3 = 4;

    void Start()
    {
        int valr = Calcular(num1, num2, num3);
        Debug.Log(valr);
    }

    int Calcular(int numero1, int numero2, int numero3)
    {
        int total;
        total = numero1 + numero2 + numero3;
        return total;
    }
}

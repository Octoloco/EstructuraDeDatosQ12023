using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Condicionales : MonoBehaviour
{
    private int incognita;
    private int numero;
    public TMP_InputField input;
    public TMP_Text text;

    void Start()
    {
        GeneraNumero();
    }

    void Update()
    {
        
    }

    public void Adivinar()
    {
        int.TryParse(input.text, out numero);

        if(numero == incognita)
        {
            text.text = "Felicidades Ganaste! Mi numero es: " + incognita.ToString();
        }
        else if(numero < incognita)
        {
            text.text = "Mi numero es mayor.";
        }
        else
        {
            text.text = "Mi numero es menor.";
        }
    }

    void GeneraNumero()
    {
        incognita = Random.Range(0, 10);
        text.text = "Adivina mi numero!";
    }
}

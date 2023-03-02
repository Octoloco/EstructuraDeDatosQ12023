using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PapelRich : MonoBehaviour
{
    private int seleccionIA; //Esta variable va a controlar el numero que nos dará la compu.
    [SerializeField] private TMP_Text IATexto;
    [SerializeField] private TMP_Text PlayerTexto;
    private int inputUsuario;
    // Start is called before the first frame update
    void Start()
    {
        seleccionIA = Random.Range(1, 4);
        IATexto.text = "IA Lista!";
    }

    // Update is called once per frame
    void Update()
    {

    }
    void seleccion(int seleccion)
    {
        inputUsuario = seleccion;

        if (inputUsuario == 1)
        {
            PlayerTexto.text = "Seleccionaste piedra";

        }
        else if (inputUsuario == 2)
        {
            PlayerTexto.text = "Seleccionaste papel";

        }
        else if (inputUsuario == 3)
        {
            PlayerTexto.text = "Seleccionaste tijeras";
        }

    }
    public void PinshiCompu()
    {
        if (seleccionIA == 1 && inputUsuario == 1)
        {
            IATexto.text = "Empate";
        }
        else if (seleccionIA == 2 && inputUsuario == 1)
        {
            IATexto.text = "Gana la compu, perdedor >:D";
        }
        else if (seleccionIA == 3 && inputUsuario == 1)
        {
            IATexto.text = "Ganaste, perderdor :D";
        }
        //Ahora con 2
        if (seleccionIA == 1 && inputUsuario == 2)
        {
            IATexto.text = "Ganaste, perderdor :D";
        }
        else if (seleccionIA == 2 && inputUsuario == 2)
        {
            IATexto.text = "Empate";
        }
        else if (seleccionIA == 3 && inputUsuario == 2)
        {
            IATexto.text = "Gana la compu, perderdor >:D";
        }
        //Ahora con 3
        if (seleccionIA == 1 && inputUsuario == 3)
        {
            IATexto.text = "Gana la compu, perderdor >:D";
        }
        else if (seleccionIA == 2 && inputUsuario == 3)
        {
            IATexto.text = "Ganaste, perderdor :D";
        }
        else if (seleccionIA == 3 && inputUsuario == 3)
        {
            IATexto.text = "Empate";
        }
    }
}

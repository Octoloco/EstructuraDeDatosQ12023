using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PiedraPapelTijera : MonoBehaviour
{
    private int seleccionIA;
    [SerializeField] private TMP_Text IATexto;
    [SerializeField] private TMP_Text PLayerTexto;
    private int inputUsurio;

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

    public void AsignarSeleccion(int seleccion)
    {
        inputUsurio = seleccion;

        if(inputUsurio == 1)
        {
            PLayerTexto.text = "Seleccionaste Piedra!";
        }
        else if (inputUsurio == 2)
        {
            PLayerTexto.text = "Seleccionaste Papel!";
        }
    }

}

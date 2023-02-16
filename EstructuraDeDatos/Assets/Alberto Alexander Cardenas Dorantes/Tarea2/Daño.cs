using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    public float daño = 30;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Sistemadevida>() != null)
        {
            other.gameObject.GetComponent<Sistemadevida>().QuitarVida(daño);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDianaMartinez : MonoBehaviour
{
    float life = 5;
    float shield = 5;
    float damage = 1;
    int items = 5;
    int jump = 1;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Presione A, B, C, D , E, para conocer sus datos");
        // UnityEngine.Debug.Log -> Te imprime en la consola de Unity;
    }


    // Update is called once per frame
    void Update()
    {
        Knowlife();
        Knowshield();
        Knowdamage();
        Knowitems();
        Knowjump();
    }

    private void Knowlife()

    {

        if (Input.GetKey(KeyCode.A)) //Es para que detecte que vas a presionar una tecla
        {
            UnityEngine.Debug.Log("Usted tiene " + life + " de vida");
            // Si presionas la A te dara el texto mas el dato de la vida
        }

    }

    private void Knowshield()
    {
        if (Input.GetKey(KeyCode.B))
        {
            UnityEngine.Debug.Log("Usted tiene " + shield + " de escudo");
        }
    }

    private void Knowdamage()
    {
        if (Input.GetKey(KeyCode.C))
        {
            UnityEngine.Debug.Log("Usted puede " + damage + " de daño");
        }
    }

    private void Knowitems()
    {
        if (Input.GetKey(KeyCode.D))
        {
            UnityEngine.Debug.Log("Usted puede guardar " + items + " objetos en su inventario");
        }
    }

    private void Knowjump()
    {
        if (Input.GetKey(KeyCode.E))
        {
            UnityEngine.Debug.Log("Usted puede saltar " + jump + " mt por mucho");
        }
    }
}
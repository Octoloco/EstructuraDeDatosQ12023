using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerDianaMartinez : MonoBehaviour
{
    [SerializeField] private float speed = 3;

    float life = 5;
    float shield = 5;
    float damage = 1;
    int items = 5;
    int jump = 1;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Presione P para conocer sus datos");
        // UnityEngine.Debug.Log -> Te imprime en la consola de Unity;
    }


    // Update is called once per frame
    void Update()
    {
        Move();
        Knowdata();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed );
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed );
        }
    }

    private void Knowdata()

    {

        if (Input.GetKey(KeyCode.P)) //Es para que detecte que vas a presionar una tecla
        {
            UnityEngine.Debug.Log("Usted tiene " + life + " de vida");
            UnityEngine.Debug.Log("Usted tiene " + shield + " de escudo");
            UnityEngine.Debug.Log("Usted puede saltar " + jump + " mts");
            UnityEngine.Debug.Log("Usted puede " + damage + " de daño");
            UnityEngine.Debug.Log("Usted puede guardar " + items + " objetos en su inventario");
            // Si presionas la P te dara los datos de tu personaje
        }

    }

   
 
}
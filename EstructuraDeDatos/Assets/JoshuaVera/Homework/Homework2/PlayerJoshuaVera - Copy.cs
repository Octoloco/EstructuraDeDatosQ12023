using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoshuaVera : MonoBehaviour
{
    int vida;
    string nombre;
    float daño;
    float resistencia;
    float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }
    void Movimiento(){
        if(Input.GetKeyDown(KeyCode.D)){
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.A)){
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.S)){
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.W)){
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }

}

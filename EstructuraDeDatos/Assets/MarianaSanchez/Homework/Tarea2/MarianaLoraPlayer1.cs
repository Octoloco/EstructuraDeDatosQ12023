using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarianaLoraPlayer1 : MonoBehaviour
{
    int vida = 3;
    int stamina;
    float dead;
    float speed = 10;
    int puntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    public void QuitarVida()
    {
        dead = 1;
        float restarvida = vida - dead;
    }

    private void Movement()
    {
        if (Imput.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Imput.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Imput.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Imput.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}

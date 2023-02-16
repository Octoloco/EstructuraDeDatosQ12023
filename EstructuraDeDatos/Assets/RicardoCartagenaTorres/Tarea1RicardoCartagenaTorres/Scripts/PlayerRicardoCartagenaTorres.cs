using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRicardoCartagenaTorres : MonoBehaviour
{
    int vida = 3;
    float daño;
    float speed = 10;
    int vidaExtra;
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
    //Esta es para quitarle vida.
    public void RestarVida()
    {
        daño = 1;
        float vidaMenos = vida - daño;


    }
    //Para darle vida extra.
    public void SumarVida()
    {

        vidaExtra = 1;

        float vidaMas = vida + vidaExtra;

    }
    //Para sumar sus puntos que gana.
    public void SumarPuntos()
    {
        int ganar = puntos + 10;
        if (puntos >= 1000)
        {
            SumarVida();
        }
    }
    //Para restarselos como en Sonic.
    public void RestarPuntos()
    {
        int perder = puntos - 5;
        if (puntos == -1)
        {
            RestarVida();
        }
    }
    //El movimiento.
    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }

}

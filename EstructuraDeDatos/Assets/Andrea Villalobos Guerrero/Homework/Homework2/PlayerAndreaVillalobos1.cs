using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAndreaVillalobos1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int vidas = 3;
        int salud = 100;
        int daño = -20;
        int velocidad = 10;
        int niveles = 3;

        //Tarea 2

        int vida;
        int velocidaddemovimiento;
        int fuerzadebrinco;
    }

    // Update is called once per frame
    void Update()
    {
        void correr()
        {

        }

        void saltar()
        {

        }

        void dañoinflingido()
        {

        }

        void vidasrestantes()
        {

        }

        void tiempolimite()
        {

        }

        //Tarea 2

        void PersonajeEnMovimineto()
        {

        }

        Move();

    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime );
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime );
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
}


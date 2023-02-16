using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAndreaVillalobos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool muerto;
        char velocidad;
        int vidas;
        int daño;
        int salto;

        //Tarea2

        int vida;
        float velocidaddemovimiento;
        char fuerzadebrinco;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }

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
}

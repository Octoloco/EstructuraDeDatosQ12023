using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAzulGrajales : MonoBehaviour
{
    public float vida;
    public float escudo;
    public  float daño;
    public int items;
    private int jump; //El unico que puse privado es jumpo, ya que es algo que no quiero que otras clases usen de mi personaje

    // Start is called before the first frame update
    void Start()
    {
        vida = 3;
        escudo = 6;
        daño = 3;
        items = 5;
        jump = 1;

        { //El Debug.Log funciona para imprimir texto en tu pantalla, en esta versión es necesario utilizar "UnityEngine"
            UnityEngine.Debug.Log("Presione A, B, C, D , E, para conocer sus datos");
        }

    }

    


        // Update is called once per frame
        void Update()
        {
            Knowvida();
            Knowescudo();
            Knowdaño();
            Knowitems();
            Knowjump();
        }

        private void Knowvida()

        {

            if (Input.GetKey(KeyCode.A))
            {
                UnityEngine.Debug.Log("Aun tienes " + vida + " de vida");
                
            }

        }

        private void Knowescudo()
        {
            if (Input.GetKey(KeyCode.B))
            {
                UnityEngine.Debug.Log("Tienes " + escudo + " de escudo");
            }
        }

        private void Knowdaño()
        {
            if (Input.GetKey(KeyCode.C))
            {
                UnityEngine.Debug.Log("Te hicieron " + daño + " de daño");
            }
        }

        private void Knowitems()
        {
            if (Input.GetKey(KeyCode.D))
            {
                UnityEngine.Debug.Log("Solo te caben " + items + " objetos en tu inventario");
            }
        }

        private void Knowjump()
        {
            if (Input.GetKey(KeyCode.E))
            {
                UnityEngine.Debug.Log("Para saltar " + jump + " aprieta espacio");
            }
        }
}

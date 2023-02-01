using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAlexCardenas : MonoBehaviour
{
    public int Vida = 6;
    public int escudo = 6;
    public float daño = 1;
    public float magia = 2;
    public float resistencia = 7;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngijne.Debug.Log("Presione 1, 2, 3, 4, Para conocer sus estatus de Jugador ");
    }

    // Update is called once per frame
    void Update()
    {
        KnowVida();
        Knowescudo();
        Knowdaño();
        Knowmagia();
        Knowresistencia();

    }

    private void KnowVida()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Tu vida es de" + Vida);
        }
    }

    private void Knowescudo()
    {
        if (input.GetKey(KeyCode.B))
        {
            Debug.Log("Tu escudo tiene" + escudo);
        }
    }

    private void Knowdaño()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log("Tu Daño es de" + Daño);
        }
    }

    private void Knowmagia()
    {
        if (input.GetKey(KeyCode.D))
        {
            Debug.Log("Tu Magia es de" + magia);
        }
    }

    private void Knowresistencia()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Tu Resistencia es de" + resistencia);
        }
    }

}
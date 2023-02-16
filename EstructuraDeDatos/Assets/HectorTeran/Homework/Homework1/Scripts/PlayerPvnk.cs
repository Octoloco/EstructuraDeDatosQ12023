using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerPvnk : MonoBehaviour
{
    public float vida;
    public float puntos;
    public float daño;
    public int trucos, flip;
    private int jump;
    void Start()
    {
        vida = 3;
        puntos = 6;
        daño = 3;
        trucos = flip;
        jump = 1;
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
            UnityEngine.Debug.Log("Tienes " + puntos + " de combo");
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
            UnityEngine.Debug.Log("Solo te caben " + trucos + " trucos en tu inventario");
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

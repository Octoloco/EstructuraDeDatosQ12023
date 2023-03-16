
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public Camera HIJO;
    public float mouseHorizontal = 3f;
    public float mouseVertical = 2f;

    float h_mouse;
    float v_mouse;

    public float moveSpeed = 2;
    public float runSpeed = 8;
    public int daño;
    public int vida;
    public int vidaExtra;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Moveplayer();
    }
    public void RestarVida()
    {
        daño = 1;
        float vidaMenos = vida - daño;


    }
    //Para darle vida extra.
    public void SumarVida() /* para sumar vida*/
    {

        vidaExtra = 1;

        float vidaMas = vida + vidaExtra;

    }
    void Moveplayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 500 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 500 * Time.deltaTime);
        }

        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
    }
}

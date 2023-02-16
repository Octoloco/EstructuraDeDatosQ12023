
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void RestarVida()
    {
        daño = 1;
        float vidaMenos = vida - daño;


    }
    Para darle vida extra.
    public void SumarVida() /* para sumar vida*/
    {

        vidaExtra = 1;

        float vidaMas = vida + vidaExtra;

    }
    void Move()
    {
    if (Input.GetKey(KeyCode.W)) /*moivmiento hacia delante*/
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
    transform.Rotate(0, h_mouse, 0); /*Objeto rota en el eje de y*/*
    Cam.transform.Rotate(-v_mouse, 0, 0);/*rotanto la camara, con el menos hace que se invierta la direccion de donde se voltea a ver*/
    }

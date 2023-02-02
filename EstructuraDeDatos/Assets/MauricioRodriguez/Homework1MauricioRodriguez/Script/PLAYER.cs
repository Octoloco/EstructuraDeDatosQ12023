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
    void Move()
    {
        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
        v_mouse = mouseVertical * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h_mouse, 0); /*Objeto rota en el eje de y*/
        Cam.transform.Rotate(-v_mouse,0, 0);/*rotanto la camara, con el menos hace que se invierta la direccion de donde se voltea a ver*/

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework2 : MonoBehaviour
{
    public Camera Cam;

    public float mouseHorizontal = 3f;
    public float mouseVertical = 2f;


    float h_mouse;
    float v_mouse;

    public float moveSpeed = 2;
    public float runSpeed = 8;

    public float speed = 5f;

    public float rotationSpeed = 50f;


    float h; // horizontal
    float v; // vertical

    int health;
    int shield;
    float stamina;
    bool jump;
    bool grounded;

    void Jump()
    {

    }


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

        transform.Rotate(0, h_mouse, 0); //gira en el eje de Y mirar hacia arriba
        Cam.transform.Rotate(-v_mouse, 0, 0); // gira la camara en el eje de X mirar hacia abajo

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(0, horizontalInput, verticalInput);

        movementDirection.Normalize();

        transform.position = transform.position + movementDirection * speed * Time.deltaTime;

        if (movementDirection != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection), rotationSpeed * Time.deltaTime);

    }
    void ReduceHealth()
    {

    }
    void IncreaseHealth()
    {

    }
    void Bend()
    {

    }
    void Dead()
    {

    }

}

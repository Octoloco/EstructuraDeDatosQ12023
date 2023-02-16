using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMauricioLuna : MonoBehaviour
{
    public float speed = 1.0f;
    public float RotationSpeed = 1.0f;
    public float JumpForce = 1.0f;

    private Rigydbody physics;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.LockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento
        float horizontal = Input.GetAxis("horizontal");
        float vertical = Input.GetAxis("vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * speed);

        //Rotacion
        float rotationY = Imput.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * RotationSpeed, 0));

        //Salto
        if (imput.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse)
        }
    }
}

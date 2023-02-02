using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class playerAntonioDelgado : MonoBehaviour
{
    public float speed = 1.0f;
    public float RotationSpeed = 1.0f;
    
    
   Rigidbody rb;

    bool isJump = false;
    public float Jumpforce = 5.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
}
   

                       
                      

    


    // Update is called once per frame
    void Update()
    {
    //Movimiento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * speed);
       
        //Rotacion 
        float rotationY = Input.GetAxis("Mouse X");
        
        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * RotationSpeed, 0));


        isJump = Input.GetButtonDown("Jump");

        if (isJump)
        {
            rb.AddForce(new Vector3(0, Jumpforce, 0), ForceMode.Impulse);


        }

        //https://www.youtube.com/watch?v=x3FbFa843Pw
        //https://www.youtube.com/watch?v=Mfp-2yABJlk

    }

}





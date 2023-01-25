using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine.UI;
using UnityEngine;


public class PlayerKarlaOlais : MonoBehaviour
{
    int vida = 100;
    int daño = 20;
   [SerializedField] float speed = 0.5f;
    float jump = 1f;
    int fuerza = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.translate(Vector3.Back * Time.deltaTime * speed);
        }
    }
    void Jump()
    {
        isJump = Input.GetButtonDown("Jump")
        {
            if (isJump)
            {
                rb.AddForce(new Vector3(0, jumpForce,0), ForceMode.Impulse);
            }
            void Daño()
            {

            }
            void SumarVida()
            {

            }
            void RestarVida()
            {

            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAzulGrajales : MonoBehaviour



{


    [SerializeField] private float speed = 3;

        int life = 3;
        bool death = false;
        float points = 0;
        int bullets = 5;
        int level = 0;


    void Start()
    {
        
        
    }

    void Update()
    {
        Move();

    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
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
}



    



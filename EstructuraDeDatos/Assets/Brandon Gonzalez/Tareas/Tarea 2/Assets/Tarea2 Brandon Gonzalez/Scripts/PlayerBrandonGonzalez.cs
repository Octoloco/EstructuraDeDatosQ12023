using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBrandonGonzalez : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Variables
        int life = 0;
        int shield = 0;
        int stamina = 0;
        float speed = 50;
        int jumpforce = 0;

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 20);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 20);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 20);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 20);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDaniel : MonoBehaviour
{
    int health;
    int shield;
    bool dead;
    bool grab;
    float speedMovement;
    float jumpForce;

    [SerializeField] private float speed = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    private void Move()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }



        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

    }

}

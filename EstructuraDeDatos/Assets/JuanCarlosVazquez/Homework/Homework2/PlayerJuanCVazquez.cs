using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJuanCVazquez : MonoBehaviour
{
    // Fuente https://www.youtube.com/watch?v=x3FbFa843Pw
    public float RotationSpeed = 1.0f;
    private Rigidbody Physics;
    //
    public float speed = 3;
    public int HP;
    public int SP;
    public int attack;
    public int EXP;
    public int Lvl;
    public int Spd;
    public float JumpForce=1.0f;
    
    void Start()
    {
        // https://www.youtube.com/watch?v=x3FbFa843Pw
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible= false;
        Physics=GetComponent<Rigidbody>();
        //
        HP = 70;
        SP = 35;
        attack = 15;
        EXP = 0;
        Lvl = 1;

    }

    public int UseHealingItem()
    {
        int useHealingItem = HP + 30;
        return useHealingItem;
    }

    public int TakeDamage()
    {
        int takeDamage = HP - 20;
        return takeDamage;
    }

    public int DamageEnemy()
    {
        int damageEnemy = 50 - attack;
        return damageEnemy;
    }

    public int MonsterDefeated()
    {
        int monsterDefeated = EXP + 40;
        return monsterDefeated;
    }

    public int LevelUP()
    {
        int levelUp = Lvl + 1;
        return levelUp;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(Vector3.right* Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward* Time.deltaTime * speed);
        }

        // fuente https://www.youtube.com/watch?v=x3FbFa843Pw
        float rotationY = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0,rotationY * Time.deltaTime * RotationSpeed, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
        }
        //
    }
}

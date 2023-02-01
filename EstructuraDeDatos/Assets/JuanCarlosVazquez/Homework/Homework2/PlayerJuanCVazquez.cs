using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJuanCVazquez : MonoBehaviour
{
    public float speed = 3;
    public int HP;
    public int SP;
    public int attack;
    public int EXP;
    public int Lvl;
    public int Spd;
    public int JumpStrenght;
    // Start is called before the first frame update
    void Start()
    {
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
    }
}

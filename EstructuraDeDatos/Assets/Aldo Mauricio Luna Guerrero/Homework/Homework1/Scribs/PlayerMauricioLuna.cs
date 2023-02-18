using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMauricioLuna : MonoBehaviour
{
    int life;
    int defence;
    int damageAttack;
    int magic;
    int power;
    int attackEnemy;
    int EnemyLife;
    // Start is called before the first frame update
    void Start()
    {
        life = 5;
        defence = 50;
        damageAttack = 10;
        magic = 10;
        attackEnemy = 10;
        power = 100;
        EnemyLife = 100;

    }

    public int Healing()
    {
        int Healing = life + 1;
        return Healing;
    }

    public int defense()
    {
        int defence = 50 - 10;
        return defence;
    }

    public int DamageAttack()
    {
        int DamageAttack = EnemyLife - damageAttack;
        return damageAttack;
    }

    public int MagicAttack()
    {
        int MagicAttack = damageAttack + magic;
        return magicAttack;
    }

    public int PowerAttack()
    {
        int PowerAtack = (damageAttack + magic) * 2;
        return PowerAtack;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

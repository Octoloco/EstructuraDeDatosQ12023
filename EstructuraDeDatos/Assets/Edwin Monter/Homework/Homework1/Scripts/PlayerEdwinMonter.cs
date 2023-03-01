using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEdwinMonter : MonoBehaviour
{
    public int salud;
    public int level;
    public int resistencia;
    private int comida;
    private int daño;
    // Start is called before the first frame update
    void Start()
    {
        salud = 100;
        level = 1;
        resistencia = 100;
        comida = 50;
        daño = 25; 
    }

    public int UseBandage()
    {
        int UseBandage = salud + 20;
        return UseBandage;
    }


    public int GainExperience()
    {
        int GainExperience = level + 1;
        return GainExperience;
    }


    public int Movements()
    {
        int Movements = resistencia - 5;
        return Movements;
    }


    private int PassOfTheTime()
    {
        int PassOfTheTime = comida - 10;
        return PassOfTheTime;
    }


    private int Damage()
    {
        int Damage = daño - 25;
        return Damage;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

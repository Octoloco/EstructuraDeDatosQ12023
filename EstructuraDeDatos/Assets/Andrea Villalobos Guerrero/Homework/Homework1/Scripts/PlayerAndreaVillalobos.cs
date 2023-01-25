using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAndreaVillalobos : MonoBehaviour

     int vida = 100;
        char velocidad = 3;
        float energía = 50.0;
        int daño = 10;
        int resistencia = 20 %;


  

int EnergiaRestandose (float energiarestada)
{
    energiarestada = energía - velocidad 
}

int VidaMasResistencia (int vitatotal)
{
    vidatotal=vida+resistencia
}
int Dañoaenemigos(daño)
{
    
}
int VelocidadConstante(velocidad)
{

}
float EnergiaAlInicio(energía)
{

}





{
    // Start is called before the first frame update
    void Start()
    {
        VidaMasResistencia();
        Dañoaenemigos();
        VelocidadConstante();
        EnergiaAlInicio();

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

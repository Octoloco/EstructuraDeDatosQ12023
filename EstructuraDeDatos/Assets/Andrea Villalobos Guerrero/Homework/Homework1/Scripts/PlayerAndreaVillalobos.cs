using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAndreaVillalobos : MonoBehaviour

     int vida = 100;
        char velocidad = 3;
        float energ�a = 50.0;
        int da�o = 10;
        int resistencia = 20 %;


  

int EnergiaRestandose (float energiarestada)
{
    energiarestada = energ�a - velocidad 
}

int VidaMasResistencia (int vitatotal)
{
    vidatotal=vida+resistencia
}
int Da�oaenemigos(da�o)
{
    
}
int VelocidadConstante(velocidad)
{

}
float EnergiaAlInicio(energ�a)
{

}





{
    // Start is called before the first frame update
    void Start()
    {
        VidaMasResistencia();
        Da�oaenemigos();
        VelocidadConstante();
        EnergiaAlInicio();

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

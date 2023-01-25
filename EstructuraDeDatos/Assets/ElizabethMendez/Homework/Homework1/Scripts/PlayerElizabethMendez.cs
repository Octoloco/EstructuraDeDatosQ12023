using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class PlayerElizabethMendez : MonoBehaviour
{
    // Variables
    int life = 100;
    string name = "Helia";
    string weapon = "Arco";
    string skin = "Vestido ceremonial";
    string power_Up = "Lluvia de flechas";

    // Variables no esenciales para el personaje
    int manzana = 5;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("¡Bienvenido!");
        UnityEngine.Debug.Log("¿Quieres conocer las caracteristicas de tu personaje?, Si es así, presiona la tecla C");
        UnityEngine.Debug.Log("¿Quieres conocer tu nivel de vida?, Si es así, presiona la tecla L");
        UnityEngine.Debug.Log("¡Revisa tu inventario presionando I!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            UnityEngine.Debug.Log("Tu nivel de vida actual es: " + life);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            UnityEngine.Debug.Log("El nombre de tu personaje es: " + name);
            UnityEngine.Debug.Log("Su arma principal es: " + weapon + " si quieres desbloquear otras armas, sube de nivel a " + name);
            UnityEngine.Debug.Log("El power up de " + name + "es: " + power_Up);
            UnityEngine.Debug.Log("En este momento, tu personaje está usando: " + skin + " para desbloquear otro skin, sube de nivel a " + name);
        }
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            UnityEngine.Debug.Log("Bienvenido al inventario, aquí... solamente puedes guardar manzanas. Si quieres ver cuantas manzanas tienes, presiona M");
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            UnityEngine.Debug.Log("¡Vaya, al parecer tienes " + manzana + " manzanas");
            UnityEngine.Debug.Log("Dato curioso: Puedes aumentar tu vida en una unidad si comes una manzana, para comer una manzana, puedes presionar E");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            manzana = manzana - 1;
            life = life + 1;
            UnityEngine.Debug.Log("Ahora, tu nivel de vida es de: " + life + " y tienes " + manzana + " manzanas");
        }
    }
}

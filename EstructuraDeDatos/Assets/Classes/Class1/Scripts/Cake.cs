using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    public int eggs;
    private float butter;
    public float milk;
    private float flour;
    public float bakingPowder;
    private float sugar;
    bool cooked;
    string text;

    private void Start()
    {
        eggs = 3;
        butter = 1.4f;
        milk = 4;
        flour = 5;
        bakingPowder = .5f;
        sugar = 4;
        cooked = false;
        text = "Happy Birthday!";

        MakeCake();
    }

    public float MixDryIngedients()
    {
        float mixedIngredients = sugar + flour + bakingPowder;
        return mixedIngredients;
    }

    public float MixWetIngredients()
    {
        float mixedIngredients = milk + butter + eggs;
        return mixedIngredients;
    }

    public float MixAll(float dryIngredients, float wetIngredients)
    {
        float fullMix = dryIngredients + wetIngredients;
        return fullMix;
    }

    private int CookInOven(float fullMix)
    {
        //Precalentar el horno
        //Meter ingredientes al horno
        //ESPERAR a que se cocine
        //Regresar numero de pasteles cocinados
        return 1;
    }

    public void Serve(int numberOfCakes)
    {
        //Servir Pastel
    }

    void MakeCake()
    {
        float dryIngredients = MixDryIngedients();
        float wetIngredients = MixWetIngredients();
        float fullMix = MixAll(dryIngredients, wetIngredients);
        int cakesCooked = CookInOven(fullMix);
        Serve(cakesCooked);
    }
}

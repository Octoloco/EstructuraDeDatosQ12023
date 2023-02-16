using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ForScript : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    void Start()
    {
        text.text = "";
        for (int i = 0; i < 11; i++)
        {
            text.text += i.ToString();
        }
    }
}

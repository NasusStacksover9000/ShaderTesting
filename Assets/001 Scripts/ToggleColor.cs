using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleColor : MonoBehaviour
{
    public Material Cube;
    private bool onOffButton = false;


    public void OnOff()
    {
        onOffButton = !onOffButton;
        if(onOffButton)
        {
            Cube.SetFloat("_On_Off", 1.0f);
        }
        else
        {
            Cube.SetFloat("_On_Off", 0.0f);
        }
    }
}

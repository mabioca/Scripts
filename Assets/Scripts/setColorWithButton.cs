using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setColorWithButton : MonoBehaviour
{
    public GameObject myTestObject;
    public Color myColor;

    public void myColorChanger()
    {
        // Get the Renderer component from the object and store it in a variable
        var myRenderer = myTestObject.GetComponent<Renderer>();

        // Call SetColor using the shader property name "_Color" and setting the color to the custom color you created
        myRenderer.material.SetColor("_Color", myColor);
    }
}
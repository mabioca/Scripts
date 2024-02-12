using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControlSlider : MonoBehaviour
{
    public float speedControl = 1.0f;
    public float red;
    public float green;
    public float blue;
    Renderer myFan;
    void Start()
    {
        myFan = GetComponent<Renderer>();
        myFan.material.color = new Color(red, green, blue);
    }
    void Update()
    {
        transform.Rotate(0f, 0f, speedControl * Time.deltaTime);
    }
    public void speedSlider(float sliderSpeed)
    {
        speedControl = sliderSpeed;
    }
    public void redSlider(float newRed)
    {
        red = newRed;
        UpdateColor();
    }
    public void greenSlider(float newGreen)
    {
        green = newGreen;
        UpdateColor();
    }
    public void blueSlider(float newBlue)
    {
        blue = newBlue;
        UpdateColor();
    }
    public void UpdateColor()
    {
        myFan.material.color = new Color(red, green, blue);
    }
}
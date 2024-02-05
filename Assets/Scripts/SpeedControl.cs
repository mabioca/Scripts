using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedcntltest : MonoBehaviour
{
    public GameObject[] rotatingFans;
    public Color[] colorField;
    public float[] fanRotationSpeed;

    void Start()
    {

    }
    
    void Update()
    {
        for (int i = 0; i < rotatingFans.Length; i++)
        {
            var myFanRenderer = rotatingFans[i].GetComponent<Renderer>();
            myFanRenderer.material.SetColor("_Color", colorField[i]);
            rotatingFans[i].transform.Rotate(0.0f, 0.0f, fanRotationSpeed[i] * Time.deltaTime, Space.Self);
        }
    }
}
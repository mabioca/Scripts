using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorForTestObject : MonoBehaviour
{
    public GameObject myTestObject;

    // Start is called before the first frame update
    void Start()
    {
        var myPubRenderer = myTestObject.GetComponent<Renderer>();
        myPubRenderer.material.SetColor("_Color", Color.red);
    }
}

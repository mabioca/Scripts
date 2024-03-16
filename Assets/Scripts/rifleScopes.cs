using UnityEngine;

public class rifleScopes : MonoBehaviour
{
    public GameObject rifle;
    public GameObject[] scopesHandle;

    public void rifleOnOff()
    {
        if (rifle.activeSelf)
        {
            rifle.SetActive(false);
        } 
        else
        {
            rifle.SetActive(true);
        }
    }
    public void handle()
    {
        for (int i = 0; i < scopesHandle.Length; i++)
        {
            scopesHandle[i].SetActive(false);
        }
        scopesHandle[0].SetActive(true);
    }
    public void scopeA()
    {
        for (int i = 0; i < scopesHandle.Length; i++)
        {
            scopesHandle[i].SetActive(false);
        }
        scopesHandle[1].SetActive(true);
    }
    public void scopeB()
    {
        for (int i = 0; i < scopesHandle.Length; i++)
        {
            scopesHandle[i].SetActive(false);
        }
        scopesHandle[2].SetActive(true);
    }
}

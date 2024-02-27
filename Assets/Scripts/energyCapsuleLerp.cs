using System.Collections;
using UnityEngine;

public class energyCapsuleLerp : MonoBehaviour
{
    Vector3 emptyCapsule = new Vector3 (1.0f, 0.01f, 1.0f);
    Vector3 fullBar = new Vector3 (1.0f, 1.0f, 1.0f);
    private bool flag = false;
    private bool isStarted = false;

    void Start()
    {
        transform.localScale = emptyCapsule;
    }

    void Update()
    {
        if (flag && !isStarted)
        {
            StartCoroutine(CoroutineSolution());
            isStarted = true;
        }
    }
    IEnumerator CoroutineSolution()
    {
        float t = 0.0f;
        while (t < 1.0f)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.Lerp(emptyCapsule, fullBar, t);

            Debug.Log("Coroutine running");
            yield return null;
        }
    }
    public void loadUp()
    {
        flag = true;
    }
}

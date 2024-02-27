using UnityEngine;

public class lerp2ndExample : MonoBehaviour
{
    Vector3 startingPosition;
    Vector3 EndingPosition = new Vector3(2f, 0.1f, 0.2f);
    float changingDuration = 4f;
    float timePast;

    void Start()
    {
        startingPosition = transform.position;
    }
    void Update()
    {
        transform.position = Vector3.Lerp (startingPosition, EndingPosition, Mathf.SmoothStep (0, 1, timePast / changingDuration));
        timePast += Time.deltaTime;  
    }
}

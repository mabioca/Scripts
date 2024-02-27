using UnityEngine;

public class lerp4thExample : MonoBehaviour
{
    Vector3 startingPosition;
    Vector3 EndingPosition = new Vector3(2f, -1f, 0.2f);
    float changingDuration = 4f;
    float timePast;

    public AnimationCurve curve;

    void Start()
    {
        startingPosition = transform.position;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(startingPosition, EndingPosition, curve.Evaluate(timePast / changingDuration));
        timePast += Time.deltaTime;
    }
}

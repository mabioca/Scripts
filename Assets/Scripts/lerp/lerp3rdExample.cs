using UnityEngine;

public class lerp3rdExample : MonoBehaviour
{
    Vector3 startingPosition;
    Vector3 EndingPosition = new Vector3(2f, -0.4f, 0.2f);
    float changingDuration = 4f;
    float timePast;

    void Start()
    {
        startingPosition = transform.position;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(startingPosition, EndingPosition, EaseOutBounce (0, 1, timePast / changingDuration));
        timePast += Time.deltaTime;
    }

    public static float EaseOutBounce(float start, float end, float value)
    {
        value /= 1f;
        end -= start;

        if (value < 1 / 2.75f)
            return end * (7.5625f * value * value) + start;

        if (value < 2 / 2.75f)
        {
            value -= 1.5f / 2.75f;
            return end * (7.5625f * value * value + .75f) + start;
        }

        if (value < 2.5 / 2.75)
        {
            value -= 2.25f / 2.75f;
            return end * (7.5625f * (value) * value + .9375f) + start;
        }

        value -= 2.625f / 2.75f;

        return end * (7.5625f * value * value + .984375f) + start;
    }
}

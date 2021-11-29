using UnityEngine;

public class OrbitBehavior : MonoBehaviour
{
    Vector3 center = Vector3.zero;
    float distance = 10;
    float degreesPerSecond = 30.0f;

    void Start()
    {
        distance = Vector3.Distance(center, transform.position);
    }

    void Update()
    {
        var elapsedSeconds = Time.realtimeSinceStartup;
        var orbitAngles = new Vector2(0, degreesPerSecond * elapsedSeconds);
        var lookRotation = Quaternion.Euler(orbitAngles);
		var lookDirection = lookRotation * Vector3.forward;
		var lookPosition = center - lookDirection * distance;
        transform.SetPositionAndRotation(lookPosition, lookRotation);
    }
}

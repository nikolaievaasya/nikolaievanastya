using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public Transform platform;
    
    public Transform[] points;
    
    public float speed;

    private int pointIndex;

    private void Update()
    {
        if (Vector3.Distance(platform.localPosition, points[pointIndex].localPosition) <= 10f)
            pointIndex = pointIndex + 1 ==  points.Length ? 0 : 1;
        
        platform.Translate((points[pointIndex].localPosition - platform.localPosition).normalized * speed * Time.deltaTime, Space.Self);
    }
}

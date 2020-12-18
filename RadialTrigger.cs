using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    [Range(0, 5)]
    public float radius = 1;

    public Transform obj;

    private void OnDrawGizmos()
    {
        Vector3 origin = transform.position;
        Vector3 enemy = obj.position;

        float length = MyDistance(origin, enemy);

        bool inInside = length < radius * radius;

        Gizmos.color = inInside ? Color.green : Color.red;
        Gizmos.DrawWireSphere(origin, radius);
    }

    /// <summary>
    /// Using Distance formula
    /// (a,b)= Square root of a*a+b*b
    /// </summary>
    /// <param name="a"> from </param>
    /// <param name="b"> to </param>
    /// <returns> float value </returns>
    float MyDistance(Vector2 a, Vector2 b)
    {
        Vector3 distance = a - b;
        float length = distance.x * distance.x + distance.y * distance.y;
        length = (float)System.Math.Sqrt(length);
        return length;
    }
}

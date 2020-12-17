using System.Collections;
using System.Collections.Generic;
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

        Vector3 distance = enemy - origin;

        float length = distance.x * distance.x + distance.y * distance.y;
        //length = Mathf.Sqrt(length);

        //Squaring on both side will element the square root for length
        //This is one of the optimization technique

        bool inInside = length < radius*radius;

        Gizmos.color=inInside ?  Color.green : Color.red;

        Gizmos.DrawWireSphere(origin, radius);

    }
}

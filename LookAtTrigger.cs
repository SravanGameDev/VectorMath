using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Threshold from Zero to one
    One = very strict, need to look exactly towards the trigger
    Zero= perpendicular or closer means you are looking at it
*/

public class LookAtTrigger : MonoBehaviour
{
    public Transform player;

    [Range(0,1)]
    public float threshold;

    private void OnDrawGizmos()
    {
        Vector2 center = transform.position;
        Vector2 playerPOs = player.position;
        Vector2 playerDirection = player.right;

        Vector2 playerLookingTiggerDirection = (center - playerPOs).normalized;

        float lookingdirection = Vector2.Dot(playerLookingTiggerDirection, playerDirection);
        bool lookingEachother = lookingdirection >= threshold;

        Gizmos.color = lookingEachother ? Color.green : Color.red;
        Gizmos.DrawLine(playerPOs, playerPOs+playerLookingTiggerDirection);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(playerPOs, playerPOs+playerDirection);

    }

}

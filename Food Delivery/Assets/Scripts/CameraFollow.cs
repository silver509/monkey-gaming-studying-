using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float xOffset = 0;
    public float yOffset = 0;
    public float zOffset = 0;


    public Transform player;

    private void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0 + xOffset, 6 + yOffset, -6 + zOffset);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, 6, -6);
    }
}

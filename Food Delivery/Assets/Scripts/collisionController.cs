using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collider)
    {

        if (this.gameObject.tag == "House" && collider.gameObject.tag == "Player")
        {
            Debug.Log("delivered");
        }
        else if (this.gameObject.tag == "Restaurant" && collider.gameObject.tag == "Player")
        {
            Debug.Log("picked up");
        }
    }
}

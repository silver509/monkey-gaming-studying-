using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{

    public List<GameObject> inventory;
    private void OnCollisionEnter(Collision collider)
    {

        if (this.gameObject.tag == "House" && collider.gameObject.tag == "Player")
        {
            Debug.Log("delivered");
        }
        else if (this.gameObject.tag == "Restaurant" && collider.gameObject.tag == "Player")
        {
            Debug.Log("picked up");
            inventory.Add(collider.gameObject);
            Debug.Log(inventory);
        }
    }
}

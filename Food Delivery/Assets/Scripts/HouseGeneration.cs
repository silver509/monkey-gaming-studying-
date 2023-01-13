using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class HouseGeneration : MonoBehaviour
{
    [SerializeField] private List<GameObject> restaurants = new List<GameObject>();
    [SerializeField] private List<GameObject> houses = new List<GameObject>();
    private List<GameObject> all = new List<GameObject>();
    private List<int> used = new List<int>();

    public static Vector3 pizzaPos;
    public static Vector3 donutPos;
    public static Vector3 burgerPos;
    public static Vector3 coffeePos;
    public static Vector3 sushiPos;
    
    Vector3[] PossibleCoordinations = {
        new Vector3(-3.6f, 0, 3.6f),
        new Vector3(-1.2f, 0, 3.6f),
        new Vector3(-3.6f, 0, 1.2f),
        new Vector3(-1.2f, 0, 1.2f),
        new Vector3(-6, 0, -1.2f),
        new Vector3(-8.4f, 0, 1.2f),
        new Vector3(-8.4f, 0, 3.6f),
        new Vector3(-8.4f, 0, 6),
        new Vector3(-6, 0, 8.4f),
        new Vector3(-3.6f, 0, 8.4f),
        new Vector3(-1.2f, 0, 8.4f),
        new Vector3(1.2f, 0, 8.4f),
        new Vector3(3.6f, 0, 8.4f),
        new Vector3(6, 0, 8.4f),
        new Vector3(8.4f, 0, 6),
        new Vector3(8.4f, 0, 3.6f),
        new Vector3(8.4f, 0, 1.2f),
        new Vector3(3.6f, 0, 3.6f),
        new Vector3(6, 0, -1.2f),
        new Vector3(3.6f, 0, -1.2f),
        new Vector3(8.4f, 0, -3.6f),
        new Vector3(3.6f, 0, -6),
        new Vector3(6, 0, -6),
        new Vector3(1.2f, 0, -8.4f),
        new Vector3(-1.2f, 0, -8.4f), 
        new Vector3(-3.6f, 0, -8.4f),
        new Vector3(-6, 0, -8.4f),
        new Vector3(-8.4f, 0, -6),
        new Vector3(-6, 0, -3.6f),
        new Vector3(-3.6f, 0, -3.6f),
        new Vector3(-1.2f, 0, -3.6f),
        new Vector3(-3.6f, 0, -1.2f),
        new Vector3(3.6f, 0, 1.2f)
    };

    int[] degrees = {270, 90, 270, 90, 0, 90, 90, 90, 180, 180, 180, 180, 180, 180, 270, 270, 270, 90, 180, 180, 270, 0, 0, 0, 0, 0, 0, 90, 180, 180, 180, 90,90};

    void Awake(){
        all = houses.Concat(restaurants).ToList();

        

        int rnd;
        GameObject rndObject;

        foreach (Vector3 pos in PossibleCoordinations){
            while (true)
            {
                rnd = UnityEngine.Random.Range(0, all.Count);
                rndObject = all[rnd];
                if (used.Contains(all.IndexOf(rndObject)))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            int rndDegree = degrees[Array.IndexOf(PossibleCoordinations, pos)];
            GameObject Instant = Instantiate(rndObject, pos, Quaternion.Euler(0, rndDegree, 0), this.transform);
            BoxCollider collider = Instant.gameObject.AddComponent<BoxCollider>();
            collider.size = Instant.GetComponent<MeshFilter>().sharedMesh.bounds.size;

            if (restaurants.Contains(rndObject)){
                used.Add(all.IndexOf(rndObject));
            }
        }
    }
}

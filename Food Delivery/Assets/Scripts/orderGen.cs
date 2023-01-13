using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class orderGen : MonoBehaviour
{
    [SerializeField] private GameObject order;

    public Sprite[] imgs = { };
    private string[] tags = { "hamburger", "pizza", "sushi", "donut", "coffee" };
    /* public Sprite uncheck;
    public Sprite check; 
    public Image countDown; */


    public void gen()
    {
        int i = UnityEngine.Random.Range(0, imgs.Length);
        GameObject newOrder = Instantiate(order, GameObject.FindGameObjectWithTag("GameController").transform);


        /* newOrder.transform.GetChild(1).GetComponent<Image>().sprite = imgs[i];
        newOrder.transform.GetChild(2).GetComponent<Image>().sprite = uncheck;
        newOrder.transform.GetChild(3).GetComponent<Image>().sprite = uncheck; */

        newOrder.transform.localPosition = new Vector2(-Screen.width, Screen.height / 2 - 400);
        newOrder.LeanMoveLocalX(-Screen.width / 2 + 300, 1.5f).setEaseOutBack().setDelay(1.5f);
        newOrder.tag = tags[i];
        Debug.Log(tags[i]);
    }


    public void Start()
    {
        gen();
    }

}

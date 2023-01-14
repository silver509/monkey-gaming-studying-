using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManagers : MonoBehaviour
{

    public TMP_Text scoreText;
    public int money = 0;

    void Start()
    {
        scoreText.text = money.ToString();
    }


    void Update()
    {

    }
}

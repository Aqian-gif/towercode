﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIControl : MonoBehaviour
{
    private Text goldText;
    private int gold = 2000;
    void Start()
    {
        goldText = GameObject.Find("UICanvas").transform.GetChild(1).GetChild(0).GetComponent<Text>();
    }
    void Update()
    {
        //Debug.Log(gold);
        goldText.text = gold.ToString();
    }
    //花费
    public bool Cost(int values)
    {
        if (gold >= values)
        {
            gold -= values;
            return true;
        }
        else
        {
            return false;
        }
    }
}

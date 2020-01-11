﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update

    //public for debuging
    public int score;
    Dictionary<string, int> scoreDict;
    Text text;
    void Start()
    {
        scoreDict = new Dictionary<string, int>
        {
            {"Ring", 100},
            {"Necklace",200},
            {"Scrap",5}
        };
        score = 0;
        text = GetComponent<Text>();
    }

    public void handleCollision(Valuable obj)
    {
        string vType = obj.title;
        score += scoreDict[vType];
    }
    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString("0.");
    }
}
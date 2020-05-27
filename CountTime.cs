using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour
{
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGame)
        {
            if (PlayerManager.instance.timeLimit)
            {
                if (PlayerManager.instance.timeLimitCount >= 0)
                {
                    PlayerManager.instance.timeLimitCount -= Time.deltaTime;
                }
                else
                {
                    GameManager.instance.isGame = false;
                    GameManager.instance.isMissionResult = true;
                }
            }
            text.text = PlayerManager.instance.timeLimitCount.ToString("N0");
        }
    }
}

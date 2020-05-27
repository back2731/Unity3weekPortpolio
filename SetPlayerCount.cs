using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerCount : MonoBehaviour
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
            if (PlayerManager.instance.onActiveUnits.Count >= 1 && PlayerManager.instance.onActiveUnits.Count < 10)
            {
                text.text = "<color=#00ff00>" + "Unit : " + PlayerManager.instance.onActiveUnits.Count.ToString() + " / 10" + "</color>";
            }
            else if (PlayerManager.instance.onActiveUnits.Count == 10)
            {
                text.text = "<color=#ff0000>" + "Unit : " + PlayerManager.instance.onActiveUnits.Count.ToString() + " / 10" + "</color>";
            }
            else
            {
                text.text = "Unit : " + PlayerManager.instance.onActiveUnits.Count.ToString() + " / 10";
            }

        }
    }
}

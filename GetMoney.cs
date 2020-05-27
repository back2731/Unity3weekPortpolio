using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMoney : MonoBehaviour
{
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameResult)
        {
            text.text = "You Get Money : " + PlayerData.instance.PlayerInGameMoney.ToString("N1");
        }
        else
        {
            text.text = "You Get Money : " + (PlayerData.instance.PlayerInGameMoney * 0.5).ToString("N1");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerPower : MonoBehaviour
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
            PlayerManager.instance.playerPower += Time.deltaTime * PlayerManager.instance.playerAddPower;
            text.text = PlayerManager.instance.playerPower.ToString("N1");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetEnemyList : MonoBehaviour
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
            if (EnemyManager.instance.onActiveEnemyUnits.Count >= 20 && EnemyManager.instance.onActiveEnemyUnits.Count < 40)
            {
                text.text = "<color=#00ff00>" + "Enemy : " + EnemyManager.instance.onActiveEnemyUnits.Count.ToString() + " / 50" + "</color>";
            }
            else if (EnemyManager.instance.onActiveEnemyUnits.Count >= 40)
            {
                text.text = "<color=#ff0000>" + "Enemy : " + EnemyManager.instance.onActiveEnemyUnits.Count.ToString() + " / 50" + "</color>";
            }
            else
            {
                text.text = "Enemy : " + EnemyManager.instance.onActiveEnemyUnits.Count.ToString() + " / 50";
            }
        }
    }
}

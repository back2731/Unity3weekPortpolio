using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDeadEffect : MonoBehaviour
{
    ControlPlayerHp playerHp;
    // Start is called before the first frame update
    void Start()
    {
        playerHp = GetComponent<ControlPlayerHp>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHp.playerUnitCurrentHp >= 0)
        {
            Debug.Log("죽음!!!");
        }
    }
}

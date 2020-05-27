using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellPlayerUnit : MonoBehaviour
{
    void Update()
    {
        if (GameManager.instance.isGame)
        {
            if (transform.position.y <= -3.5f)
            {
                PlayerManager.instance.refundUnit = gameObject;
             }
        }
    }
}

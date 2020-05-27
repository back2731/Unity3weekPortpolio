using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropMoney : MonoBehaviour
{
    GameObject money;

   public void Drop()
    {
        money = ObjectPool.instance.GetMoneyObject();

        if (money != null)
        {
            money.transform.position = gameObject.transform.position;
            money.transform.rotation = gameObject.transform.rotation;
            money.SetActive(true);
            money = null;
        }
        //Debug.Log(name + "가 죽었으면 나온다.");
    }
}

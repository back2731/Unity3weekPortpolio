using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDropMoney : MonoBehaviour
{
    private float hommingSpeed = 3.0f;

    void Update()
    {
        if (GameManager.instance.isGame)
        {
            Vector3 targetPosition = new Vector3(2.0f, 5.5f, 0.0f);

            iTween.LookUpdate(gameObject, iTween.Hash("looktarget", targetPosition, "time", 0));
            iTween.MoveUpdate(gameObject, iTween.Hash("position", targetPosition, "time", hommingSpeed, "easetype", iTween.EaseType.easeInExpo));
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("MoneyCollider"))
        {
            gameObject.SetActive(false);
            Debug.Log("돈 흡수!");
        }
    }
}

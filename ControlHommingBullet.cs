using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHommingBullet : MonoBehaviour
{
    private float hommingSpeed = 2.0f;

    private float delay = 1.0f;
    private float shotTime = 0.0f;

    private Vector3 firstPosition;
    private Vector3 endPosition;
    private Vector3 nontargetPosition;

    GameObject bulletEffect;

    private void OnEnable()
    {
        firstPosition = gameObject.transform.position;
        endPosition = new Vector3(firstPosition.x - Random.Range(-2.0f, 2.0f), firstPosition.y - 1.5f, firstPosition.z);
        nontargetPosition = new Vector3(endPosition.x, firstPosition.y + 15.0f, endPosition.z);
        shotTime = Time.time;
    }

    void Update()
    {
        if (GameManager.instance.isGame)
        {
            if (shotTime + delay > Time.time)
            {
                float distCovered = Time.time - shotTime;

                transform.position = Vector3.Slerp(firstPosition, endPosition, distCovered);
            }
            else
            {
                if (EnemyManager.instance.onActiveEnemyUnits.Count > 0)
                {
                    Vector3 targetPosition = EnemyManager.instance.onActiveEnemyUnits[0].transform.position;

                    targetPosition.z = 0f;

                    iTween.LookUpdate(gameObject, iTween.Hash("looktarget", targetPosition, "time", 0));
                    iTween.MoveUpdate(gameObject, iTween.Hash("position", targetPosition, "time", hommingSpeed, "easetype", iTween.EaseType.easeInExpo));
                }
                else
                {
                    iTween.LookUpdate(gameObject, iTween.Hash("looktarget", nontargetPosition, "time", 0));
                    iTween.MoveUpdate(gameObject, iTween.Hash("position", nontargetPosition, "time", hommingSpeed * 2.0f, "easetype", iTween.EaseType.easeInExpo));
                }
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
            //gameObject.tag = "Untagged";
            Debug.Log("총알 벽 충돌 / 비활성화");
        }
        if (collision.CompareTag("Enemy"))
        {
            PlayEffect();
            gameObject.SetActive(false);
            //gameObject.tag = "Untagged";
            Debug.Log("총알 적 충돌 / 비활성화");
        }
    }

    public void PlayEffect()
    {
        bulletEffect = ObjectPool.instance.GetBlueHommingBulletEffect();

        bulletEffect.transform.position = gameObject.transform.position;
        bulletEffect.transform.rotation = gameObject.transform.rotation;
        bulletEffect.SetActive(true);
    }

}
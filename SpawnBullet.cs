using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    private GameObject bullet;
    private float delay = 0.1f;
    
    private void OnEnable()
    {
        StartCoroutine("GetBullet", delay);
    }

    private void OnDisable()
    {
        StopCoroutine("GetBullet");
    }

    IEnumerator GetBullet(float delayTime)
    {
        if (GameManager.instance.isGame)
        {
            //Debug.Log("코루틴이 돌고있다.");

            if (CompareTag("BlueLaserBolt"))
            {
                bullet = ObjectPool.instance.GetBlueLaserBolt();
            }
            else if (CompareTag("GreenLaserBolt"))
            {
                bullet = ObjectPool.instance.GetGreenLaserBolt();
            }
            else if (CompareTag("PurpleLaserBolt"))
            {
                bullet = ObjectPool.instance.GetPurpleLaserBolt();
            }
            else if (CompareTag("RedLaserBolt"))
            {
                bullet = ObjectPool.instance.GetRedLaserBolt();
            }
            else if (CompareTag("WhiteLaserBolt"))
            {
                bullet = ObjectPool.instance.GetWhiteLaserBolt();
            }
            else if (CompareTag("YellowLaserBolt"))
            {
                bullet = ObjectPool.instance.GetYellowLaserBolt();
            }
            else
            {
                bullet = null;
            }

            if (bullet != null)
            {
                bullet.transform.position = gameObject.transform.position;
                bullet.transform.rotation = gameObject.transform.rotation;

                // 스폰오브젝트 부모의 태그를 확인하여 플레이어 불릿과 에너미 불릿을 나눈다.
                if (gameObject.transform.parent.CompareTag("Player"))
                {
                    bullet.gameObject.tag = "PlayerBullet";
                }
                else
                {
                    bullet.gameObject.tag = "EnemyBullet";
                }
                bullet.SetActive(true);
            }

            yield return new WaitForSeconds(delayTime);

            StartCoroutine("GetBullet", delay);
        }
    }
}

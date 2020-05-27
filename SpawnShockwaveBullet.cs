using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShockwaveBullet : MonoBehaviour
{
    private GameObject bullet;
    private float delay = 0.5f;

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
            bullet = ObjectPool.instance.GetShockwaveBullet();

            if (bullet != null)
            {
                bullet.transform.position = gameObject.transform.position;
                bullet.transform.rotation = gameObject.transform.rotation;

                // 스폰오브젝트 부모의 태그를 확인하여 플레이어 불릿과 에너미 불릿을 나눈다.
                bullet.gameObject.tag = "PlayerBullet";
    
                bullet.SetActive(true);
            }

            yield return new WaitForSeconds(delayTime);

            StartCoroutine("GetBullet", delay);
        }
    }
}

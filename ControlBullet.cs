using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBullet : MonoBehaviour
{
    private float speed = 10.0f;
    GameObject bulletEffect;

    void Update()
    {
        if (GameManager.instance.isGame)
        {
            transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
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
        if(collision.CompareTag("Enemy"))
        {
            PlayEffect();
            //collision.gameObject.GetComponent<ControlEnemy>().enemyHp -= 1.0f;
            gameObject.SetActive(false);
            //gameObject.tag = "Untagged";
            Debug.Log("총알 적 충돌 / 비활성화");
        }
    }

    public void PlayEffect()
    {

        switch(transform.parent.tag)
        {
            case "BlueLaserBolt":
                {
                    bulletEffect = ObjectPool.instance.GetBlueLaserBoltEffect();
                }
                break;
            case "GreenLaserBolt":
                {
                    bulletEffect = ObjectPool.instance.GetGreenLaserBoltEffect();
                }
                break;
            case "PurpleLaserBolt":
                {
                    bulletEffect = ObjectPool.instance.GetPurpleLaserBoltEffect();
                }
                break;
            case "RedLaserBolt":
                {
                    bulletEffect = ObjectPool.instance.GetRedLaserBoltEffect();
                }
                break;
            case "WhiteLaserBolt":
                {
                    bulletEffect = ObjectPool.instance.GetWhiteLaserBoltEffect();
                }
                break;
            case "YellowLaserBolt":
                {
                    bulletEffect = ObjectPool.instance.GetYellowLaserBoltEffect();
                }
                break;
            default:
                {
                    bulletEffect = null;
                }
                break;
        }

        bulletEffect.transform.position = gameObject.transform.position;
        bulletEffect.transform.rotation = gameObject.transform.rotation;
        bulletEffect.SetActive(true);
    }
}

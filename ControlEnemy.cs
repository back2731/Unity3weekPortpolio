using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlEnemy : MonoBehaviour
{
    private Vector3 firstPosition;
    private Quaternion firstRotation;

    private Rigidbody rb;
    private Vector3 newDirection;

    private float speed = -1.5f;

    public Image hpBar;

    public float enemyMaxHp;
    public float enemyCurrentHp;

    private GameObject unit;

    private DropMoney dropMoney;

    private void OnEnable()
    {
        firstPosition = transform.position;
        firstRotation = transform.rotation;

        rb = GetComponent<Rigidbody>();
        newDirection = transform.up;
        rb.velocity = newDirection * speed;

        switch (transform.parent.name)
        {
            case "Enemy_LV1":
                {
                    enemyMaxHp = 50;
                    enemyCurrentHp = 50;
                    //Debug.Log("LV1 Enemy Enable");
                }
                break;
            case "Enemy_LV2":
                {
                    enemyMaxHp = 100;
                    enemyCurrentHp = 100;
                    //Debug.Log("LV2 Enemy Enable");
                }
                break;
            case "Enemy_LV3":
                {
                    enemyMaxHp = 150;
                    enemyCurrentHp = 150;
                    //Debug.Log("LV3 Enemy Enable");
                }
                break;
            case "Enemy_LV4":
                {
                    enemyMaxHp = 200;
                    enemyCurrentHp = 200;
                    //Debug.Log("LV4 Enemy Enable");
                }
                break;
            case "Enemy_LV5":
                {
                    enemyMaxHp = 250;
                    enemyCurrentHp = 250;
                    //Debug.Log("LV5 Enemy Enable");
                }
                break;
            case "Enemy_LV6":
                {
                    enemyMaxHp = 300;
                    enemyCurrentHp = 300;
                    //Debug.Log("LV6 Enemy Enable");
                }
                break;

            case "Enemy_LV7":
                {
                    enemyMaxHp = 350;
                    enemyCurrentHp = 350;
                    //Debug.Log("LV7 Enemy Enable");
                }
                break;
            case "Enemy_LV8":
                {
                    enemyMaxHp = 400;
                    enemyCurrentHp = 400;
                    //Debug.Log("LV8 Enemy Enable");
                }
                break;
            case "Enemy_LV9":
                {
                    enemyMaxHp = 450;
                    enemyCurrentHp = 450;
                    //Debug.Log("LV9 Enemy Enable");
                }
                break;
        }

        dropMoney = GetComponent<DropMoney>();
    }

    private void Update()
    {
        hpBar.fillAmount = Mathf.Lerp(hpBar.fillAmount, enemyCurrentHp / enemyMaxHp, Time.deltaTime * 5);

        if (!GameManager.instance.isGame)
        {
            rb.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
        }
        else
        {
            rb.velocity = newDirection * speed;
        }
    }

    private void OnDisable()
    {
        transform.position = firstPosition;
        transform.rotation = firstRotation; 

        newDirection = new Vector3(0.0f, 0.0f, 0.0f);
        rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);

        switch (transform.parent.name)
        {
            case "Enemy_LV1":
                {
                    enemyMaxHp = 50;
                    enemyCurrentHp = 50;
                    //Debug.Log("LV1 Enemy Enable");
                }
                break;
            case "Enemy_LV2":
                {
                    enemyMaxHp = 100;
                    enemyCurrentHp = 100;
                    //Debug.Log("LV2 Enemy Enable");
                }
                break;
            case "Enemy_LV3":
                {
                    enemyMaxHp = 150;
                    enemyCurrentHp = 150;
                    //Debug.Log("LV3 Enemy Enable");
                }
                break;
            case "Enemy_LV4":
                {
                    enemyMaxHp = 200;
                    enemyCurrentHp = 200;
                    //Debug.Log("LV4 Enemy Enable");
                }
                break;
            case "Enemy_LV5":
                {
                    enemyMaxHp = 250;
                    enemyCurrentHp = 250;
                    //Debug.Log("LV5 Enemy Enable");
                }
                break;
            case "Enemy_LV6":
                {
                    enemyMaxHp = 300;
                    enemyCurrentHp = 300;
                    //Debug.Log("LV6 Enemy Enable");
                }
                break;

            case "Enemy_LV7":
                {
                    enemyMaxHp = 350;
                    enemyCurrentHp = 350;
                    //Debug.Log("LV7 Enemy Enable");
                }
                break;
            case "Enemy_LV8":
                {
                    enemyMaxHp = 400;
                    enemyCurrentHp = 400;
                    //Debug.Log("LV8 Enemy Enable");
                }
                break;
            case "Enemy_LV9":
                {
                    enemyMaxHp = 450;
                    enemyCurrentHp = 450;
                    //Debug.Log("LV9 Enemy Enable");
                }
                break;
        }
    }

    // 벽 튕기는 부분
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Wall"))
        {
            newDirection = Vector3.Reflect(newDirection, collision.contacts[0].normal);
            rb.velocity = newDirection * speed;
        }
    }

    // 단발식 탄 충돌
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("PlayerBullet"))
        {
            PlayerData.instance.PlayerInGameMoney += 0.1f;

            switch (collision.transform.parent.tag)
            {
                case "BlueLaserBolt":
                    {
                        enemyCurrentHp -= PlayerData.instance.blueLaserBoltDamage;
                        //Debug.Log("BlueLaserBolt에 맞음");
                    }
                    break;
                case "GreenLaserBolt":
                    {
                        enemyCurrentHp -= PlayerData.instance.greenLaserBoltDamage;
                        //Debug.Log("GreenLaserBolt에 맞음");
                    }
                    break;
                case "PurpleLaserBolt":
                    {
                        enemyCurrentHp -= PlayerData.instance.purpleLaserBoltDamage;
                        //Debug.Log("PurpleLaserBolt에 맞음");
                    }
                    break;
                case "RedLaserBolt":
                    {
                        enemyCurrentHp -= PlayerData.instance.redLaserBoltDamage;
                        //Debug.Log("RedLaserBolt에 맞음");
                    }
                    break;
                case "WhiteLaserBolt":
                    {
                        enemyCurrentHp -= PlayerData.instance.whiteLaserBoltDamage;
                        //Debug.Log("WhiteLaserBolt에 맞음");
                    }
                    break;
                case "YellowLaserBolt":
                    {
                        enemyCurrentHp -= PlayerData.instance.yellowLaserBoltDamage;
                        //Debug.Log("YellowLaserBolt에 맞음");
                    }
                    break;
                case "BlueHommingBullet":
                    {
                        enemyCurrentHp -= PlayerData.instance.blueHommingBulletDamage;
                        //Debug.Log("BlueHommingBullet에 맞음");
                    }
                    break;
                case "ShockwaveBullets":
                    {
                        enemyCurrentHp -= PlayerData.instance.redShockwaveBullet;
                        //Debug.Log("BlueHommingBullet에 맞음");
                    }
                    break;
            }
        }

        if (enemyCurrentHp <= 0)
        {
            switch (transform.parent.name)
            {
                case "Enemy_LV1":
                    {
                        PlayerData.instance.PlayerInGameMoney += 100;
                    }
                    break;
                case "Enemy_LV2":
                    {
                        PlayerData.instance.PlayerInGameMoney += 200;
                        unit = ObjectPool.instance.GetEnemyLV1();
                    }
                    break;
                case "Enemy_LV3":
                    {
                        PlayerData.instance.PlayerInGameMoney += 300;
                        unit = ObjectPool.instance.GetEnemyLV2();
                    }
                    break;
                case "Enemy_LV4":
                    {
                        PlayerData.instance.PlayerInGameMoney += 400;
                        unit = ObjectPool.instance.GetEnemyLV3();
                    }
                    break;
                case "Enemy_LV5":
                    {
                        PlayerData.instance.PlayerInGameMoney += 500;
                        unit = ObjectPool.instance.GetEnemyLV4();
                    }
                    break;
                case "Enemy_LV6":
                    {
                        PlayerData.instance.PlayerInGameMoney += 600;
                        unit = ObjectPool.instance.GetEnemyLV5();
                    }
                    break;
                case "Enemy_LV7":
                    {
                        PlayerData.instance.PlayerInGameMoney += 700;
                        unit = ObjectPool.instance.GetEnemyLV6();
                    }
                    break;
                case "Enemy_LV8":
                    {
                        PlayerData.instance.PlayerInGameMoney += 800;
                        unit = ObjectPool.instance.GetEnemyLV7();
                    }
                    break;
                case "Enemy_LV9":
                    {
                        PlayerData.instance.PlayerInGameMoney += 900;
                        unit = ObjectPool.instance.GetEnemyLV8();
                    }
                    break;
                default:
                    break;
            }

            if (unit != null)
            {
                unit.transform.position = gameObject.transform.position;
                unit.transform.rotation = gameObject.transform.rotation;
                rb.velocity = newDirection * speed;
                unit.SetActive(true);
                unit = null;
            }

            dropMoney.Drop();

            EnemyManager.instance.onActiveEnemyUnits.Remove(gameObject);
            gameObject.SetActive(false);
        }
    }

    // 레이저류 충돌
    private void OnTriggerStay(Collider collision)
    {

        if (collision.CompareTag("OrangeBeamLaser"))
        {
            PlayerData.instance.PlayerInGameMoney += 0.1f;

            enemyCurrentHp -= PlayerData.instance.orangeBeamLaserDamage * Time.deltaTime;
            //Debug.Log(collision.name + "가 충돌!");
        }

        if (enemyCurrentHp <= 0)
        {
            switch (transform.parent.name)
            {
                case "Enemy_LV1":
                    {
                        PlayerData.instance.PlayerInGameMoney += 100;
                    }
                    break;
                case "Enemy_LV2":
                    {
                        PlayerData.instance.PlayerInGameMoney += 200;
                        unit = ObjectPool.instance.GetEnemyLV1();
                    }
                    break;
                case "Enemy_LV3":
                    {
                        PlayerData.instance.PlayerInGameMoney += 300;
                        unit = ObjectPool.instance.GetEnemyLV2();
                    }
                    break;
                case "Enemy_LV4":
                    {
                        PlayerData.instance.PlayerInGameMoney += 400;
                        unit = ObjectPool.instance.GetEnemyLV3();
                    }
                    break;
                case "Enemy_LV5":
                    {
                        PlayerData.instance.PlayerInGameMoney += 500;
                        unit = ObjectPool.instance.GetEnemyLV4();
                    }
                    break;
                case "Enemy_LV6":
                    {
                        PlayerData.instance.PlayerInGameMoney += 600;
                        unit = ObjectPool.instance.GetEnemyLV5();
                    }
                    break;
                case "Enemy_LV7":
                    {
                        PlayerData.instance.PlayerInGameMoney += 700;
                        unit = ObjectPool.instance.GetEnemyLV6();
                    }
                    break;
                case "Enemy_LV8":
                    {
                        PlayerData.instance.PlayerInGameMoney += 800;
                        unit = ObjectPool.instance.GetEnemyLV7();
                    }
                    break;
                case "Enemy_LV9":
                    {
                        PlayerData.instance.PlayerInGameMoney += 900;
                        unit = ObjectPool.instance.GetEnemyLV8();
                    }
                    break;
                default:
                    break;
            }

            if (unit != null)
            {
                unit.transform.position = gameObject.transform.position;
                unit.transform.rotation = gameObject.transform.rotation;
                rb.velocity = newDirection * speed;
                unit.SetActive(true);
                unit = null;
            }

            dropMoney.Drop();

            EnemyManager.instance.onActiveEnemyUnits.Remove(gameObject);
            gameObject.SetActive(false);
        }
    }
}

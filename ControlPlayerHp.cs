using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPlayerHp : MonoBehaviour
{
    private float playerUnitMaxHp;

    public float playerUnitCurrentHp;
    public Image hpBar;

    private void OnEnable()
    {
        switch (transform.parent.tag)
        {
            case "BlueUnit_LV1":
                {
                    playerUnitCurrentHp = 100.0f;
                }
                break;
            case "BlueUnit_LV2":
                {
                    playerUnitCurrentHp = 200.0f;
                }
                break;
            case "BlueUnit_LV3":
                {
                    playerUnitCurrentHp = 300.0f;
                }
                break;
            case "BlueUnit_LV4":
                {
                    playerUnitCurrentHp = 400.0f;
                }
                break;
            case "BlueUnit_LV5":
                {
                    playerUnitCurrentHp = 500.0f;
                }
                break;
            case "BlueUnit_LV6":
                {
                    playerUnitCurrentHp = 600.0f;
                }
                break;
            case "GreenUnit_LV1":
                {
                    playerUnitCurrentHp = 100.0f;
                }
                break;
            case "GreenUnit_LV2":
                {
                    playerUnitCurrentHp = 200.0f;
                }
                break;
            case "GreenUnit_LV3":
                {
                    playerUnitCurrentHp = 300.0f;
                }
                break;
            case "GreenUnit_LV4":
                {
                    playerUnitCurrentHp = 400.0f;
                }
                break;
            case "GreenUnit_LV5":
                {
                    playerUnitCurrentHp = 500.0f;
                }
                break;
            case "GreenUnit_LV6":
                {
                    playerUnitCurrentHp = 600.0f;
                }
                break;
            case "OrangeUnit_LV1":
                {
                    playerUnitCurrentHp = 100.0f;
                }
                break;
            case "OrangeUnit_LV2":
                {
                    playerUnitCurrentHp = 200.0f;
                }
                break;
            case "OrangeUnit_LV3":
                {
                    playerUnitCurrentHp = 300.0f;
                }
                break;
            case "OrangeUnit_LV4":
                {
                    playerUnitCurrentHp = 400.0f;
                }
                break;
            case "OrangeUnit_LV5":
                {
                    playerUnitCurrentHp = 500.0f;
                }
                break;
            case "OrangeUnit_LV6":
                {
                    playerUnitCurrentHp = 600.0f;
                }
                break;
            case "GrayUnit_LV1":
                {
                    playerUnitCurrentHp = 100.0f;
                }
                break;
            case "GrayUnit_LV2":
                {
                    playerUnitCurrentHp = 200.0f;
                }
                break;
            case "GrayUnit_LV3":
                {
                    playerUnitCurrentHp = 300.0f;
                }
                break;
            case "GrayUnit_LV4":
                {
                    playerUnitCurrentHp = 400.0f;
                }
                break;
            case "GrayUnit_LV5":
                {
                    playerUnitCurrentHp = 500.0f;
                }
                break;
            case "GrayUnit_LV6":
                {
                    playerUnitCurrentHp = 600.0f;
                }
                break;
            case "RedUnit_LV1":
                {
                    playerUnitCurrentHp = 100.0f;
                }
                break;
            case "RedUnit_LV2":
                {
                    playerUnitCurrentHp = 200.0f;
                }
                break;
            case "RedUnit_LV3":
                {
                    playerUnitCurrentHp = 300.0f;
                }
                break;
            case "RedUnit_LV4":
                {
                    playerUnitCurrentHp = 400.0f;
                }
                break;
            case "RedUnit_LV5":
                {
                    playerUnitCurrentHp = 500.0f;
                }
                break;
            case "RedUnit_LV6":
                {
                    playerUnitCurrentHp = 600.0f;
                }
                break;
        }
        playerUnitMaxHp = playerUnitCurrentHp;
    }

    private void OnDisable()
    {
        playerUnitCurrentHp = playerUnitMaxHp;
        hpBar.fillAmount = 100.0f;
    }

    private void Update()
    {
        hpBar.fillAmount = Mathf.Lerp(hpBar.fillAmount, playerUnitCurrentHp / playerUnitMaxHp, Time.deltaTime * 5);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //Debug.Log("적과 충돌중");
            playerUnitCurrentHp -= Time.deltaTime * 10.0f;

            if(playerUnitCurrentHp <= 0)
            {
                PlayDeadEffect();
                transform.parent.gameObject.SetActive(false);
                PlayerManager.instance.onActiveUnits.Remove(transform.parent.gameObject);
            }
        }
        if(other.CompareTag("HealingBullets"))
        {
            if (playerUnitCurrentHp <= playerUnitMaxHp)
            {
                playerUnitCurrentHp += Time.deltaTime * 7.0f;
                //Debug.Log("힐링중");
            }
        }
    }

    public void PlayDeadEffect()
    {
        GameObject deadEffect;
        switch (transform.parent.transform.parent.transform.parent.name)
        {
            case "BlueUnit":
                {
                    deadEffect = ObjectPool.instance.GetBlueDeadEffect();
                }
                break;
            case "GreenUnit":
                {
                    deadEffect = ObjectPool.instance.GetGreenDeadEffect();
                }
                break;
            case "OrangeUnit":
                {
                    deadEffect = ObjectPool.instance.GetOrangeDeadEffect();
                }
                break;
            case "GrayUnit":
                {
                    deadEffect = ObjectPool.instance.GetGrayDeadEffect();
                }
                break;
            case "RedUnit":
                {
                    deadEffect = ObjectPool.instance.GetRedDeadEffect();
                }
                break;
            default:
                {
                    deadEffect = ObjectPool.instance.GetPurpleDeadEffect();
                }
                break;
        }

        if (deadEffect != null)
        {
            deadEffect.transform.position = gameObject.transform.position;
            deadEffect.transform.rotation = gameObject.transform.rotation;
            deadEffect.SetActive(true);
            deadEffect = null;
        }

        //Debug.Log(name + "가 죽었으면 나온다.");
    }
}

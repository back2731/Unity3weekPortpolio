using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyUnit : MonoBehaviour
{
    private float enemyUnit_Lv1_Probability;
    private float enemyUnit_Lv2_Probability;
    private float enemyUnit_Lv3_Probability;
    private float enemyUnit_Lv4_Probability;
    private float enemyUnit_Lv5_Probability;
    private float enemyUnit_Lv6_Probability;
    private float enemyUnit_Lv7_Probability;
    private float enemyUnit_Lv8_Probability;
    private float enemyUnit_Lv9_Probability;

    private float result;
    private int spawnUnitLV;

    private GameObject unit;

    // Start is called before the first frame update
    private void Awake()
    {
        enemyUnit_Lv1_Probability = StageManager.instance.enemyUnit_Lv1_Probability;
        enemyUnit_Lv2_Probability = StageManager.instance.enemyUnit_Lv2_Probability;
        enemyUnit_Lv3_Probability = StageManager.instance.enemyUnit_Lv3_Probability;
        enemyUnit_Lv4_Probability = StageManager.instance.enemyUnit_Lv4_Probability;
        enemyUnit_Lv5_Probability = StageManager.instance.enemyUnit_Lv5_Probability;
        enemyUnit_Lv6_Probability = StageManager.instance.enemyUnit_Lv6_Probability;
        enemyUnit_Lv7_Probability = StageManager.instance.enemyUnit_Lv7_Probability;
        enemyUnit_Lv8_Probability = StageManager.instance.enemyUnit_Lv8_Probability;
        enemyUnit_Lv9_Probability = StageManager.instance.enemyUnit_Lv9_Probability;
        StartCoroutine("Spawn");
    }

    private void OnDisable()
    {
        StopCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        if (GameManager.instance.isGame)
        {
            yield return new WaitForSeconds(PlayerManager.instance.enemySpawnDelay);

            result = Random.Range(0.0f, enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                                      + enemyUnit_Lv4_Probability + enemyUnit_Lv5_Probability + enemyUnit_Lv6_Probability
                                      + enemyUnit_Lv7_Probability + enemyUnit_Lv8_Probability + enemyUnit_Lv9_Probability);
            if (result <= enemyUnit_Lv1_Probability)
            {
                spawnUnitLV = 1;
                //Debug.Log("LV1 Enemy Spawn!");
            }
            else if (result > enemyUnit_Lv1_Probability && result <= enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability)
            {
                spawnUnitLV = 2;
                //Debug.Log("LV2 Enemy Spawn!");
            }
            else if (result > enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability && result <= enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability)
            {
                spawnUnitLV = 3;
                //Debug.Log("LV3 Enemy Spawn!");
            }
            else if (result > enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability &&
                    result <= enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                            + enemyUnit_Lv4_Probability)
            {
                spawnUnitLV = 4;
                //Debug.Log("LV4 Enemy Spawn!");
            }
            else if (result > enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                            + enemyUnit_Lv4_Probability &&
                    result <= enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                            + enemyUnit_Lv4_Probability + enemyUnit_Lv5_Probability)
            {
                spawnUnitLV = 5;
                //Debug.Log("LV5 Enemy Spawn!");
            }
            else if (result > enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                            + enemyUnit_Lv4_Probability + enemyUnit_Lv5_Probability &&
                    result <= enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                            + enemyUnit_Lv4_Probability + enemyUnit_Lv5_Probability + enemyUnit_Lv6_Probability)
            {
                spawnUnitLV = 6;
                //Debug.Log("LV6 Enemy Spawn!");
            }
            else if (result > enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                            + enemyUnit_Lv4_Probability + enemyUnit_Lv5_Probability + enemyUnit_Lv6_Probability &&
                    result <= enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                            + enemyUnit_Lv4_Probability + enemyUnit_Lv5_Probability + enemyUnit_Lv6_Probability
                            + enemyUnit_Lv7_Probability)
            {
                spawnUnitLV = 7;
                //Debug.Log("LV7 Enemy Spawn!");
            }
            else if (result > enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                            + enemyUnit_Lv4_Probability + enemyUnit_Lv5_Probability + enemyUnit_Lv6_Probability
                            + enemyUnit_Lv7_Probability &&
                    result <= enemyUnit_Lv1_Probability + enemyUnit_Lv2_Probability + enemyUnit_Lv3_Probability
                            + enemyUnit_Lv4_Probability + enemyUnit_Lv5_Probability + enemyUnit_Lv6_Probability
                            + enemyUnit_Lv7_Probability + enemyUnit_Lv8_Probability)
            {
                spawnUnitLV = 8;
                //Debug.Log("LV8 Enemy Spawn!");
            }
            else
            {
                spawnUnitLV = 9;
                //Debug.Log("LV9 Enemy Spawn!");
            }

            switch (spawnUnitLV)
            {
                case 1:
                    {
                        unit = ObjectPool.instance.GetEnemyLV1();
                    }
                    break;
                case 2:
                    {
                        unit = ObjectPool.instance.GetEnemyLV2();
                    }
                    break;
                case 3:
                    {
                        unit = ObjectPool.instance.GetEnemyLV3();
                    }
                    break;
                case 4:
                    {
                        unit = ObjectPool.instance.GetEnemyLV4();
                    }
                    break;
                case 5:
                    {
                        unit = ObjectPool.instance.GetEnemyLV5();
                    }
                    break;
                case 6:
                    {
                        unit = ObjectPool.instance.GetEnemyLV6();
                    }
                    break;
                case 7:
                    {
                        unit = ObjectPool.instance.GetEnemyLV7();
                    }
                    break;
                case 8:
                    {
                        unit = ObjectPool.instance.GetEnemyLV8();
                    }
                    break;
                case 9:
                    {
                        unit = ObjectPool.instance.GetEnemyLV9();
                    }
                    break;
            }

            if (unit != null)
            {
                unit.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(3.0f, 4.0f), 0);
                unit.transform.rotation = gameObject.transform.rotation;
                unit.SetActive(true);
            }
            StartCoroutine("Spawn");
        }
    }
}
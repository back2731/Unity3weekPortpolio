using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : Singleton<StageManager>
{
    [SerializeField]
    private int stageNumber = 0;

    public float enemyUnit_Lv1_Probability = 0.0f;
    public float enemyUnit_Lv2_Probability = 0.0f;
    public float enemyUnit_Lv3_Probability = 0.0f;
    public float enemyUnit_Lv4_Probability = 0.0f;
    public float enemyUnit_Lv5_Probability = 0.0f;
    public float enemyUnit_Lv6_Probability = 0.0f;
    public float enemyUnit_Lv7_Probability = 0.0f;
    public float enemyUnit_Lv8_Probability = 0.0f;
    public float enemyUnit_Lv9_Probability = 1.0f;

    public int StageNumber
    {
        get
        {
            return stageNumber;
        }
        set
        {
            stageNumber = value;
            SetStage();
        }
    }

    public void SetStage()
    {
        switch (stageNumber)
        {
            case 0:
                {
                    enemyUnit_Lv1_Probability = 0.0f;
                    enemyUnit_Lv2_Probability = 0.0f;
                    enemyUnit_Lv3_Probability = 0.0f;
                    enemyUnit_Lv4_Probability = 0.0f;
                    enemyUnit_Lv5_Probability = 0.0f;
                    enemyUnit_Lv6_Probability = 0.0f;
                    enemyUnit_Lv7_Probability = 0.0f;
                    enemyUnit_Lv8_Probability = 0.0f;
                    enemyUnit_Lv9_Probability = 0.0f;
                    Debug.Log("씬 초기화 -> 로비로");
                }
                break;
            case 1:
                {
                    enemyUnit_Lv1_Probability = 1.0f;
                    enemyUnit_Lv2_Probability = 0.0f;
                    enemyUnit_Lv3_Probability = 0.0f;
                    enemyUnit_Lv4_Probability = 0.0f;
                    enemyUnit_Lv5_Probability = 0.0f;
                    enemyUnit_Lv6_Probability = 0.0f;
                    enemyUnit_Lv7_Probability = 0.0f;
                    enemyUnit_Lv8_Probability = 0.0f;
                    enemyUnit_Lv9_Probability = 0.0f;

                    Debug.Log("Stage1 세팅");
                }
                break;
            case 2:
                {
                    enemyUnit_Lv1_Probability = 1.0f;
                    enemyUnit_Lv2_Probability = 1.0f;
                    enemyUnit_Lv3_Probability = 0.0f;
                    enemyUnit_Lv4_Probability = 0.0f;
                    enemyUnit_Lv5_Probability = 0.0f;
                    enemyUnit_Lv6_Probability = 0.0f;
                    enemyUnit_Lv7_Probability = 0.0f;
                    enemyUnit_Lv8_Probability = 0.0f;
                    enemyUnit_Lv9_Probability = 0.0f;
                    Debug.Log("Stage2 세팅");
                }
                break;
            case 3:
                {
                    enemyUnit_Lv1_Probability = 1.0f;
                    enemyUnit_Lv2_Probability = 1.0f;
                    enemyUnit_Lv3_Probability = 1.0f;
                    enemyUnit_Lv4_Probability = 0.0f;
                    enemyUnit_Lv5_Probability = 0.0f;
                    enemyUnit_Lv6_Probability = 0.0f;
                    enemyUnit_Lv7_Probability = 0.0f;
                    enemyUnit_Lv8_Probability = 0.0f;
                    enemyUnit_Lv9_Probability = 0.0f;
                    Debug.Log("Stage3 세팅");
                }
                break;
            case 4:
                {
                    enemyUnit_Lv1_Probability = 1.0f;
                    enemyUnit_Lv2_Probability = 1.0f;
                    enemyUnit_Lv3_Probability = 1.0f;
                    enemyUnit_Lv4_Probability = 1.0f;
                    enemyUnit_Lv5_Probability = 0.0f;
                    enemyUnit_Lv6_Probability = 0.0f;
                    enemyUnit_Lv7_Probability = 0.0f;
                    enemyUnit_Lv8_Probability = 0.0f;
                    enemyUnit_Lv9_Probability = 0.0f;
                    Debug.Log("Stage4 세팅");
                }
                break;
            case 5:
                {
                    enemyUnit_Lv1_Probability = 1.0f;
                    enemyUnit_Lv2_Probability = 1.0f;
                    enemyUnit_Lv3_Probability = 1.0f;
                    enemyUnit_Lv4_Probability = 1.0f;
                    enemyUnit_Lv5_Probability = 1.0f;
                    enemyUnit_Lv6_Probability = 0.0f;
                    enemyUnit_Lv7_Probability = 0.0f;
                    enemyUnit_Lv8_Probability = 0.0f;
                    enemyUnit_Lv9_Probability = 0.0f;
                    Debug.Log("Stage5 세팅");
                }
                break;
            case 6:
                {
                    enemyUnit_Lv1_Probability = 1.0f;
                    enemyUnit_Lv2_Probability = 1.0f;
                    enemyUnit_Lv3_Probability = 1.0f;
                    enemyUnit_Lv4_Probability = 1.0f;
                    enemyUnit_Lv5_Probability = 1.0f;
                    enemyUnit_Lv6_Probability = 1.0f;
                    enemyUnit_Lv7_Probability = 0.0f;
                    enemyUnit_Lv8_Probability = 0.0f;
                    enemyUnit_Lv9_Probability = 0.0f;
                    Debug.Log("Stage6 세팅");
                }
                break;
            case 7:
                {
                    enemyUnit_Lv1_Probability = 1.0f;
                    enemyUnit_Lv2_Probability = 1.0f;
                    enemyUnit_Lv3_Probability = 1.0f;
                    enemyUnit_Lv4_Probability = 1.0f;
                    enemyUnit_Lv5_Probability = 1.0f;
                    enemyUnit_Lv6_Probability = 1.0f;
                    enemyUnit_Lv7_Probability = 1.0f;
                    enemyUnit_Lv8_Probability = 0.0f;
                    enemyUnit_Lv9_Probability = 0.0f;
                    Debug.Log("Stage7 세팅");
                }
                break;
            case 8:
                {
                    enemyUnit_Lv1_Probability = 1.0f;
                    enemyUnit_Lv2_Probability = 1.0f;
                    enemyUnit_Lv3_Probability = 1.0f;
                    enemyUnit_Lv4_Probability = 1.0f;
                    enemyUnit_Lv5_Probability = 1.0f;
                    enemyUnit_Lv6_Probability = 1.0f;
                    enemyUnit_Lv7_Probability = 1.0f;
                    enemyUnit_Lv8_Probability = 1.0f;
                    enemyUnit_Lv9_Probability = 0.0f;
                    Debug.Log("Stage8 세팅");
                }
                break;
            case 9:
                {
                    enemyUnit_Lv1_Probability = 1.0f;
                    enemyUnit_Lv2_Probability = 1.0f;
                    enemyUnit_Lv3_Probability = 1.0f;
                    enemyUnit_Lv4_Probability = 1.0f;
                    enemyUnit_Lv5_Probability = 1.0f;
                    enemyUnit_Lv6_Probability = 1.0f;
                    enemyUnit_Lv7_Probability = 1.0f;
                    enemyUnit_Lv8_Probability = 1.0f;
                    enemyUnit_Lv9_Probability = 1.0f;
                    Debug.Log("Stage9 세팅");
                }
                break;
            case 10:
                {
                    enemyUnit_Lv1_Probability = 0.0f;
                    enemyUnit_Lv2_Probability = 0.0f;
                    enemyUnit_Lv3_Probability = 0.0f;
                    enemyUnit_Lv4_Probability = 0.0f;
                    enemyUnit_Lv5_Probability = 0.0f;
                    enemyUnit_Lv6_Probability = 0.0f;
                    enemyUnit_Lv7_Probability = 0.0f;
                    enemyUnit_Lv8_Probability = 0.0f;
                    enemyUnit_Lv9_Probability = 1.0f;
                    Debug.Log("SpecialStage 세팅");
                }
                break;
        }
    }
}

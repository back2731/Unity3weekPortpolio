using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    public List<GameObject> onActiveUnits = new List<GameObject>();
    public int unitMax = 10;
    public int upgradeCondition = 3;
    public float unitBaseCost = 10.0f;
    public float unitSelectCost = 30.0f;

    public GameObject refundUnit;

    public float lv1Cost;
    public float lv2Cost;
    public float lv3Cost;
    public float lv4Cost;
    public float lv5Cost;
    public float lv6Cost;

    public float enemySpawnDelay;
    public float playerPower;
    public float playerAddPower;

    public bool timeLimit;
    public float timeLimitCount;

    protected override void Awake()
    {
        lv1Cost = unitBaseCost;
        lv2Cost = lv1Cost * upgradeCondition;
        lv3Cost = lv2Cost * upgradeCondition;
        lv4Cost = lv3Cost * upgradeCondition;
        lv5Cost = lv4Cost * upgradeCondition;
        lv6Cost = lv5Cost * upgradeCondition;
        enemySpawnDelay = 3.0f;
        playerPower = 0.0f;
        playerAddPower = 1.0f;
        timeLimit = true;
        timeLimitCount = 120.0f;
    }

    private void Update()
    {
        if (GameManager.instance.isGame)
        {
            if (refundUnit != null)
            {
                if (refundUnit.transform.position.y > -3.5f)
                {
                    refundUnit = null;
                }
            }
        }
    }
}

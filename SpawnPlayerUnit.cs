using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerUnit : MonoBehaviour
{
    private float blueUnitProbability;
    private float greenUnitProbability;
    private float orangeUnitProbability;
    private float grayUnitProbability;
    private float redUnitProbability;

    private float result;

    private GameObject unit;

    [SerializeField]
    private List<int> tempList = new List<int>();
    private int pastListCount;

    private AudioSource buttonSound;

    private void Awake()
    {
        buttonSound = GetComponent<AudioSource>();
    }

    private void Start()
    {
        pastListCount = PlayerManager.instance.onActiveUnits.Count;
        blueUnitProbability = PlayerData.instance.blueUnitProbability;
        greenUnitProbability = PlayerData.instance.greenUnitProbability;
        orangeUnitProbability = PlayerData.instance.orangeUnitProbability;
        grayUnitProbability = PlayerData.instance.grayUnitProbability;
        redUnitProbability = PlayerData.instance.redUnitProbability;
    }

    public void SpawnBlueUnit()
    {
        if (PlayerManager.instance.playerPower >= PlayerManager.instance.unitSelectCost)
        {
            if (PlayerManager.instance.onActiveUnits.Count < PlayerManager.instance.unitMax)
            {
                PlayerManager.instance.playerPower -= PlayerManager.instance.unitSelectCost;

                GameObject blueUnit;
                blueUnit = ObjectPool.instance.GetBlueUnit(Unit.blueUnit_LV1);

                // 가져온 유닛오브젝트를 활성화
                if (blueUnit != null)
                {
                    blueUnit.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-1.0f, 1.0f), 0);
                    blueUnit.transform.rotation = gameObject.transform.rotation;
                    blueUnit.SetActive(true);
                    PlayerManager.instance.onActiveUnits.Add(blueUnit);

                    UpgradeUnit("Blue", Unit.blueUnit_LV1);
                    UpgradeUnit("Blue", Unit.blueUnit_LV2);
                    UpgradeUnit("Blue", Unit.blueUnit_LV3);
                    UpgradeUnit("Blue", Unit.blueUnit_LV4);
                    UpgradeUnit("Blue", Unit.blueUnit_LV5);
                }
            }
        }
        buttonSound.Play();
    }

    public void SpawnGreenUnit()
    {
        if (PlayerManager.instance.playerPower >= PlayerManager.instance.unitSelectCost)
        {
            if (PlayerManager.instance.onActiveUnits.Count < PlayerManager.instance.unitMax)
            {
                PlayerManager.instance.playerPower -= PlayerManager.instance.unitSelectCost;

                GameObject greenUnit;
                greenUnit = ObjectPool.instance.GetGreenUnit(Unit.greenUnit_LV1);

                // 가져온 유닛오브젝트를 활성화
                if (greenUnit != null)
                {
                    greenUnit.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-1.0f, 1.0f), 0);
                    greenUnit.transform.rotation = gameObject.transform.rotation;
                    greenUnit.SetActive(true);
                    PlayerManager.instance.onActiveUnits.Add(greenUnit);

                    UpgradeUnit("Green", Unit.greenUnit_LV1);
                    UpgradeUnit("Green", Unit.greenUnit_LV2);
                    UpgradeUnit("Green", Unit.greenUnit_LV3);
                    UpgradeUnit("Green", Unit.greenUnit_LV4);
                    UpgradeUnit("Green", Unit.greenUnit_LV5);
                }
            }
        }
        buttonSound.Play();
    }

    public void SpawnOrangeUnit()
    {
        if (PlayerManager.instance.playerPower >= PlayerManager.instance.unitSelectCost)
        {
            if (PlayerManager.instance.onActiveUnits.Count < PlayerManager.instance.unitMax)
            {
                PlayerManager.instance.playerPower -= PlayerManager.instance.unitSelectCost;

                GameObject orangeUnit;
                orangeUnit = ObjectPool.instance.GetOrangeUnit(Unit.orangeUnit_LV1);

                // 가져온 유닛오브젝트를 활성화
                if (orangeUnit != null)
                {
                    orangeUnit.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-1.0f, 1.0f), 0);
                    orangeUnit.transform.rotation = gameObject.transform.rotation;
                    orangeUnit.SetActive(true);
                    PlayerManager.instance.onActiveUnits.Add(orangeUnit);

                    UpgradeUnit("Orange", Unit.orangeUnit_LV1);
                    UpgradeUnit("Orange", Unit.orangeUnit_LV2);
                    UpgradeUnit("Orange", Unit.orangeUnit_LV3);
                    UpgradeUnit("Orange", Unit.orangeUnit_LV4);
                    UpgradeUnit("Orange", Unit.orangeUnit_LV5);
                }
            }
        }
        buttonSound.Play();
    }

    public void SpawnGrayUnit()
    {
        if (PlayerManager.instance.playerPower >= PlayerManager.instance.unitSelectCost)
        {
            if (PlayerManager.instance.onActiveUnits.Count < PlayerManager.instance.unitMax)
            {
                PlayerManager.instance.playerPower -= PlayerManager.instance.unitSelectCost;

                GameObject grayUnit;
                grayUnit = ObjectPool.instance.GetGrayUnit(Unit.grayUnit_LV1);

                // 가져온 유닛오브젝트를 활성화
                if (grayUnit != null)
                {
                    grayUnit.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-1.0f, 1.0f), 0);
                    grayUnit.transform.rotation = gameObject.transform.rotation;
                    grayUnit.SetActive(true);
                    PlayerManager.instance.onActiveUnits.Add(grayUnit);

                    UpgradeUnit("Gray", Unit.grayUnit_LV1);
                    UpgradeUnit("Gray", Unit.grayUnit_LV2);
                    UpgradeUnit("Gray", Unit.grayUnit_LV3);
                    UpgradeUnit("Gray", Unit.grayUnit_LV4);
                    UpgradeUnit("Gray", Unit.grayUnit_LV5);
                }
            }
        }
        buttonSound.Play();
    }

    public void SpawnRedUnit()
    {
        if (PlayerManager.instance.playerPower >= PlayerManager.instance.unitSelectCost)
        {
            if (PlayerManager.instance.onActiveUnits.Count < PlayerManager.instance.unitMax)
            {
                PlayerManager.instance.playerPower -= PlayerManager.instance.unitSelectCost;

                GameObject redUnit;
                redUnit = ObjectPool.instance.GetRedUnit(Unit.redUnit_LV1);

                // 가져온 유닛오브젝트를 활성화
                if (redUnit != null)
                {
                    redUnit.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-1.0f, 1.0f), 0);
                    redUnit.transform.rotation = gameObject.transform.rotation;
                    redUnit.SetActive(true);
                    PlayerManager.instance.onActiveUnits.Add(redUnit);

                    UpgradeUnit("Red", Unit.redUnit_LV1);
                    UpgradeUnit("Red", Unit.redUnit_LV2);
                    UpgradeUnit("Red", Unit.redUnit_LV3);
                    UpgradeUnit("Red", Unit.redUnit_LV4);
                    UpgradeUnit("Red", Unit.redUnit_LV5);
                }
            }
        }
        buttonSound.Play();
    }

    public void UpgradeUnit(string color, Unit unitLV)
    {
        if (color == "Blue")
        {
            switch(unitLV)
            {
                case Unit.blueUnit_LV1:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV1"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV1"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.blueUnit_LV2);
                            upgradeCount = 0;
                        }
                    }
                        break;

                case Unit.blueUnit_LV2:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV2"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV2"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.blueUnit_LV3);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.blueUnit_LV3:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV3"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV3"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.blueUnit_LV4);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.blueUnit_LV4:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV4"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV4"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.blueUnit_LV5);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.blueUnit_LV5:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV5"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("BlueUnit_LV5"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.blueUnit_LV6);
                            upgradeCount = 0;
                        }
                    }
                    break;
            }
        }
        else if(color == "Green")
        {
            switch (unitLV)
            {
                case Unit.greenUnit_LV1:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV1"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV1"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.greenUnit_LV2);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.greenUnit_LV2:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV2"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV2"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.greenUnit_LV3);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.greenUnit_LV3:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV3"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV3"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.greenUnit_LV4);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.greenUnit_LV4:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV4"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV4"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.greenUnit_LV5);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.greenUnit_LV5:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV5"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GreenUnit_LV5"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.greenUnit_LV6);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.greenUnit_LV6:
                    break;
            }
        }
        else if (color == "Orange")
        {
            switch (unitLV)
            {
                case Unit.orangeUnit_LV1:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV1"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV1"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.orangeUnit_LV2);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.orangeUnit_LV2:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV2"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV2"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.orangeUnit_LV3);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.orangeUnit_LV3:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV3"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV3"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.orangeUnit_LV4);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.orangeUnit_LV4:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV4"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV4"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.orangeUnit_LV5);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.orangeUnit_LV5:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV5"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("OrangeUnit_LV5"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.orangeUnit_LV6);
                            upgradeCount = 0;
                        }
                    }
                    break;
            }
        }
        else if (color == "Gray")
        {
            switch (unitLV)
            {
                case Unit.grayUnit_LV1:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV1"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV1"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.grayUnit_LV2);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.grayUnit_LV2:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV2"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV2"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.grayUnit_LV3);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.grayUnit_LV3:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV3"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV3"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.grayUnit_LV4);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.grayUnit_LV4:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV4"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV4"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.grayUnit_LV5);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.grayUnit_LV5:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV5"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("GrayUnit_LV5"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.grayUnit_LV6);
                            upgradeCount = 0;
                        }
                    }
                    break;
            }
        }
        else if (color == "Red")
        {
            switch (unitLV)
            {
                case Unit.redUnit_LV1:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV1"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV1"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.redUnit_LV2);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.redUnit_LV2:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV2"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV2"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.redUnit_LV3);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.redUnit_LV3:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV3"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV3"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.redUnit_LV4);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.redUnit_LV4:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV4"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV4"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.redUnit_LV5);
                            upgradeCount = 0;
                        }
                    }
                    break;
                case Unit.redUnit_LV5:
                    {
                        int upgradeCount = 0;

                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV5"))
                            {
                                upgradeCount++;
                            }
                        }

                        if (upgradeCount != PlayerManager.instance.upgradeCondition)
                        {
                            upgradeCount = 0;
                        }
                        else if (upgradeCount == PlayerManager.instance.upgradeCondition)
                        {
                            for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                            {
                                if (PlayerManager.instance.onActiveUnits[i].CompareTag("RedUnit_LV5"))
                                {
                                    tempList.Add(i);
                                }
                            }
                            for (int i = tempList.Count - 1; i >= 0; i--)
                            {
                                PlayerManager.instance.onActiveUnits[tempList[i]].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(tempList[i]);
                            }
                            tempList.Clear();
                            StartCoroutine("Spawn", Unit.redUnit_LV6);
                            upgradeCount = 0;
                        }
                    }
                    break;
            }
        }
    }

    public void SpawnUnit()
    {
        if (PlayerManager.instance.playerPower >= PlayerManager.instance.unitBaseCost)
        {
            PlayerManager.instance.playerPower -= PlayerManager.instance.unitBaseCost;

            if (PlayerManager.instance.onActiveUnits.Count < PlayerManager.instance.unitMax)
            {
                result = Random.Range(0.0f, blueUnitProbability + greenUnitProbability + orangeUnitProbability + grayUnitProbability + redUnitProbability);

                if (result <= blueUnitProbability)
                {
                    StartCoroutine("Spawn", Unit.blueUnit_LV1);

                    Debug.Log("blueUnit_LV1 Spawn");
                }
                else if (result > blueUnitProbability && result <= blueUnitProbability + greenUnitProbability)
                {
                    StartCoroutine("Spawn", Unit.greenUnit_LV1);

                    Debug.Log("greenUnit_LV1 Spawn");
                }
                else if (result > blueUnitProbability + greenUnitProbability && result <= blueUnitProbability + greenUnitProbability + orangeUnitProbability)
                {
                    StartCoroutine("Spawn", Unit.orangeUnit_LV1);

                    Debug.Log("orangeUnit_LV1 Spawn");
                }
                else if (result > blueUnitProbability + greenUnitProbability + orangeUnitProbability && result <= blueUnitProbability + greenUnitProbability + orangeUnitProbability + grayUnitProbability)
                {
                    StartCoroutine("Spawn", Unit.grayUnit_LV1);

                    Debug.Log("grayUnit_LV1 Spawn");
                }
                else
                {
                    StartCoroutine("Spawn", Unit.redUnit_LV1);

                    Debug.Log("redUnit_LV6 Spawn");
                }
            }
        }
        buttonSound.Play();
    }

    IEnumerator Spawn(Unit Unit)
    {
        if (GameManager.instance.isGame)
        {
            switch (Unit)
            {
                case Unit.blueUnit_LV1:
                    unit = ObjectPool.instance.GetBlueUnit(Unit.blueUnit_LV1);
                    break;
                case Unit.blueUnit_LV2:
                    unit = ObjectPool.instance.GetBlueUnit(Unit.blueUnit_LV2);
                    break;
                case Unit.blueUnit_LV3:
                    unit = ObjectPool.instance.GetBlueUnit(Unit.blueUnit_LV3);
                    break;
                case Unit.blueUnit_LV4:
                    unit = ObjectPool.instance.GetBlueUnit(Unit.blueUnit_LV4);
                    break;
                case Unit.blueUnit_LV5:
                    unit = ObjectPool.instance.GetBlueUnit(Unit.blueUnit_LV5);
                    break;
                case Unit.blueUnit_LV6:
                    unit = ObjectPool.instance.GetBlueUnit(Unit.blueUnit_LV6);
                    break;
                case Unit.greenUnit_LV1:
                    unit = ObjectPool.instance.GetGreenUnit(Unit.greenUnit_LV1);
                    break;
                case Unit.greenUnit_LV2:
                    unit = ObjectPool.instance.GetGreenUnit(Unit.greenUnit_LV2);
                    break;
                case Unit.greenUnit_LV3:
                    unit = ObjectPool.instance.GetGreenUnit(Unit.greenUnit_LV3);
                    break;
                case Unit.greenUnit_LV4:
                    unit = ObjectPool.instance.GetGreenUnit(Unit.greenUnit_LV4);
                    break;
                case Unit.greenUnit_LV5:
                    unit = ObjectPool.instance.GetGreenUnit(Unit.greenUnit_LV5);
                    break;
                case Unit.greenUnit_LV6:
                    unit = ObjectPool.instance.GetGreenUnit(Unit.greenUnit_LV6);
                    break;
                case Unit.orangeUnit_LV1:
                    unit = ObjectPool.instance.GetOrangeUnit(Unit.orangeUnit_LV1);
                    break;
                case Unit.orangeUnit_LV2:
                    unit = ObjectPool.instance.GetOrangeUnit(Unit.orangeUnit_LV2);
                    break;
                case Unit.orangeUnit_LV3:
                    unit = ObjectPool.instance.GetOrangeUnit(Unit.orangeUnit_LV3);
                    break;
                case Unit.orangeUnit_LV4:
                    unit = ObjectPool.instance.GetOrangeUnit(Unit.orangeUnit_LV4);
                    break;
                case Unit.orangeUnit_LV5:
                    unit = ObjectPool.instance.GetOrangeUnit(Unit.orangeUnit_LV5);
                    break;
                case Unit.orangeUnit_LV6:
                    unit = ObjectPool.instance.GetOrangeUnit(Unit.orangeUnit_LV6);
                    break;
                case Unit.grayUnit_LV1:
                    unit = ObjectPool.instance.GetGrayUnit(Unit.grayUnit_LV1);
                    break;
                case Unit.grayUnit_LV2:
                    unit = ObjectPool.instance.GetGrayUnit(Unit.grayUnit_LV2);
                    break;
                case Unit.grayUnit_LV3:
                    unit = ObjectPool.instance.GetGrayUnit(Unit.grayUnit_LV3);
                    break;
                case Unit.grayUnit_LV4:
                    unit = ObjectPool.instance.GetGrayUnit(Unit.grayUnit_LV4);
                    break;
                case Unit.grayUnit_LV5:
                    unit = ObjectPool.instance.GetGrayUnit(Unit.grayUnit_LV5);
                    break;
                case Unit.grayUnit_LV6:
                    unit = ObjectPool.instance.GetGrayUnit(Unit.grayUnit_LV6);
                    break;
                case Unit.redUnit_LV1:
                    unit = ObjectPool.instance.GetRedUnit(Unit.redUnit_LV1);
                    break;
                case Unit.redUnit_LV2:
                    unit = ObjectPool.instance.GetRedUnit(Unit.redUnit_LV2);
                    break;
                case Unit.redUnit_LV3:
                    unit = ObjectPool.instance.GetRedUnit(Unit.redUnit_LV3);
                    break;
                case Unit.redUnit_LV4:
                    unit = ObjectPool.instance.GetRedUnit(Unit.redUnit_LV4);
                    break;
                case Unit.redUnit_LV5:
                    unit = ObjectPool.instance.GetRedUnit(Unit.redUnit_LV5);
                    break;
                case Unit.redUnit_LV6:
                    unit = ObjectPool.instance.GetRedUnit(Unit.redUnit_LV6);
                    break;
                default:
                    break;
            }

            // 가져온 유닛오브젝트를 활성화
            if (unit != null)
            {
                unit.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-1.0f, 1.0f), 0);
                unit.transform.rotation = gameObject.transform.rotation;
                unit.SetActive(true);
                PlayerManager.instance.onActiveUnits.Add(unit);

                UpgradeUnit("Blue", Unit.blueUnit_LV1);
                UpgradeUnit("Blue", Unit.blueUnit_LV2);
                UpgradeUnit("Blue", Unit.blueUnit_LV3);
                UpgradeUnit("Blue", Unit.blueUnit_LV4);
                UpgradeUnit("Blue", Unit.blueUnit_LV5);

                UpgradeUnit("Green", Unit.greenUnit_LV1);
                UpgradeUnit("Green", Unit.greenUnit_LV2);
                UpgradeUnit("Green", Unit.greenUnit_LV3);
                UpgradeUnit("Green", Unit.greenUnit_LV4);
                UpgradeUnit("Green", Unit.greenUnit_LV5);

                UpgradeUnit("Orange", Unit.orangeUnit_LV1);
                UpgradeUnit("Orange", Unit.orangeUnit_LV2);
                UpgradeUnit("Orange", Unit.orangeUnit_LV3);
                UpgradeUnit("Orange", Unit.orangeUnit_LV4);
                UpgradeUnit("Orange", Unit.orangeUnit_LV5);

                UpgradeUnit("Gray", Unit.grayUnit_LV1);
                UpgradeUnit("Gray", Unit.grayUnit_LV2);
                UpgradeUnit("Gray", Unit.grayUnit_LV3);
                UpgradeUnit("Gray", Unit.grayUnit_LV4);
                UpgradeUnit("Gray", Unit.grayUnit_LV5);

                UpgradeUnit("Red", Unit.redUnit_LV1);
                UpgradeUnit("Red", Unit.redUnit_LV2);
                UpgradeUnit("Red", Unit.redUnit_LV3);
                UpgradeUnit("Red", Unit.redUnit_LV4);
                UpgradeUnit("Red", Unit.redUnit_LV5);
            }

            yield break;
        }
    }
}

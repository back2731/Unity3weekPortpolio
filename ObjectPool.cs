using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Bolt
{
    blue,
    green,
    purple,
    red,
    white,
    yellow
}

public enum Unit
{
    blueUnit_LV1,
    blueUnit_LV2,
    blueUnit_LV3,
    blueUnit_LV4,
    blueUnit_LV5,
    blueUnit_LV6,

    greenUnit_LV1,
    greenUnit_LV2,
    greenUnit_LV3,
    greenUnit_LV4,
    greenUnit_LV5,
    greenUnit_LV6,

    orangeUnit_LV1,
    orangeUnit_LV2,
    orangeUnit_LV3,
    orangeUnit_LV4,
    orangeUnit_LV5,
    orangeUnit_LV6,

    grayUnit_LV1,
    grayUnit_LV2,
    grayUnit_LV3,
    grayUnit_LV4,
    grayUnit_LV5,
    grayUnit_LV6,

    redUnit_LV1,
    redUnit_LV2,
    redUnit_LV3,
    redUnit_LV4,
    redUnit_LV5,
    redUnit_LV6
}

public enum EnemyUnit
{
    LV1,
    LV2,
    LV3,
    LV4,
    LV5,
    LV6,
    LV7,
    LV8,
    LV9
}

public class ObjectPool : Singleton<ObjectPool>
{
    private int maxBulletPool = 200;
    private int maxUnitPool = 10;

    // 돈 프리팹
    public GameObject[] moneyPrefabs;

    // 사망 이펙트 프리팹
    public GameObject[] deadEffectPrefabs;

    // 플레이어 유닛 프리팹
    public GameObject[] unitPrefabs;

    // 에너미 유닛 프리팹
    public GameObject[] enemyPrefabs;

    // 레이저 볼트 프리팹
    public GameObject[] laserBoltsPrefab;
    
    // 레이저 볼트 이펙트 프리팹
    public GameObject[] laserBoltsEffectPrefab;

    // 유도탄 프리팹
    public GameObject[] hommingBulletPrefab;

    // 유도탄 이펙트프리팹
    public GameObject[] hommingBulletEffectPrefab;

    // 쇼크웨이브 불릿 프리팹
    public GameObject shockwaveBulletPrefab;

    // 돈 오브젝트 풀
    public List<GameObject> moneyPool = new List<GameObject>();

    // 사망 이펙트 풀
    public List<GameObject> blueDeadEffectPool = new List<GameObject>();
    public List<GameObject> greenDeadEffectPool = new List<GameObject>();
    public List<GameObject> purpleDeadEffectPool = new List<GameObject>();
    public List<GameObject> redDeadEffectPool = new List<GameObject>();
    public List<GameObject> grayDeadEffectPool = new List<GameObject>();
    public List<GameObject> orangeDeadEffectPool = new List<GameObject>();

    // 플레이어 유닛 풀
    public List<GameObject> blueUnitPool = new List<GameObject>();
    public List<GameObject> greenUnitPool = new List<GameObject>();
    public List<GameObject> orangeUnitPool = new List<GameObject>();
    public List<GameObject> grayUnitPool = new List<GameObject>();
    public List<GameObject> redUnitPool = new List<GameObject>();

    // 에너미 유닛 풀
    public List<GameObject> enemyLV1Pool = new List<GameObject>();
    public List<GameObject> enemyLV2Pool = new List<GameObject>();
    public List<GameObject> enemyLV3Pool = new List<GameObject>();
    public List<GameObject> enemyLV4Pool = new List<GameObject>();
    public List<GameObject> enemyLV5Pool = new List<GameObject>();
    public List<GameObject> enemyLV6Pool = new List<GameObject>();
    public List<GameObject> enemyLV7Pool = new List<GameObject>();
    public List<GameObject> enemyLV8Pool = new List<GameObject>();
    public List<GameObject> enemyLV9Pool = new List<GameObject>();

    // 레이저 볼트 풀
    public List<GameObject> blueLaserBoltPool = new List<GameObject>();
    public List<GameObject> greenLaserBoltPool = new List<GameObject>();
    public List<GameObject> purpleLaserBoltPool = new List<GameObject>();
    public List<GameObject> redLaserBoltPool = new List<GameObject>();
    public List<GameObject> whiteLaserBoltPool = new List<GameObject>();
    public List<GameObject> yellowLaserBoltPool = new List<GameObject>();

    // 레이저 볼트 풀
    public List<GameObject> blueLaserBoltEffectPool = new List<GameObject>();
    public List<GameObject> greenLaserBoltEffectPool = new List<GameObject>();
    public List<GameObject> purpleLaserBoltEffectPool = new List<GameObject>();
    public List<GameObject> redLaserBoltEffectPool = new List<GameObject>();
    public List<GameObject> whiteLaserBoltEffectPool = new List<GameObject>();
    public List<GameObject> yellowLaserBoltEffectPool = new List<GameObject>();

    // 유도탄 풀
    public List<GameObject> blueHommingBulletPool = new List<GameObject>();

    // 유도탄 풀
    public List<GameObject> blueHommingBulletEffectPool = new List<GameObject>();

    // 쇼크웨이브 불릿 풀
    public List<GameObject> shockwaveBulletPool = new List<GameObject>();

    protected override void Awake()
    {
        //base.Awake();
        CreateUnitPool();
        CreateBulletPool();
        CreateMoneyPool();
        CreateEffectPool();
    }

    // 돈 Get 함수
    public GameObject GetMoneyObject()
    {
        for (int i = 0; i < moneyPool.Count; i++)
        {
            if (moneyPool[i].activeSelf == false)
            {
                return moneyPool[i];
            }
        }
        return null;
    }

    // 사망 이펙트 Get함수
    public GameObject GetBlueDeadEffect()
    {
        for (int i = 0; i < blueDeadEffectPool.Count; i++)
        {
            if (blueDeadEffectPool[i].activeSelf == false)
            {
                return blueDeadEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetGreenDeadEffect()
    {
        for (int i = 0; i < greenDeadEffectPool.Count; i++)
        {
            if (greenDeadEffectPool[i].activeSelf == false)
            {
                return greenDeadEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetPurpleDeadEffect()
    {
        for (int i = 0; i < purpleDeadEffectPool.Count; i++)
        {
            if (purpleDeadEffectPool[i].activeSelf == false)
            {
                return purpleDeadEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetRedDeadEffect()
    {
        for (int i = 0; i < redDeadEffectPool.Count; i++)
        {
            if (redDeadEffectPool[i].activeSelf == false)
            {
                return redDeadEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetGrayDeadEffect()
    {
        for (int i = 0; i < grayDeadEffectPool.Count; i++)
        {
            if (grayDeadEffectPool[i].activeSelf == false)
            {
                return grayDeadEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetOrangeDeadEffect()
    {
        for (int i = 0; i < orangeDeadEffectPool.Count; i++)
        {
            if (orangeDeadEffectPool[i].activeSelf == false)
            {
                return orangeDeadEffectPool[i];
            }
        }
        return null;
    }

    // 플레이어 유닛 Get함수
    public GameObject GetBlueUnit(Unit Unit)
    {
        for (int i = 0; i < blueUnitPool.Count; i++)
        {
            if (blueUnitPool[i].activeSelf == false)
            {
                switch(Unit)
                {
                    case Unit.blueUnit_LV1:
                    {
                        if (blueUnitPool[i].CompareTag("BlueUnit_LV1"))
                        {
                            return blueUnitPool[i];
                        }
                    }
                        break;
                    case Unit.blueUnit_LV2:
                    {
                        if (blueUnitPool[i].CompareTag("BlueUnit_LV2"))
                        {
                            return blueUnitPool[i];
                        }
                    }
                        break;
                    case Unit.blueUnit_LV3:
                        {
                            if (blueUnitPool[i].CompareTag("BlueUnit_LV3"))
                            {
                                return blueUnitPool[i];
                            }
                        }
                        break;
                    case Unit.blueUnit_LV4:
                    {
                        if (blueUnitPool[i].CompareTag("BlueUnit_LV4"))
                        {
                            return blueUnitPool[i];
                        }
                    }
                        break;
                    case Unit.blueUnit_LV5:
                    {
                        if (blueUnitPool[i].CompareTag("BlueUnit_LV5"))
                        {
                            return blueUnitPool[i];
                        }
                    }
                        break;
                    case Unit.blueUnit_LV6:
                    {
                        if (blueUnitPool[i].CompareTag("BlueUnit_LV6"))
                        {
                            return blueUnitPool[i];
                        }
                    }
                        break;
                }
            }
        }
        return null;
    }
    public GameObject GetGreenUnit(Unit Unit)
    {
        for (int i = 0; i < greenUnitPool.Count; i++)
        {
            if (greenUnitPool[i].activeSelf == false)
            {
                switch (Unit)
                {
                    case Unit.greenUnit_LV1:
                        {
                            if (greenUnitPool[i].CompareTag("GreenUnit_LV1"))
                            {
                                return greenUnitPool[i];
                            }
                        }
                        break;
                    case Unit.greenUnit_LV2:
                        {
                            if (greenUnitPool[i].CompareTag("GreenUnit_LV2"))
                            {
                                return greenUnitPool[i];
                            }
                        }
                        break;
                    case Unit.greenUnit_LV3:
                        {
                            if (greenUnitPool[i].CompareTag("GreenUnit_LV3"))
                            {
                                return greenUnitPool[i];
                            }
                        }
                        break;
                    case Unit.greenUnit_LV4:
                        {
                            if (greenUnitPool[i].CompareTag("GreenUnit_LV4"))
                            {
                                return greenUnitPool[i];
                            }
                        }
                        break;
                    case Unit.greenUnit_LV5:
                        {
                            if (greenUnitPool[i].CompareTag("GreenUnit_LV5"))
                            {
                                return greenUnitPool[i];
                            }
                        }
                        break;
                    case Unit.greenUnit_LV6:
                        {
                            if (greenUnitPool[i].CompareTag("GreenUnit_LV6"))
                            {
                                return greenUnitPool[i];
                            }
                        }
                        break;
                }
            }
        }
        return null;
    }
    public GameObject GetOrangeUnit(Unit Unit)
    {
        for (int i = 0; i < orangeUnitPool.Count; i++)
        {
            if (orangeUnitPool[i].activeSelf == false)
            {
                switch (Unit)
                {
                    case Unit.orangeUnit_LV1:
                        {
                            if (orangeUnitPool[i].CompareTag("OrangeUnit_LV1"))
                            {
                                return orangeUnitPool[i];
                            }
                        }
                        break;
                    case Unit.orangeUnit_LV2:
                        {
                            if (orangeUnitPool[i].CompareTag("OrangeUnit_LV2"))
                            {
                                return orangeUnitPool[i];
                            }
                        }
                        break;
                    case Unit.orangeUnit_LV3:
                        {
                            if (orangeUnitPool[i].CompareTag("OrangeUnit_LV3"))
                            {
                                return orangeUnitPool[i];
                            }
                        }
                        break;
                    case Unit.orangeUnit_LV4:
                        {
                            if (orangeUnitPool[i].CompareTag("OrangeUnit_LV4"))
                            {
                                return orangeUnitPool[i];
                            }
                        }
                        break;
                    case Unit.orangeUnit_LV5:
                        {
                            if (orangeUnitPool[i].CompareTag("OrangeUnit_LV5"))
                            {
                                return orangeUnitPool[i];
                            }
                        }
                        break;
                    case Unit.orangeUnit_LV6:
                        {
                            if (orangeUnitPool[i].CompareTag("OrangeUnit_LV6"))
                            {
                                return orangeUnitPool[i];
                            }
                        }
                        break;
                }
            }
        }
        return null;
    }
    public GameObject GetGrayUnit(Unit Unit)
    {
        for (int i = 0; i < grayUnitPool.Count; i++)
        {
            if (grayUnitPool[i].activeSelf == false)
            {
                switch (Unit)
                {
                    case Unit.grayUnit_LV1:
                        {
                            if (grayUnitPool[i].CompareTag("GrayUnit_LV1"))
                            {
                                return grayUnitPool[i];
                            }
                        }
                        break;
                    case Unit.grayUnit_LV2:
                        {
                            if (grayUnitPool[i].CompareTag("GrayUnit_LV2"))
                            {
                                return grayUnitPool[i];
                            }
                        }
                        break;
                    case Unit.grayUnit_LV3:
                        {
                            if (grayUnitPool[i].CompareTag("GrayUnit_LV3"))
                            {
                                return grayUnitPool[i];
                            }
                        }
                        break;
                    case Unit.grayUnit_LV4:
                        {
                            if (grayUnitPool[i].CompareTag("GrayUnit_LV4"))
                            {
                                return grayUnitPool[i];
                            }
                        }
                        break;
                    case Unit.grayUnit_LV5:
                        {
                            if (grayUnitPool[i].CompareTag("GrayUnit_LV5"))
                            {
                                return grayUnitPool[i];
                            }
                        }
                        break;
                    case Unit.grayUnit_LV6:
                        {
                            if (grayUnitPool[i].CompareTag("GrayUnit_LV6"))
                            {
                                return grayUnitPool[i];
                            }
                        }
                        break;
                }
            }
        }
        return null;
    }
    public GameObject GetRedUnit(Unit Unit)
    {
        for (int i = 0; i < redUnitPool.Count; i++)
        {
            if (redUnitPool[i].activeSelf == false)
            {
                switch (Unit)
                {
                    case Unit.redUnit_LV1:
                        {
                            if (redUnitPool[i].CompareTag("RedUnit_LV1"))
                            {
                                return redUnitPool[i];
                            }
                        }
                        break;
                    case Unit.redUnit_LV2:
                        {
                            if (redUnitPool[i].CompareTag("RedUnit_LV2"))
                            {
                                return redUnitPool[i];
                            }
                        }
                        break;
                    case Unit.redUnit_LV3:
                        {
                            if (redUnitPool[i].CompareTag("RedUnit_LV3"))
                            {
                                return redUnitPool[i];
                            }
                        }
                        break;
                    case Unit.redUnit_LV4:
                        {
                            if (redUnitPool[i].CompareTag("RedUnit_LV4"))
                            {
                                return redUnitPool[i];
                            }
                        }
                        break;
                    case Unit.redUnit_LV5:
                        {
                            if (redUnitPool[i].CompareTag("RedUnit_LV5"))
                            {
                                return redUnitPool[i];
                            }
                        }
                        break;
                    case Unit.redUnit_LV6:
                        {
                            if (redUnitPool[i].CompareTag("RedUnit_LV6"))
                            {
                                return redUnitPool[i];
                            }
                        }
                        break;
                }
            }
        }
        return null;
    }

    // 적 유닛 Get함수
    public GameObject GetEnemyLV1()
    {
        for (int i = 0; i < enemyLV1Pool.Count; i++)
        {
            if (enemyLV1Pool[i].activeSelf == false)
            {
                return enemyLV1Pool[i];
            }
        }
        return null;
    }
    public GameObject GetEnemyLV2()
    {
        for (int i = 0; i < enemyLV2Pool.Count; i++)
        {
            if (enemyLV2Pool[i].activeSelf == false)
            {
                return enemyLV2Pool[i];
            }
        }
        return null;
    }
    public GameObject GetEnemyLV3()
    {
        for (int i = 0; i < enemyLV3Pool.Count; i++)
        {
            if (enemyLV3Pool[i].activeSelf == false)
            {
                return enemyLV3Pool[i];
            }
        }
        return null;
    }
    public GameObject GetEnemyLV4()
    {
        for (int i = 0; i < enemyLV4Pool.Count; i++)
        {
            if (enemyLV4Pool[i].activeSelf == false)
            {
                return enemyLV4Pool[i];
            }
        }
        return null;
    }
    public GameObject GetEnemyLV5()
    {
        for (int i = 0; i < enemyLV5Pool.Count; i++)
        {
            if (enemyLV5Pool[i].activeSelf == false)
            {
                return enemyLV5Pool[i];
            }
        }
        return null;
    }
    public GameObject GetEnemyLV6()
    {
        for (int i = 0; i < enemyLV6Pool.Count; i++)
        {
            if (enemyLV6Pool[i].activeSelf == false)
            {
                return enemyLV6Pool[i];
            }
        }
        return null;
    }
    public GameObject GetEnemyLV7()
    {
        for (int i = 0; i < enemyLV7Pool.Count; i++)
        {
            if (enemyLV7Pool[i].activeSelf == false)
            {
                return enemyLV7Pool[i];
            }
        }
        return null;
    }
    public GameObject GetEnemyLV8()
    {
        for (int i = 0; i < enemyLV8Pool.Count; i++)
        {
            if (enemyLV8Pool[i].activeSelf == false)
            {
                return enemyLV8Pool[i];
            }
        }
        return null;
    }
    public GameObject GetEnemyLV9()
    {
        for (int i = 0; i < enemyLV9Pool.Count; i++)
        {
            if (enemyLV9Pool[i].activeSelf == false)
            {
                return enemyLV9Pool[i];
            }
        }
        return null;
    }

    // 레이저 볼트 Get함수
    public GameObject GetBlueLaserBolt()
    {
        for (int i = 0; i < blueLaserBoltPool.Count; i++)
        {
            if (blueLaserBoltPool[i].activeSelf == false)
            {
                return blueLaserBoltPool[i];
            }
        }
        return null;
    }
    public GameObject GetGreenLaserBolt()
    {
        for (int i = 0; i < greenLaserBoltPool.Count; i++)
        {
            if (greenLaserBoltPool[i].activeSelf == false)
            {
                return greenLaserBoltPool[i];
            }
        }
        return null;
    }
    public GameObject GetPurpleLaserBolt()
    {
        for (int i = 0; i < purpleLaserBoltPool.Count; i++)
        {
            if (purpleLaserBoltPool[i].activeSelf == false)
            {
                return purpleLaserBoltPool[i];
            }
        }
        return null;
    }
    public GameObject GetRedLaserBolt()
    {
        for (int i = 0; i < redLaserBoltPool.Count; i++)
        {
            if (redLaserBoltPool[i].activeSelf == false)
            {
                return redLaserBoltPool[i];
            }
        }
        return null;
    }
    public GameObject GetWhiteLaserBolt()
    {
        for (int i = 0; i < whiteLaserBoltPool.Count; i++)
        {
            if (whiteLaserBoltPool[i].activeSelf == false)
            {
                return whiteLaserBoltPool[i];
            }
        }
        return null;
    }
    public GameObject GetYellowLaserBolt()
    {
        for (int i = 0; i < yellowLaserBoltPool.Count; i++)
        {
            if (yellowLaserBoltPool[i].activeSelf == false)
            {
                return yellowLaserBoltPool[i];
            }
        }
        return null;
    }

    // 레이저 볼트 이펙트 Get함수
    public GameObject GetBlueLaserBoltEffect()
    {
        for (int i = 0; i < blueLaserBoltEffectPool.Count; i++)
        {
            if (blueLaserBoltEffectPool[i].activeSelf == false)
            {
                return blueLaserBoltEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetGreenLaserBoltEffect()
    {
        for (int i = 0; i < greenLaserBoltEffectPool.Count; i++)
        {
            if (greenLaserBoltEffectPool[i].activeSelf == false)
            {
                return greenLaserBoltEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetPurpleLaserBoltEffect()
    {
        for (int i = 0; i < purpleLaserBoltEffectPool.Count; i++)
        {
            if (purpleLaserBoltEffectPool[i].activeSelf == false)
            {
                return purpleLaserBoltEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetRedLaserBoltEffect()
    {
        for (int i = 0; i < redLaserBoltEffectPool.Count; i++)
        {
            if (redLaserBoltEffectPool[i].activeSelf == false)
            {
                return redLaserBoltEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetWhiteLaserBoltEffect()
    {
        for (int i = 0; i < whiteLaserBoltEffectPool.Count; i++)
        {
            if (whiteLaserBoltEffectPool[i].activeSelf == false)
            {
                return whiteLaserBoltEffectPool[i];
            }
        }
        return null;
    }
    public GameObject GetYellowLaserBoltEffect()
    {
        for (int i = 0; i < yellowLaserBoltEffectPool.Count; i++)
        {
            if (yellowLaserBoltEffectPool[i].activeSelf == false)
            {
                return yellowLaserBoltEffectPool[i];
            }
        }
        return null;
    }

    // 유도탄 Get함수
    public GameObject GetBlueHommingBullet()
    {
        for (int i = 0; i < blueHommingBulletPool.Count; i++)
        {
            if (blueHommingBulletPool[i].activeSelf == false)
            {
                return blueHommingBulletPool[i];
            }
        }
        return null;
    }

    // 유도탄 이펙트 Get함수
    public GameObject GetBlueHommingBulletEffect()
    {
        for (int i = 0; i < blueHommingBulletEffectPool.Count; i++)
        {
            if (blueHommingBulletEffectPool[i].activeSelf == false)
            {
                return blueHommingBulletEffectPool[i];
            }
        }
        return null;
    }

    // 쇼크웨이브 불릿 Get함수
    public GameObject GetShockwaveBullet()
    {
        for (int i = 0; i < shockwaveBulletPool.Count; i++)
        {
            if (shockwaveBulletPool[i].activeSelf == false)
            {
                return shockwaveBulletPool[i];
            }
        }
        return null;
    }

    public void CreateBulletPool()
    {
        GameObject bulletPool = new GameObject("BulletPool");
        GameObject bulletEffectPool = new GameObject("BulletEffectPool");

        GameObject laserBolts = new GameObject("LaserBolts");
        GameObject blueLaserBolts = new GameObject("BlueLaserBolt");
        GameObject greenLaserBolts = new GameObject("GreenLaserBolt");
        GameObject purpleLaserBolts = new GameObject("PurpleLaserBolt");
        GameObject redLaserBolts = new GameObject("RedLaserBolt");
        GameObject whiteLaserBolts = new GameObject("WhiteLaserBolts");
        GameObject yellowLaserBolts = new GameObject("YellowLaserBolts");

        GameObject laserBoltsEffect = new GameObject("LaserBoltsEffect");
        GameObject blueLaserBoltsEffect = new GameObject("BlueLaserBoltEffect");
        GameObject greenLaserBoltsEffect = new GameObject("GreenLaserBoltEffect");
        GameObject purpleLaserBoltsEffect = new GameObject("PurpleLaserBoltEffect");
        GameObject redLaserBoltsEffect = new GameObject("RedLaserBoltEffect");
        GameObject whiteLaserBoltsEffect = new GameObject("WhiteLaserBoltsEffect");
        GameObject yellowLaserBoltsEffect = new GameObject("YellowLaserBoltsEffect");

        GameObject hommingBullets = new GameObject("HommingBullets");
        GameObject blueHommingBullets = new GameObject("BlueHommingBullet");
        GameObject blueHommingBulletsEffect = new GameObject("BlueHommingBulletEffect");

        GameObject shockwaveBullets = new GameObject("ShockwaveBullets");

        laserBolts.transform.parent = bulletPool.transform;
        blueLaserBolts.transform.parent = laserBolts.transform;
        greenLaserBolts.transform.parent = laserBolts.transform;
        purpleLaserBolts.transform.parent = laserBolts.transform;
        redLaserBolts.transform.parent = laserBolts.transform;
        whiteLaserBolts.transform.parent = laserBolts.transform;
        yellowLaserBolts.transform.parent = laserBolts.transform;

        laserBoltsEffect.transform.parent = bulletEffectPool.transform;
        blueLaserBoltsEffect.transform.parent = laserBoltsEffect.transform;
        greenLaserBoltsEffect.transform.parent = laserBoltsEffect.transform;
        purpleLaserBoltsEffect.transform.parent = laserBoltsEffect.transform;
        redLaserBoltsEffect.transform.parent = laserBoltsEffect.transform;
        whiteLaserBoltsEffect.transform.parent = laserBoltsEffect.transform;
        yellowLaserBoltsEffect.transform.parent = laserBoltsEffect.transform;

        blueLaserBolts.gameObject.tag = "BlueLaserBolt";
        greenLaserBolts.gameObject.tag = "GreenLaserBolt";
        purpleLaserBolts.gameObject.tag = "PurpleLaserBolt";
        redLaserBolts.gameObject.tag = "RedLaserBolt";
        whiteLaserBolts.gameObject.tag = "WhiteLaserBolt";
        yellowLaserBolts.gameObject.tag = "YellowLaserBolt";

        hommingBullets.transform.parent = bulletPool.transform;
        blueHommingBullets.transform.parent = hommingBullets.transform;
        blueHommingBulletsEffect.transform.parent = bulletEffectPool.transform;

        blueHommingBullets.gameObject.tag = "BlueHommingBullet";

        shockwaveBullets.gameObject.tag = "ShockwaveBullets";

        shockwaveBullets.transform.parent = bulletPool.transform;

        for (int i = 0; i < maxBulletPool; i++)
        {
            var blueLaserBoltPrefabs = Instantiate<GameObject>(laserBoltsPrefab[(int)Bolt.blue], blueLaserBolts.transform);
            blueLaserBoltPrefabs.name = "BlueLaserBolt_" + i.ToString("00");
            blueLaserBoltPrefabs.SetActive(false);
            blueLaserBoltPool.Add(blueLaserBoltPrefabs);

            var greenLaserBoltPrefabs = Instantiate<GameObject>(laserBoltsPrefab[(int)Bolt.green], greenLaserBolts.transform);
            greenLaserBoltPrefabs.name = "GreenLaserBolt_" + i.ToString("00");
            greenLaserBoltPrefabs.SetActive(false);
            greenLaserBoltPool.Add(greenLaserBoltPrefabs);

            var purpleLaserBoltPrefabs = Instantiate<GameObject>(laserBoltsPrefab[(int)Bolt.purple], purpleLaserBolts.transform);
            purpleLaserBoltPrefabs.name = "PurpleLaserBolt_" + i.ToString("00");
            purpleLaserBoltPrefabs.SetActive(false);
            purpleLaserBoltPool.Add(purpleLaserBoltPrefabs);

            var redLaserBoltPrefabs = Instantiate<GameObject>(laserBoltsPrefab[(int)Bolt.red], redLaserBolts.transform);
            redLaserBoltPrefabs.name = "RedLaserBolt_" + i.ToString("00");
            redLaserBoltPrefabs.SetActive(false);
            redLaserBoltPool.Add(redLaserBoltPrefabs);

            var whiteLaserBoltPrefabs = Instantiate<GameObject>(laserBoltsPrefab[(int)Bolt.white], whiteLaserBolts.transform);
            whiteLaserBoltPrefabs.name = "WhiteLaserBolt_" + i.ToString("00");
            whiteLaserBoltPrefabs.SetActive(false);
            whiteLaserBoltPool.Add(whiteLaserBoltPrefabs);

            var yellowLaserBoltPrefabs = Instantiate<GameObject>(laserBoltsPrefab[(int)Bolt.yellow], yellowLaserBolts.transform);
            yellowLaserBoltPrefabs.name = "YellowLaserBolt_" + i.ToString("00");
            yellowLaserBoltPrefabs.SetActive(false);
            yellowLaserBoltPool.Add(yellowLaserBoltPrefabs);

            var blueHommingBulletPrefabs = Instantiate<GameObject>(hommingBulletPrefab[(int)Bolt.blue], blueHommingBullets.transform);
            blueHommingBulletPrefabs.name = "blueHommingBullet" + i.ToString("00");
            blueHommingBulletPrefabs.SetActive(false);
            blueHommingBulletPool.Add(blueHommingBulletPrefabs);

            var shockwaveBullet = Instantiate<GameObject>(shockwaveBulletPrefab, shockwaveBullets.transform);
            shockwaveBullet.name = "ShockwaveBullet_" + i.ToString("00");
            shockwaveBullet.SetActive(false);
            shockwaveBulletPool.Add(shockwaveBullet);

            var blueLaserBoltEffectPrefabs = Instantiate<GameObject>(laserBoltsEffectPrefab[(int)Bolt.blue], blueLaserBoltsEffect.transform);
            blueLaserBoltEffectPrefabs.name = "BlueLaserBoltEffect_" + i.ToString("00");
            blueLaserBoltEffectPrefabs.SetActive(false);
            blueLaserBoltEffectPool.Add(blueLaserBoltEffectPrefabs);

            var greenLaserBoltEffectPrefabs = Instantiate<GameObject>(laserBoltsEffectPrefab[(int)Bolt.green], greenLaserBoltsEffect.transform);
            greenLaserBoltEffectPrefabs.name = "GreenLaserBoltEffect_" + i.ToString("00");
            greenLaserBoltEffectPrefabs.SetActive(false);
            greenLaserBoltEffectPool.Add(greenLaserBoltEffectPrefabs);

            var purpleLaserBoltEffectPrefabs = Instantiate<GameObject>(laserBoltsEffectPrefab[(int)Bolt.purple], purpleLaserBoltsEffect.transform);
            purpleLaserBoltEffectPrefabs.name = "PurpleLaserBoltEffect_" + i.ToString("00");
            purpleLaserBoltEffectPrefabs.SetActive(false);
            purpleLaserBoltEffectPool.Add(purpleLaserBoltEffectPrefabs);

            var redLaserBoltEffectPrefabs = Instantiate<GameObject>(laserBoltsEffectPrefab[(int)Bolt.red], redLaserBoltsEffect.transform);
            redLaserBoltEffectPrefabs.name = "RedLaserBoltEffect_" + i.ToString("00");
            redLaserBoltEffectPrefabs.SetActive(false);
            redLaserBoltEffectPool.Add(redLaserBoltEffectPrefabs);

            var whiteLaserBoltEffectPrefabs = Instantiate<GameObject>(laserBoltsEffectPrefab[(int)Bolt.white], whiteLaserBoltsEffect.transform);
            whiteLaserBoltEffectPrefabs.name = "WhiteLaserBoltEffect_" + i.ToString("00");
            whiteLaserBoltEffectPrefabs.SetActive(false);
            whiteLaserBoltEffectPool.Add(whiteLaserBoltEffectPrefabs);

            var yellowLaserBoltEffectPrefabs = Instantiate<GameObject>(laserBoltsEffectPrefab[(int)Bolt.yellow], yellowLaserBoltsEffect.transform);
            yellowLaserBoltEffectPrefabs.name = "YellowLaserBoltEffect_" + i.ToString("00");
            yellowLaserBoltEffectPrefabs.SetActive(false);
            yellowLaserBoltEffectPool.Add(yellowLaserBoltEffectPrefabs);

            var blueHommingBulletEffectPrefabs = Instantiate<GameObject>(hommingBulletEffectPrefab[(int)Bolt.blue], blueHommingBulletsEffect.transform);
            blueHommingBulletEffectPrefabs.name = "blueHommingBulletEffect" + i.ToString("00");
            blueHommingBulletEffectPrefabs.SetActive(false);
            blueHommingBulletEffectPool.Add(blueHommingBulletEffectPrefabs);

        }
    }

    public void CreateUnitPool()
    {
        GameObject unitPool = new GameObject("UnitPool");
        GameObject playerUnitPool = new GameObject("PlayerUnitPool");
        GameObject enemyUnitPool = new GameObject("EnemyUnitPool");

        GameObject blueUnit = new GameObject("BlueUnit");
        GameObject greenUnit = new GameObject("GreenUnit");
        GameObject orangeUnit = new GameObject("OrangeUnit");
        GameObject grayUnit = new GameObject("GrayUnit");
        GameObject redUnit = new GameObject("RedUnit");

        GameObject blueUnit_LV1 = new GameObject("BlueUnit_LV1");
        GameObject blueUnit_LV2 = new GameObject("BlueUnit_LV2");
        GameObject blueUnit_LV3 = new GameObject("BlueUnit_LV3");
        GameObject blueUnit_LV4 = new GameObject("BlueUnit_LV4");
        GameObject blueUnit_LV5 = new GameObject("BlueUnit_LV5");
        GameObject blueUnit_LV6 = new GameObject("BlueUnit_LV6");

        GameObject greenUnit_LV1 = new GameObject("GreenUnit_LV1");
        GameObject greenUnit_LV2 = new GameObject("GreenUnit_LV2");
        GameObject greenUnit_LV3 = new GameObject("GreenUnit_LV3");
        GameObject greenUnit_LV4 = new GameObject("GreenUnit_LV4");
        GameObject greenUnit_LV5 = new GameObject("GreenUnit_LV5");
        GameObject greenUnit_LV6 = new GameObject("GreenUnit_LV6");

        GameObject orangeUnit_LV1 = new GameObject("OrangeUnit_LV1");
        GameObject orangeUnit_LV2 = new GameObject("OrangeUnit_LV2");
        GameObject orangeUnit_LV3 = new GameObject("OrangeUnit_LV3");
        GameObject orangeUnit_LV4 = new GameObject("OrangeUnit_LV4");
        GameObject orangeUnit_LV5 = new GameObject("OrangeUnit_LV5");
        GameObject orangeUnit_LV6 = new GameObject("OrangeUnit_LV6");

        GameObject grayUnit_LV1 = new GameObject("GrayUnit_LV1");
        GameObject grayUnit_LV2 = new GameObject("GrayUnit_LV2");
        GameObject grayUnit_LV3 = new GameObject("GrayUnit_LV3");
        GameObject grayUnit_LV4 = new GameObject("GrayUnit_LV4");
        GameObject grayUnit_LV5 = new GameObject("GrayUnit_LV5");
        GameObject grayUnit_LV6 = new GameObject("GrayUnit_LV6");

        GameObject redUnit_LV1 = new GameObject("RedUnit_LV1");
        GameObject redUnit_LV2 = new GameObject("RedUnit_LV2");
        GameObject redUnit_LV3 = new GameObject("RedUnit_LV3");
        GameObject redUnit_LV4 = new GameObject("RedUnit_LV4");
        GameObject redUnit_LV5 = new GameObject("RedUnit_LV5");
        GameObject redUnit_LV6 = new GameObject("RedUnit_LV6");

        GameObject enemy_LV1 = new GameObject("Enemy_LV1");
        GameObject enemy_LV2 = new GameObject("Enemy_LV2");
        GameObject enemy_LV3 = new GameObject("Enemy_LV3");
        GameObject enemy_LV4 = new GameObject("Enemy_LV4");
        GameObject enemy_LV5 = new GameObject("Enemy_LV5");
        GameObject enemy_LV6 = new GameObject("Enemy_LV6");
        GameObject enemy_LV7 = new GameObject("Enemy_LV7");
        GameObject enemy_LV8 = new GameObject("Enemy_LV8");
        GameObject enemy_LV9 = new GameObject("Enemy_LV9");

        playerUnitPool.transform.parent = unitPool.transform;
        enemyUnitPool.transform.parent = unitPool.transform;

        blueUnit.transform.parent = playerUnitPool.transform;
        greenUnit.transform.parent = playerUnitPool.transform;
        orangeUnit.transform.parent = playerUnitPool.transform;
        grayUnit.transform.parent = playerUnitPool.transform;
        redUnit.transform.parent = playerUnitPool.transform;
        
        blueUnit_LV1.transform.parent = blueUnit.transform;
        blueUnit_LV2.transform.parent = blueUnit.transform;
        blueUnit_LV3.transform.parent = blueUnit.transform;
        blueUnit_LV4.transform.parent = blueUnit.transform;
        blueUnit_LV5.transform.parent = blueUnit.transform;
        blueUnit_LV6.transform.parent = blueUnit.transform;

        greenUnit_LV1.transform.parent = greenUnit.transform;
        greenUnit_LV2.transform.parent = greenUnit.transform;
        greenUnit_LV3.transform.parent = greenUnit.transform;
        greenUnit_LV4.transform.parent = greenUnit.transform;
        greenUnit_LV5.transform.parent = greenUnit.transform;
        greenUnit_LV6.transform.parent = greenUnit.transform;

        orangeUnit_LV1.transform.parent = orangeUnit.transform;
        orangeUnit_LV2.transform.parent = orangeUnit.transform;
        orangeUnit_LV3.transform.parent = orangeUnit.transform;
        orangeUnit_LV4.transform.parent = orangeUnit.transform;
        orangeUnit_LV5.transform.parent = orangeUnit.transform;
        orangeUnit_LV6.transform.parent = orangeUnit.transform;

        grayUnit_LV1.transform.parent = grayUnit.transform;
        grayUnit_LV2.transform.parent = grayUnit.transform;
        grayUnit_LV3.transform.parent = grayUnit.transform;
        grayUnit_LV4.transform.parent = grayUnit.transform;
        grayUnit_LV5.transform.parent = grayUnit.transform;
        grayUnit_LV6.transform.parent = grayUnit.transform;

        redUnit_LV1.transform.parent = redUnit.transform;
        redUnit_LV2.transform.parent = redUnit.transform;
        redUnit_LV3.transform.parent = redUnit.transform;
        redUnit_LV4.transform.parent = redUnit.transform;
        redUnit_LV5.transform.parent = redUnit.transform;
        redUnit_LV6.transform.parent = redUnit.transform;

        enemy_LV1.transform.parent = enemyUnitPool.transform;
        enemy_LV2.transform.parent = enemyUnitPool.transform;
        enemy_LV3.transform.parent = enemyUnitPool.transform;
        enemy_LV4.transform.parent = enemyUnitPool.transform;
        enemy_LV5.transform.parent = enemyUnitPool.transform;
        enemy_LV6.transform.parent = enemyUnitPool.transform;
        enemy_LV7.transform.parent = enemyUnitPool.transform;
        enemy_LV8.transform.parent = enemyUnitPool.transform;
        enemy_LV9.transform.parent = enemyUnitPool.transform;

        // 플레이어 유닛
        for (int i = 0; i < maxUnitPool; i++)
        {
            // 블루유닛
            var blueUnitPrefabs_LV1 = Instantiate<GameObject>(unitPrefabs[(int)Unit.blueUnit_LV1], blueUnit_LV1.transform);
            blueUnitPrefabs_LV1.name = "BlueUnit_LV1_" + i.ToString("00");
            blueUnitPrefabs_LV1.SetActive(false);
            blueUnitPool.Add(blueUnitPrefabs_LV1);

            var blueUnitPrefabs_LV2 = Instantiate<GameObject>(unitPrefabs[(int)Unit.blueUnit_LV2], blueUnit_LV2.transform);
            blueUnitPrefabs_LV2.name = "BlueUnit_LV2_" + i.ToString("00");
            blueUnitPrefabs_LV2.SetActive(false);
            blueUnitPool.Add(blueUnitPrefabs_LV2);

            var blueUnitPrefabs_LV3 = Instantiate<GameObject>(unitPrefabs[(int)Unit.blueUnit_LV3], blueUnit_LV3.transform);
            blueUnitPrefabs_LV3.name = "BlueUnit_LV3_" + i.ToString("00");
            blueUnitPrefabs_LV3.SetActive(false);
            blueUnitPool.Add(blueUnitPrefabs_LV3);

            var blueUnitPrefabs_LV4 = Instantiate<GameObject>(unitPrefabs[(int)Unit.blueUnit_LV4], blueUnit_LV4.transform);
            blueUnitPrefabs_LV4.name = "BlueUnit_LV4_" + i.ToString("00");
            blueUnitPrefabs_LV4.SetActive(false);
            blueUnitPool.Add(blueUnitPrefabs_LV4);

            var blueUnitPrefabs_LV5 = Instantiate<GameObject>(unitPrefabs[(int)Unit.blueUnit_LV5], blueUnit_LV5.transform);
            blueUnitPrefabs_LV5.name = "BlueUnit_LV5_" + i.ToString("00");
            blueUnitPrefabs_LV5.SetActive(false);
            blueUnitPool.Add(blueUnitPrefabs_LV5);

            var blueUnitPrefabs_LV6 = Instantiate<GameObject>(unitPrefabs[(int)Unit.blueUnit_LV6], blueUnit_LV6.transform);
            blueUnitPrefabs_LV6.name = "BlueUnit_LV6_" + i.ToString("00");
            blueUnitPrefabs_LV6.SetActive(false);
            blueUnitPool.Add(blueUnitPrefabs_LV6);

            // 그린유닛
            var greenUnitPrefabs_LV1 = Instantiate<GameObject>(unitPrefabs[(int)Unit.greenUnit_LV1], greenUnit_LV1.transform);
            greenUnitPrefabs_LV1.name = "GreenUnit_LV1_" + i.ToString("00");
            greenUnitPrefabs_LV1.SetActive(false);
            greenUnitPool.Add(greenUnitPrefabs_LV1);

            var greenUnitPrefabs_LV2 = Instantiate<GameObject>(unitPrefabs[(int)Unit.greenUnit_LV2], greenUnit_LV2.transform);
            greenUnitPrefabs_LV2.name = "GreenUnit_LV2_" + i.ToString("00");
            greenUnitPrefabs_LV2.SetActive(false);
            greenUnitPool.Add(greenUnitPrefabs_LV2);

            var greenUnitPrefabs_LV3 = Instantiate<GameObject>(unitPrefabs[(int)Unit.greenUnit_LV3], greenUnit_LV3.transform);
            greenUnitPrefabs_LV3.name = "GreenUnit_LV3_" + i.ToString("00");
            greenUnitPrefabs_LV3.SetActive(false);
            greenUnitPool.Add(greenUnitPrefabs_LV3);

            var greenUnitPrefabs_LV4 = Instantiate<GameObject>(unitPrefabs[(int)Unit.greenUnit_LV4], greenUnit_LV4.transform);
            greenUnitPrefabs_LV4.name = "GreenUnit_LV4_" + i.ToString("00");
            greenUnitPrefabs_LV4.SetActive(false);
            greenUnitPool.Add(greenUnitPrefabs_LV4);

            var greenUnitPrefabs_LV5 = Instantiate<GameObject>(unitPrefabs[(int)Unit.greenUnit_LV5], greenUnit_LV5.transform);
            greenUnitPrefabs_LV5.name = "GreenUnit_LV5_" + i.ToString("00");
            greenUnitPrefabs_LV5.SetActive(false);
            greenUnitPool.Add(greenUnitPrefabs_LV5);

            var greenUnitPrefabs_LV6 = Instantiate<GameObject>(unitPrefabs[(int)Unit.greenUnit_LV6], greenUnit_LV6.transform);
            greenUnitPrefabs_LV6.name = "GreenUnit_LV6_" + i.ToString("00");
            greenUnitPrefabs_LV6.SetActive(false);
            greenUnitPool.Add(greenUnitPrefabs_LV6);

            // 오렌지 유닛
            var orangeUnitPrefabs_LV1 = Instantiate<GameObject>(unitPrefabs[(int)Unit.orangeUnit_LV1], orangeUnit_LV1.transform);
            orangeUnitPrefabs_LV1.name = "OrangeUnit_LV1_" + i.ToString("00");
            orangeUnitPrefabs_LV1.SetActive(false);
            orangeUnitPool.Add(orangeUnitPrefabs_LV1);

            var orangeUnitPrefabs_LV2 = Instantiate<GameObject>(unitPrefabs[(int)Unit.orangeUnit_LV2], orangeUnit_LV2.transform);
            orangeUnitPrefabs_LV2.name = "OrangeUnit_LV2_" + i.ToString("00");
            orangeUnitPrefabs_LV2.SetActive(false);
            orangeUnitPool.Add(orangeUnitPrefabs_LV2);

            var orangeUnitPrefabs_LV3 = Instantiate<GameObject>(unitPrefabs[(int)Unit.orangeUnit_LV3], orangeUnit_LV3.transform);
            orangeUnitPrefabs_LV3.name = "OrangeUnit_LV3_" + i.ToString("00");
            orangeUnitPrefabs_LV3.SetActive(false);
            orangeUnitPool.Add(orangeUnitPrefabs_LV3);

            var orangeUnitPrefabs_LV4 = Instantiate<GameObject>(unitPrefabs[(int)Unit.orangeUnit_LV4], orangeUnit_LV4.transform);
            orangeUnitPrefabs_LV4.name = "OrangeUnit_LV4_" + i.ToString("00");
            orangeUnitPrefabs_LV4.SetActive(false);
            orangeUnitPool.Add(orangeUnitPrefabs_LV4);

            var orangeUnitPrefabs_LV5 = Instantiate<GameObject>(unitPrefabs[(int)Unit.orangeUnit_LV5], orangeUnit_LV5.transform);
            orangeUnitPrefabs_LV5.name = "OrangeUnit_LV5_" + i.ToString("00");
            orangeUnitPrefabs_LV5.SetActive(false);
            orangeUnitPool.Add(orangeUnitPrefabs_LV5);

            var orangeUnitPrefabs_LV6 = Instantiate<GameObject>(unitPrefabs[(int)Unit.orangeUnit_LV6], orangeUnit_LV6.transform);
            orangeUnitPrefabs_LV6.name = "OrangeUnit_LV6_" + i.ToString("00");
            orangeUnitPrefabs_LV6.SetActive(false);
            orangeUnitPool.Add(orangeUnitPrefabs_LV6);

            // 그레이 유닛
            var grayUnitPrefabs_LV1 = Instantiate<GameObject>(unitPrefabs[(int)Unit.grayUnit_LV1], grayUnit_LV1.transform);
            grayUnitPrefabs_LV1.name = "GrayUnit_LV1_" + i.ToString("00");
            grayUnitPrefabs_LV1.SetActive(false);
            grayUnitPool.Add(grayUnitPrefabs_LV1);

            var grayUnitPrefabs_LV2 = Instantiate<GameObject>(unitPrefabs[(int)Unit.grayUnit_LV2], grayUnit_LV2.transform);
            grayUnitPrefabs_LV2.name = "GrayUnit_LV2_" + i.ToString("00");
            grayUnitPrefabs_LV2.SetActive(false);
            grayUnitPool.Add(grayUnitPrefabs_LV2);

            var grayUnitPrefabs_LV3 = Instantiate<GameObject>(unitPrefabs[(int)Unit.grayUnit_LV3], grayUnit_LV3.transform);
            grayUnitPrefabs_LV3.name = "GrayUnit_LV3_" + i.ToString("00");
            grayUnitPrefabs_LV3.SetActive(false);
            grayUnitPool.Add(grayUnitPrefabs_LV3);

            var grayUnitPrefabs_LV4 = Instantiate<GameObject>(unitPrefabs[(int)Unit.grayUnit_LV4], grayUnit_LV4.transform);
            grayUnitPrefabs_LV4.name = "GrayUnit_LV4_" + i.ToString("00");
            grayUnitPrefabs_LV4.SetActive(false);
            grayUnitPool.Add(grayUnitPrefabs_LV4);

            var grayUnitPrefabs_LV5 = Instantiate<GameObject>(unitPrefabs[(int)Unit.grayUnit_LV5], grayUnit_LV5.transform);
            grayUnitPrefabs_LV5.name = "GrayUnit_LV5_" + i.ToString("00");
            grayUnitPrefabs_LV5.SetActive(false);
            grayUnitPool.Add(grayUnitPrefabs_LV5);

            var grayUnitPrefabs_LV6 = Instantiate<GameObject>(unitPrefabs[(int)Unit.grayUnit_LV6], grayUnit_LV6.transform);
            grayUnitPrefabs_LV6.name = "GrayUnit_LV6_" + i.ToString("00");
            grayUnitPrefabs_LV6.SetActive(false);
            grayUnitPool.Add(grayUnitPrefabs_LV6);

            // 레드 유닛
            var redUnitPrefabs_LV1 = Instantiate<GameObject>(unitPrefabs[(int)Unit.redUnit_LV1], redUnit_LV1.transform);
            redUnitPrefabs_LV1.name = "RedUnit_LV1_" + i.ToString("00");
            redUnitPrefabs_LV1.SetActive(false);
            redUnitPool.Add(redUnitPrefabs_LV1);

            var redUnitPrefabs_LV2 = Instantiate<GameObject>(unitPrefabs[(int)Unit.redUnit_LV2], redUnit_LV2.transform);
            redUnitPrefabs_LV2.name = "RedUnit_LV2_" + i.ToString("00");
            redUnitPrefabs_LV2.SetActive(false);
            redUnitPool.Add(redUnitPrefabs_LV2);

            var redUnitPrefabs_LV3 = Instantiate<GameObject>(unitPrefabs[(int)Unit.redUnit_LV3], redUnit_LV3.transform);
            redUnitPrefabs_LV3.name = "RedUnit_LV3_" + i.ToString("00");
            redUnitPrefabs_LV3.SetActive(false);
            redUnitPool.Add(redUnitPrefabs_LV3);

            var redUnitPrefabs_LV4 = Instantiate<GameObject>(unitPrefabs[(int)Unit.redUnit_LV4], redUnit_LV4.transform);
            redUnitPrefabs_LV4.name = "RedUnit_LV4_" + i.ToString("00");
            redUnitPrefabs_LV4.SetActive(false);
            redUnitPool.Add(redUnitPrefabs_LV4);

            var redUnitPrefabs_LV5 = Instantiate<GameObject>(unitPrefabs[(int)Unit.redUnit_LV5], redUnit_LV5.transform);
            redUnitPrefabs_LV5.name = "RedUnit_LV5_" + i.ToString("00");
            redUnitPrefabs_LV5.SetActive(false);
            redUnitPool.Add(redUnitPrefabs_LV5);

            var redUnitPrefabs_LV6 = Instantiate<GameObject>(unitPrefabs[(int)Unit.redUnit_LV6], redUnit_LV6.transform);
            redUnitPrefabs_LV6.name = "RedUnit_LV6_" + i.ToString("00");
            redUnitPrefabs_LV6.SetActive(false);
            redUnitPool.Add(redUnitPrefabs_LV6);
        }

        // 에너미 유닛
        for (int i = 0; i < 1000; i++)
        {
            var enemyPrefabs_LV1 = Instantiate<GameObject>(enemyPrefabs[(int)EnemyUnit.LV1], enemy_LV1.transform);
            enemyPrefabs_LV1.name = "enemy_LV1_" + i.ToString("00");
            enemyPrefabs_LV1.SetActive(false);
            enemyLV1Pool.Add(enemyPrefabs_LV1);

            var enemyPrefabs_LV2 = Instantiate<GameObject>(enemyPrefabs[(int)EnemyUnit.LV2], enemy_LV2.transform);
            enemyPrefabs_LV2.name = "enemy_LV2_" + i.ToString("00");
            enemyPrefabs_LV2.SetActive(false);
            enemyLV2Pool.Add(enemyPrefabs_LV2);

            var enemyPrefabs_LV3 = Instantiate<GameObject>(enemyPrefabs[(int)EnemyUnit.LV3], enemy_LV3.transform);
            enemyPrefabs_LV3.name = "enemy_LV3_" + i.ToString("00");
            enemyPrefabs_LV3.SetActive(false);
            enemyLV3Pool.Add(enemyPrefabs_LV3);
        }
        for (int i = 0; i < 500; i++)
        {
            var enemyPrefabs_LV4 = Instantiate<GameObject>(enemyPrefabs[(int)EnemyUnit.LV4], enemy_LV4.transform);
            enemyPrefabs_LV4.name = "enemy_LV4_" + i.ToString("00");
            enemyPrefabs_LV4.SetActive(false);
            enemyLV4Pool.Add(enemyPrefabs_LV4);

            var enemyPrefabs_LV5 = Instantiate<GameObject>(enemyPrefabs[(int)EnemyUnit.LV5], enemy_LV5.transform);
            enemyPrefabs_LV5.name = "enemy_LV5_" + i.ToString("00");
            enemyPrefabs_LV5.SetActive(false);
            enemyLV5Pool.Add(enemyPrefabs_LV5);

            var enemyPrefabs_LV6 = Instantiate<GameObject>(enemyPrefabs[(int)EnemyUnit.LV6], enemy_LV6.transform);
            enemyPrefabs_LV6.name = "enemy_LV6_" + i.ToString("00");
            enemyPrefabs_LV6.SetActive(false);
            enemyLV6Pool.Add(enemyPrefabs_LV6);
        }
        for (int i = 0; i < 250; i++)
        {
            var enemyPrefabs_LV7 = Instantiate<GameObject>(enemyPrefabs[(int)EnemyUnit.LV7], enemy_LV7.transform);
            enemyPrefabs_LV7.name = "enemy_LV7_" + i.ToString("00");
            enemyPrefabs_LV7.SetActive(false);
            enemyLV7Pool.Add(enemyPrefabs_LV7);

            var enemyPrefabs_LV8 = Instantiate<GameObject>(enemyPrefabs[(int)EnemyUnit.LV8], enemy_LV8.transform);
            enemyPrefabs_LV8.name = "enemy_LV8_" + i.ToString("00");
            enemyPrefabs_LV8.SetActive(false);
            enemyLV8Pool.Add(enemyPrefabs_LV8);

            var enemyPrefabs_LV9 = Instantiate<GameObject>(enemyPrefabs[(int)EnemyUnit.LV9], enemy_LV9.transform);
            enemyPrefabs_LV9.name = "enemy_LV9_" + i.ToString("00");
            enemyPrefabs_LV9.SetActive(false);
            enemyLV9Pool.Add(enemyPrefabs_LV9);
        }
    }

    public void CreateMoneyPool()
    {
        GameObject money = new GameObject("MoneyPool");

        for (int i = 0; i < 1000; i++)
        {
            var moneys = Instantiate<GameObject>(moneyPrefabs[i % moneyPrefabs.Length], money.transform);
            moneys.name = "money" + i.ToString("00");
            moneys.SetActive(false);
            moneyPool.Add(moneys);
        }
    }

    public void CreateEffectPool()
    {
        GameObject deadEffectPool = new GameObject("DeadEffectPool");

        GameObject blueDeadEffect = new GameObject("blueDeadEffect");
        GameObject greenDeadEffect = new GameObject("GreenDeadEffect");
        GameObject grayDeadEffect = new GameObject("GrayDeadEffect");
        GameObject purpleDeadEffect = new GameObject("PurpleDeadEffect");
        GameObject orangeDeadEffect = new GameObject("OrangeDeadEffect");
        GameObject redDeadEffect = new GameObject("RedDeadEffect");

        blueDeadEffect.transform.parent = deadEffectPool.transform;
        greenDeadEffect.transform.parent = deadEffectPool.transform;
        purpleDeadEffect.transform.parent = deadEffectPool.transform;
        redDeadEffect.transform.parent = deadEffectPool.transform;
        grayDeadEffect.transform.parent = deadEffectPool.transform;
        orangeDeadEffect.transform.parent = deadEffectPool.transform;

        for (int i = 0; i < 10; i++)
        {
            var blueDeadEffectPrefabs = Instantiate<GameObject>(deadEffectPrefabs[0], blueDeadEffect.transform);
            blueDeadEffectPrefabs.name = "BlueDeadEffect_" + i.ToString("00");
            blueDeadEffectPrefabs.SetActive(false);
            blueDeadEffectPool.Add(blueDeadEffectPrefabs);

            var greenDeadEffectPrefabs = Instantiate<GameObject>(deadEffectPrefabs[1], greenDeadEffect.transform);
            greenDeadEffectPrefabs.name = "GreenDeadEffect_" + i.ToString("00");
            greenDeadEffectPrefabs.SetActive(false);
            greenDeadEffectPool.Add(greenDeadEffectPrefabs);

            var purpleDeadEffectPrefabs = Instantiate<GameObject>(deadEffectPrefabs[2], purpleDeadEffect.transform);
            purpleDeadEffectPrefabs.name = "purpleDeadEffect_" + i.ToString("00");
            purpleDeadEffectPrefabs.SetActive(false);
            purpleDeadEffectPool.Add(purpleDeadEffectPrefabs);

            var redDeadEffectPrefabs = Instantiate<GameObject>(deadEffectPrefabs[3], redDeadEffect.transform);
            redDeadEffectPrefabs.name = "RedDeadEffect_" + i.ToString("00");
            redDeadEffectPrefabs.SetActive(false);
            redDeadEffectPool.Add(redDeadEffectPrefabs);

            var grayDeadEffectPrefabs = Instantiate<GameObject>(deadEffectPrefabs[4], grayDeadEffect.transform);
            grayDeadEffectPrefabs.name = "GrayDeadEffect_" + i.ToString("00");
            grayDeadEffectPrefabs.SetActive(false);
            grayDeadEffectPool.Add(grayDeadEffectPrefabs);

            var orangeDeadEffectPrefabs = Instantiate<GameObject>(deadEffectPrefabs[5], orangeDeadEffect.transform);
            orangeDeadEffectPrefabs.name = "OrangeDeadEffect_" + i.ToString("00");
            orangeDeadEffectPrefabs.SetActive(false);
            orangeDeadEffectPool.Add(orangeDeadEffectPrefabs);
        }

    }
}

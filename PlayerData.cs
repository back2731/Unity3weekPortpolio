using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerData : Singleton<PlayerData>
{
    private float blueUnitProbabilityPoint = 0;
    public float BlueUnitProbabilityPoint
    {
        get
        {
            return blueUnitProbabilityPoint;
        }
        set
        {
            blueUnitProbabilityPoint = value;
            blueUnitProbability += blueUnitProbabilityPoint;
        }
    }

    private float greenUnitProbabilityPoint = 0;
    public float GreenUnitProbabilityPoint
    {
        get
        {
            return greenUnitProbabilityPoint;
        }
        set
        {
            greenUnitProbabilityPoint = value;
            greenUnitProbability += greenUnitProbabilityPoint;
        }
    }

    private float orangeUnitProbabilityPoint = 0;
    public float OrangeUnitProbabilityPoint
    {
        get
        {
            return orangeUnitProbabilityPoint;
        }
        set
        {
            orangeUnitProbabilityPoint = value;
            orangeUnitProbability += orangeUnitProbabilityPoint;
        }
    }

    private float grayUnitProbabilityPoint = 0;
    public float GrayUnitProbabilityPoint
    {
        get
        {
            return grayUnitProbabilityPoint;
        }
        set
        {
            grayUnitProbabilityPoint = value;
            grayUnitProbability += grayUnitProbabilityPoint;
        }
    }

    private float redUnitProbabilityPoint = 0;
    public float RedUnitProbabilityPoint
    {
        get
        {
            return redUnitProbabilityPoint;
        }
        set
        {
            redUnitProbabilityPoint = value;
            redUnitProbability += redUnitProbabilityPoint;
        }
    }

    public float blueUnitProbability    = 0.0f;
    public float greenUnitProbability   = 0.0f;
    public float orangeUnitProbability  = 0.0f;
    public float grayUnitProbability    = 50.0f;
    public float redUnitProbability     = 0.0f;

    private float blueUnitSkillLV = 0;
    public float BlueUnitSkillLV
    {
        get
        {
            return blueUnitSkillLV;
        }
        set
        {
            blueUnitSkillLV = value;
            blueLaserBoltDamage = 1.0f + blueUnitSkillLV * 0.1f;
            blueHommingBulletDamage = 10.0f + blueUnitSkillLV * 0.3f;
        }
    }

    private float greenUnitSkillLV = 0;
    public float GreenUnitSkillLV
    {
        get
        {
            return greenUnitSkillLV;
        }
        set
        {
            greenUnitSkillLV = value;
            greenLaserBoltDamage = 1.0f + greenUnitSkillLV * 0.1f;
        }
    }

    private float orangeUnitSkillLV = 0;
    public float OrangeUnitSkillLV
    {
        get
        {
            return orangeUnitSkillLV;
        }
        set
        {
            orangeUnitSkillLV = value;
            yellowLaserBoltDamage = 1.0f + orangeUnitSkillLV * 0.1f;
            orangeBeamLaserDamage = 1.0f + orangeUnitSkillLV * 0.8f;
        }
    }

    private float grayUnitSkillLV = 0;
    public float GrayUnitSkillLV
    {
        get
        {
            return grayUnitSkillLV;
        }
        set
        {
            grayUnitSkillLV = value;
            whiteLaserBoltDamage = 1.0f + grayUnitSkillLV * 0.1f;
        }
    }

    private float redUnitSkillLV = 0;
    public float RedUnitSkillLV
    {
        get
        {
            return redUnitSkillLV;
        }
        set
        {
            redUnitSkillLV = value;
            redLaserBoltDamage = 1.0f + redUnitSkillLV * 0.1f;
            redShockwaveBullet = 5.0f + redUnitSkillLV * 0.8f;
        }
    }

    // 차후 스킬레벨에 따른 데미지 조정 가능
    public float blueLaserBoltDamage    = 1.0f;
    public float greenLaserBoltDamage   = 1.0f;
    public float purpleLaserBoltDamage  = 1.0f;
    public float redLaserBoltDamage     = 1.0f;
    public float whiteLaserBoltDamage   = 1.0f;
    public float yellowLaserBoltDamage  = 1.0f;

    // 차후 스킬레벨에 따른 데미지 조정 가능
    public float orangeBeamLaserDamage  = 1.0f;

    // 차후 스킬레벨에 따른 데미지 조정 가능
    public float blueHommingBulletDamage = 10.0f;

    public float redShockwaveBullet = 5.0f;

    private float playerMoney = 1000.0f;
    public float PlayerMoney
    {
        get
        {
            return playerMoney;
        }
        set
        {
            playerMoney = value;
            JsonManager.instance.SaveData();
        }
    }

    private float playerInGameMoney = 0.0f;
    public float PlayerInGameMoney
    {
        get
        {
            return playerInGameMoney;
        }
        set
        {
            playerInGameMoney = value;
        }
    }

    private void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/jsonDat.json"))
        {
            JsonManager.instance.LoadData();

            Debug.Log("파일이 있다.");
        }
        else
        {
            blueUnitProbability = 0.0f;
            greenUnitProbability = 0.0f;
            orangeUnitProbability = 0.0f;
            grayUnitProbability = 50.0f;
            redUnitProbability = 0.0f;

            blueUnitSkillLV = 0.0f;
            greenUnitSkillLV = 0.0f;
            orangeUnitSkillLV = 0.0f;
            grayUnitSkillLV = 0.0f;
            redUnitSkillLV = 0.0f;

            playerMoney = 1000.0f;

            Debug.Log("파일이 없다.");

            JsonManager.instance.SaveData();
        }
    }
}

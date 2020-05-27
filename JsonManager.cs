using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using LitJson;
using System.IO;

[SerializeField]
class Data
{
    public float blueUnitProbability;
    public float greenUnitProbability;
    public float orangeUnitProbability;
    public float grayUnitProbability;
    public float redUnitProbability;

    public float blueUnitSkillLV;
    public float greenUnitSkillLV;
    public float orangeUnitSkillLV;
    public float grayUnitSkillLV;
    public float redUnitSkillLV;

    public float playerMoney;
}

public class JsonManager : Singleton<JsonManager>
{
    public void SaveData()
    {
        var data = new Data();

        data.blueUnitProbability = PlayerData.instance.blueUnitProbability;
        data.greenUnitProbability = PlayerData.instance.greenUnitProbability;
        data.orangeUnitProbability = PlayerData.instance.orangeUnitProbability;
        data.grayUnitProbability = PlayerData.instance.grayUnitProbability;
        data.redUnitProbability = PlayerData.instance.redUnitProbability;

        data.blueUnitSkillLV = PlayerData.instance.BlueUnitSkillLV;
        data.greenUnitSkillLV = PlayerData.instance.GreenUnitSkillLV;
        data.orangeUnitSkillLV = PlayerData.instance.OrangeUnitSkillLV;
        data.grayUnitSkillLV = PlayerData.instance.GrayUnitSkillLV;
        data.redUnitSkillLV = PlayerData.instance.RedUnitSkillLV;

        data.playerMoney = PlayerData.instance.PlayerMoney;

        string toJson = JsonUtility.ToJson(data, prettyPrint: true);

        File.WriteAllText(Application.persistentDataPath + "/jsonDat.json", toJson.ToString());

        Debug.Log("데이터 저장");
    }

    public void LoadData()
    {
        string jsonString = File.ReadAllText(Application.persistentDataPath + "/jsonDat.json");

        var data = JsonUtility.FromJson<Data>(jsonString);

        PlayerData.instance.blueUnitProbability = data.blueUnitProbability;
        PlayerData.instance.greenUnitProbability = data.greenUnitProbability;
        PlayerData.instance.orangeUnitProbability = data.orangeUnitProbability;
        PlayerData.instance.grayUnitProbability = data.grayUnitProbability;
        PlayerData.instance.redUnitProbability = data.redUnitProbability;

        PlayerData.instance.BlueUnitSkillLV = data.blueUnitSkillLV;
        PlayerData.instance.GreenUnitSkillLV = data.greenUnitSkillLV;
        PlayerData.instance.OrangeUnitSkillLV = data.orangeUnitSkillLV;
        PlayerData.instance.GrayUnitSkillLV = data.grayUnitSkillLV;
        PlayerData.instance.RedUnitSkillLV = data.redUnitSkillLV;

        PlayerData.instance.PlayerMoney = data.playerMoney;

        Debug.Log("데이터 불러오기");
    }
}

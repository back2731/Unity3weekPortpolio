using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowProbability : MonoBehaviour
{
    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        switch (text.transform.name)
        {
            case "Blue":
                {
                    if (PlayerData.instance.blueUnitProbability == 0)
                    {
                        text.text = "0%";
                    }
                    else
                    {
                        text.text = ((PlayerData.instance.blueUnitProbability / (PlayerData.instance.blueUnitProbability +
                                                                                    PlayerData.instance.greenUnitProbability +
                                                                                    PlayerData.instance.orangeUnitProbability +
                                                                                    PlayerData.instance.grayUnitProbability +
                                                                                    PlayerData.instance.redUnitProbability)) * 100.0f).ToString("N1") + "%";
                    }
                }
                break;
            case "Green":
                {
                    if (PlayerData.instance.greenUnitProbability == 0)
                    {
                        text.text = "0%";
                    }
                    else
                    {
                        text.text = ((PlayerData.instance.greenUnitProbability / (PlayerData.instance.blueUnitProbability +
                                                                                    PlayerData.instance.greenUnitProbability +
                                                                                    PlayerData.instance.orangeUnitProbability +
                                                                                    PlayerData.instance.grayUnitProbability +
                                                                                    PlayerData.instance.redUnitProbability)) * 100.0f).ToString("N1") + "%";
                    }
                }
                break;
            case "Orange":
                {
                    if (PlayerData.instance.orangeUnitProbability == 0)
                    {
                        text.text = "0%";
                    }
                    else
                    {
                        text.text = ((PlayerData.instance.orangeUnitProbability / (PlayerData.instance.blueUnitProbability +
                                                                                    PlayerData.instance.greenUnitProbability +
                                                                                    PlayerData.instance.orangeUnitProbability +
                                                                                    PlayerData.instance.grayUnitProbability +
                                                                                    PlayerData.instance.redUnitProbability)) * 100.0f).ToString("N1") + "%";
                    }
                }
                break;
            case "Gray":
                {
                    if (PlayerData.instance.grayUnitProbability == 0)
                    {
                        text.text = "0%";
                    }
                    else
                    {
                        text.text = ((PlayerData.instance.grayUnitProbability / (PlayerData.instance.blueUnitProbability +
                                                                                    PlayerData.instance.greenUnitProbability +
                                                                                    PlayerData.instance.orangeUnitProbability +
                                                                                    PlayerData.instance.grayUnitProbability +
                                                                                    PlayerData.instance.redUnitProbability)) * 100.0f).ToString("N1") + "%";
                    }
                }
                break;
            case "Red":
                {
                    if (PlayerData.instance.redUnitProbability == 0)
                    {
                        text.text = "0%";
                    }
                    else
                    {
                        text.text = ((PlayerData.instance.redUnitProbability / (PlayerData.instance.blueUnitProbability +
                                                                                    PlayerData.instance.greenUnitProbability +
                                                                                    PlayerData.instance.orangeUnitProbability +
                                                                                    PlayerData.instance.grayUnitProbability +
                                                                                    PlayerData.instance.redUnitProbability)) * 100.0f).ToString("N1") + "%";
                    }
                }
                break;
            case "BlueWeapon":
                {
                    if (PlayerData.instance.BlueUnitSkillLV == 0)
                    {
                        text.text = "LV 0";
                    }
                    else
                    {
                        text.text = "LV " + PlayerData.instance.BlueUnitSkillLV.ToString("N0");
                    }
                }
                break;
            case "GreenWeapon":
                {
                    if (PlayerData.instance.GreenUnitSkillLV == 0)
                    {
                        text.text = "LV 0";
                    }
                    else
                    {
                        text.text = "LV " + PlayerData.instance.GreenUnitSkillLV.ToString("N0");
                    }
                }
                break;
            case "OrangeWeapon":
                {
                    if (PlayerData.instance.OrangeUnitSkillLV == 0)
                    {
                        text.text = "LV 0";
                    }
                    else
                    {
                        text.text = "LV " + PlayerData.instance.OrangeUnitSkillLV.ToString("N0");
                    }
                }
                break;
            case "GrayWeapon":
                {
                    if (PlayerData.instance.GrayUnitSkillLV == 0)
                    {
                        text.text = "LV 0";
                    }
                    else
                    {
                        text.text = "LV " + PlayerData.instance.GrayUnitSkillLV.ToString("N0");
                    }
                }
                break;
            case "RedWeapon":
                {
                    if (PlayerData.instance.RedUnitSkillLV == 0)
                    {
                        text.text = "LV 0";
                    }
                    else
                    {
                        text.text = "LV " + PlayerData.instance.RedUnitSkillLV.ToString("N0");
                    }
                }
                break;
        }
    }
}
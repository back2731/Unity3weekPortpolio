using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickLobbyButton : MonoBehaviour
{
    private float probabilityCost = 1000.0f;
    private float weaponCost = 100.0f;
    //private float refund = 1.0f;

    private AudioSource buttonSound;

    private void Awake()
    {
        buttonSound = GetComponent<AudioSource>();
    }

    // 스테이지 선택
    public void SetStage(int stageNumber)
    {
        LoadSceneManager.instance.LoadScene("GameScene");
        StageManager.instance.StageNumber = stageNumber;
        RestartGame();
        buttonSound.Play();
    }

    public void RestartGame()
    {
        GameManager.instance.stopGame = false;
        GameManager.instance.isGame = true;
    }

    // 로비창 UI
    public void OpenUpgradeMenu()
    {
        GameObject upgradePanel;
        GameObject closeButton;
        upgradePanel = GameObject.Find("UnitUpgradeMenu").transform.Find("UpgradePanel").gameObject;
        closeButton = GameObject.Find("UnitUpgradeMenu").transform.Find("CloseButton").gameObject;

        upgradePanel.SetActive(true);
        closeButton.SetActive(true);
        buttonSound.Play();
    }

    public void CloseUpgradeMenu()
    {
        GameObject upgradePanel;
        GameObject closeButton;
        upgradePanel = GameObject.Find("UnitUpgradeMenu").transform.Find("UpgradePanel").gameObject;
        closeButton = GameObject.Find("UnitUpgradeMenu").transform.Find("CloseButton").gameObject;

        upgradePanel.SetActive(false);
        closeButton.SetActive(false);
        buttonSound.Play();
    }

    public void OpenWeaponMenu()
    {
        GameObject weaponPanel;
        GameObject closeButton;
        weaponPanel = GameObject.Find("WeaponUpgradeMenu").transform.Find("UpgradePanel").gameObject;
        closeButton = GameObject.Find("WeaponUpgradeMenu").transform.Find("CloseButton").gameObject;

        weaponPanel.SetActive(true);
        closeButton.SetActive(true);
        buttonSound.Play();
    }

    public void CloseWeaponMenu()
    {
        GameObject weaponPanel;
        GameObject closeButton;
        weaponPanel = GameObject.Find("WeaponUpgradeMenu").transform.Find("UpgradePanel").gameObject;
        closeButton = GameObject.Find("WeaponUpgradeMenu").transform.Find("CloseButton").gameObject;

        weaponPanel.SetActive(false);
        closeButton.SetActive(false);
        buttonSound.Play();
    }

    public void OpenStageSelectMenu()
    {
        GameObject stagePanel;
        GameObject closeButton;
        GameObject specialStage;

        stagePanel = GameObject.Find("StageSelect").transform.Find("StageSelectPanel").gameObject;
        closeButton = GameObject.Find("StageSelect").transform.Find("CloseButton").gameObject;
        specialStage = GameObject.Find("StageSelect").transform.Find("SpecialStage").gameObject;

        stagePanel.SetActive(true);
        closeButton.SetActive(true);
        specialStage.SetActive(true);
        buttonSound.Play();
    }

    public void CloseStageSelectMenu()
    {
        GameObject stagePanel;
        GameObject closeButton;
        GameObject specialStage;

        stagePanel = GameObject.Find("StageSelect").transform.Find("StageSelectPanel").gameObject;
        closeButton = GameObject.Find("StageSelect").transform.Find("CloseButton").gameObject;
        specialStage = GameObject.Find("StageSelect").transform.Find("SpecialStage").gameObject;

        stagePanel.SetActive(false);
        closeButton.SetActive(false);
        specialStage.SetActive(false);
        buttonSound.Play();
    }

    public void OpenExitMenu()
    {
        GameObject panel;
        GameObject exitPanel;

        panel = GameObject.Find("ExitMenu").transform.Find("Panel").gameObject;
        exitPanel = GameObject.Find("ExitMenu").transform.Find("ExitPanel").gameObject;

        panel.SetActive(true);
        exitPanel.SetActive(true);
        buttonSound.Play();
    }

    public void CloseExitMenu()
    {
        GameObject panel;
        GameObject exitPanel;

        panel = GameObject.Find("ExitMenu").transform.Find("Panel").gameObject;
        exitPanel = GameObject.Find("ExitMenu").transform.Find("ExitPanel").gameObject;

        panel.SetActive(false);
        exitPanel.SetActive(false);
        buttonSound.Play();
    }

    public void ExitGame()
    {
        JsonManager.instance.SaveData();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // 유닛 생성확률 UI
    public void AddPointBlueUnitProbability()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.blueUnitProbability + 1.0f) * probabilityCost)
        {
            PlayerData.instance.BlueUnitProbabilityPoint = 1;
            PlayerData.instance.PlayerMoney -= PlayerData.instance.blueUnitProbability * probabilityCost;
        }
        buttonSound.Play();
    }

    public void SubtractPointBlueUnitProbability()
    {
        if (PlayerData.instance.blueUnitProbability != 0)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.blueUnitProbability * probabilityCost;
            PlayerData.instance.BlueUnitProbabilityPoint = -1;
        }
        buttonSound.Play();
    }

    public void AddPointGreenUnitProbability()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.greenUnitProbability + 1.0f) * probabilityCost)
        {
            PlayerData.instance.GreenUnitProbabilityPoint = 1;
            PlayerData.instance.PlayerMoney -= PlayerData.instance.greenUnitProbability * probabilityCost;
        }
        buttonSound.Play();
    }

    public void SubtractPointGreenUnitProbability()
    {
        if (PlayerData.instance.greenUnitProbability != 0)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.greenUnitProbability * probabilityCost;
            PlayerData.instance.GreenUnitProbabilityPoint = -1;
        }
        buttonSound.Play();
    }

    public void AddPointOrangeUnitProbability()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.orangeUnitProbability + 1.0f) * probabilityCost)
        {
            PlayerData.instance.OrangeUnitProbabilityPoint = 1;
            PlayerData.instance.PlayerMoney -= PlayerData.instance.orangeUnitProbability * probabilityCost;
        }
        buttonSound.Play();
    }

    public void SubtractPointOrangeUnitProbability()
    {
        if (PlayerData.instance.orangeUnitProbability != 0)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.orangeUnitProbability * probabilityCost;
            PlayerData.instance.OrangeUnitProbabilityPoint = -1;
        }
        buttonSound.Play();
    }

    public void AddPointGrayUnitProbability()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.grayUnitProbability + 1.0f) * probabilityCost)
        {
            PlayerData.instance.GrayUnitProbabilityPoint = 1;
            PlayerData.instance.PlayerMoney -= PlayerData.instance.grayUnitProbability * probabilityCost;
        }
        buttonSound.Play();
    }

    public void SubtractPointGrayUnitProbability()
    {
        if (PlayerData.instance.grayUnitProbability > 50)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.grayUnitProbability * probabilityCost;
            PlayerData.instance.GrayUnitProbabilityPoint = -1;
        }
        buttonSound.Play();
    }

    public void AddPointRedUnitProbability()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.redUnitProbability + 1.0f) * probabilityCost)
        {
            PlayerData.instance.RedUnitProbabilityPoint = 1;
            PlayerData.instance.PlayerMoney -= PlayerData.instance.redUnitProbability * probabilityCost;
        }
        buttonSound.Play();
    }

    public void SubtractPointRedUnitProbability()
    {
        if (PlayerData.instance.redUnitProbability != 0)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.redUnitProbability * probabilityCost;
            PlayerData.instance.RedUnitProbabilityPoint = -1;
        }
        buttonSound.Play();
    }

    // 유닛 스킬 레벨 UI
    public void AddPointBlueUnitSkillLV()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.BlueUnitSkillLV + 1.0f) * weaponCost)
        {
            if (PlayerData.instance.BlueUnitSkillLV < 100)
            {
                PlayerData.instance.BlueUnitSkillLV += 1;
                PlayerData.instance.PlayerMoney -= PlayerData.instance.BlueUnitSkillLV * weaponCost;
            }
        }
        buttonSound.Play();
    }

    public void SubtractPointBlueUnitSkillLV()
    {
        if (PlayerData.instance.BlueUnitSkillLV != 0)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.BlueUnitSkillLV * weaponCost;
            PlayerData.instance.BlueUnitSkillLV -= 1;
        }
        buttonSound.Play();
    }

    public void AddPointGreenUnitSkillLV()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.GreenUnitSkillLV + 1.0f) * weaponCost)
        {
            if (PlayerData.instance.GreenUnitSkillLV < 100)
            {
                PlayerData.instance.GreenUnitSkillLV += 1;
                PlayerData.instance.PlayerMoney -= PlayerData.instance.GreenUnitSkillLV * weaponCost;
            }
        }
        buttonSound.Play();
    }

    public void SubtractPointGreenUnitSkillLV()
    {
        if (PlayerData.instance.GreenUnitSkillLV != 0)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.GreenUnitSkillLV * weaponCost;
            PlayerData.instance.GreenUnitSkillLV -= 1;
        }
        buttonSound.Play();
    }

    public void AddPointOrangeUnitSkillLV()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.OrangeUnitSkillLV + 1.0f) * weaponCost)
        {
            if (PlayerData.instance.OrangeUnitSkillLV < 100)
            {
                PlayerData.instance.OrangeUnitSkillLV += 1;
                PlayerData.instance.PlayerMoney -= PlayerData.instance.OrangeUnitSkillLV * weaponCost;
            }
        }
        buttonSound.Play();
    }

    public void SubtractPointOrangeUnitSkillLV()
    {
        if (PlayerData.instance.OrangeUnitSkillLV != 0)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.OrangeUnitSkillLV * weaponCost;
            PlayerData.instance.OrangeUnitSkillLV -= 1;
        }
        buttonSound.Play();
    }

    public void AddPointGrayUnitSkillLV()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.GrayUnitSkillLV + 1.0f) * weaponCost)
        {
            if (PlayerData.instance.GrayUnitSkillLV < 100)
            {
                PlayerData.instance.GrayUnitSkillLV += 1;
                PlayerData.instance.PlayerMoney -= PlayerData.instance.GrayUnitSkillLV * weaponCost;
            }
        }
        buttonSound.Play();
    }

    public void SubtractPointGrayUnitSkillLV()
    {
        if (PlayerData.instance.GrayUnitSkillLV != 0)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.GrayUnitSkillLV * weaponCost;
            PlayerData.instance.GrayUnitSkillLV -= 1;
        }
        buttonSound.Play();
    }

    public void AddPointRedUnitSkillLV()
    {
        if (PlayerData.instance.PlayerMoney >= 0 && PlayerData.instance.PlayerMoney >= (PlayerData.instance.RedUnitSkillLV + 1.0f) * weaponCost)
        {
            if (PlayerData.instance.RedUnitSkillLV < 100)
            {
                PlayerData.instance.RedUnitSkillLV += 1;
                PlayerData.instance.PlayerMoney -= PlayerData.instance.RedUnitSkillLV * weaponCost;
            }
        }
        buttonSound.Play();
    }

    public void SubtractPointRedUnitSkillLV()
    {
        if (PlayerData.instance.RedUnitSkillLV != 0)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.RedUnitSkillLV * weaponCost;
            PlayerData.instance.RedUnitSkillLV -= 1;
        }
        buttonSound.Play();
    }
}

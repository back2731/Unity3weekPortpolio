using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickInGameButton : MonoBehaviour
{
    [SerializeField]
    private bool isSwitchSelectButton = false;

    [SerializeField]
    private bool isSwitchSpeedUpButton = false;

    [SerializeField]
    private bool isPauseGameButton = false;

    private AudioSource buttonSound;

    private void Awake()
    {
        buttonSound = GetComponent<AudioSource>();
    }

    // 로비씬으로
    public void GoToLobbyScene()
    {
        LoadSceneManager.instance.LoadScene("LobbyScene");
        StageManager.instance.StageNumber = 0;
        PlayerData.instance.PlayerMoney += PlayerData.instance.PlayerInGameMoney * 0.5f;
        buttonSound.Play();
    }

    public void OpenSelectSpawn()
    {
        GameObject selectSpawnPanel;
        selectSpawnPanel = GameObject.Find("SelectSpawnPanel").transform.Find("SelectSpawn").gameObject;

        isSwitchSelectButton = !isSwitchSelectButton;

        selectSpawnPanel.SetActive(isSwitchSelectButton);

        GameObject button;
        Text text;
        button = GameObject.Find("SelectSpawnButton").transform.Find("Text").gameObject;
        text = button.GetComponent<Text>();

        if(isSwitchSelectButton == true)
        {
            text.text = "Close";
        }
        else
        {
            text.text = "Select";
        }
        buttonSound.Play();
    }

    public void ControlEnemySpawnDelay()
    {
        GameObject speed1LV;
        GameObject speed2LV;
        speed1LV = GameObject.Find("SpeedUpButton").transform.Find("Speed_1").gameObject;
        speed2LV = GameObject.Find("SpeedUpButton").transform.Find("Speed_2").gameObject;

        speed1LV.SetActive(isSwitchSpeedUpButton);

        isSwitchSpeedUpButton = !isSwitchSpeedUpButton;

        speed2LV.SetActive(isSwitchSpeedUpButton);
        //Debug.Log(isSwitchSpeedUpButton);

        if(isSwitchSpeedUpButton)
        {
            PlayerManager.instance.enemySpawnDelay = 1.5f;
            PlayerManager.instance.playerAddPower = 2.0f;
        }
        else
        {
            PlayerManager.instance.enemySpawnDelay = 3.0f;
            PlayerManager.instance.playerAddPower = 1.0f;
        }
        buttonSound.Play();
    }

    public void PauseGame()
    {
        GameObject pauseObject;
        pauseObject = GameObject.Find("Pause").transform.Find("PauseObjects").gameObject;

        isPauseGameButton = !isPauseGameButton;
        pauseObject.SetActive(isPauseGameButton);

        if (isPauseGameButton)
        {
            PlayerManager.instance.timeLimit = false;
            PlayerManager.instance.playerAddPower = 0.0f;
        }
        else
        {
            PlayerManager.instance.timeLimit = true;
            PlayerManager.instance.playerAddPower = 1.0f;

        }
        buttonSound.Play();
    }
}

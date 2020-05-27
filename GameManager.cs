using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public bool isGame = true;
    public bool stopGame = false;
    public bool gameResult = false;

    // ture - 미션 승리 / false - 미션 패배
    public bool isMissionResult = false;
    GameObject gameoverPanel;

    protected override void Awake()
    {
        base.Awake();
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        // 게임이 종료
        if(!isGame && !stopGame)
        {
            if(isMissionResult) // 승리
            {
                gameResult = true;
                stopGame = true;
                OnGameoverPanel(gameResult);
                //Debug.Log("승리!");
                            }
            else                // 패배
            {
                gameResult = false;
                OnGameoverPanel(gameResult);
                stopGame = true;
                //Debug.Log("패배!");
            }
        }
    }

    public void OnGameoverPanel(bool gameResult)
    {
        gameoverPanel = GameObject.Find("Gameover").transform.Find("GameoverPanel").gameObject;
        gameoverPanel.SetActive(true);
        StartCoroutine("ReturnToLobby" , gameResult);
    }

    IEnumerator ReturnToLobby(bool gameResult)
    {
        yield return new WaitForSeconds(3.0f);

        gameoverPanel.SetActive(false);

        if (gameResult)
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.PlayerInGameMoney;
        }
        else
        {
            PlayerData.instance.PlayerMoney += PlayerData.instance.PlayerInGameMoney;
        }

        PlayerData.instance.PlayerInGameMoney = 0.0f;

        LoadSceneManager.instance.LoadScene("LobbyScene");
    }
}

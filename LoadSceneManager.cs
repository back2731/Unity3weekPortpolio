using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneManager : Singleton<LoadSceneManager>
{
    public static string nextScene;

    [SerializeField]
    private Image progressBar;

    [SerializeField]
    private Text percentText;

    Coroutine coroutine;

    protected override void Awake()
    {
        coroutine = StartCoroutine("LoadNextScene");
    }

    private void Start()
    {
    }

    public void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        StartCoroutine("LoadNextScene");
        SceneManager.LoadScene("LoadingScene");
    }

    IEnumerator LoadNextScene()
    {
        yield return null;

        AsyncOperation asyncScene = SceneManager.LoadSceneAsync(nextScene);

        asyncScene.allowSceneActivation = false;

        float timer = 0.0f;
        int fakeCount = 0;

        while (!asyncScene.isDone)
        {
            yield return null;

            timer += Time.deltaTime;

            if (asyncScene.progress < 0.9f)
            {
                progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, asyncScene.progress, timer);

                if (progressBar.fillAmount >= asyncScene.progress)
                {
                    timer = 0.0f;
                }
            }
            else
            {
                progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, 1, timer);

                if (progressBar.fillAmount == 1f)
                {
                    fakeCount++;
                    if (fakeCount >= 200)
                    {
                        progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, 1, timer);

                        fakeCount = 0;

                        asyncScene.allowSceneActivation = true;
                    }
                }
            }
            percentText.text = (progressBar.fillAmount * 100 - 0.1f).ToString("N1") + "%";
            //Debug.Log(progressBar.fillAmount);

        }
    }
}

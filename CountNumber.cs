using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountNumber : MonoBehaviour
{
    private Text text;
    private float number = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (number >= 0)
        {
            number -= Time.deltaTime;
        }

        text.text = "Back To Lobby : " + number.ToString("N1");
    }
}

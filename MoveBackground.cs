using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private Transform[] background = null;
    [SerializeField]
    private float speed = 0;

    float topPosY = 0f;
    float bottomPosY = 0f;

    private void Start()
    {
        float length = 40;
        topPosY = length;
        bottomPosY = length * background.Length;

        for (int i = 0; i < background.Length; i++)
        {
            background[i].localPosition.Set(0, 0 + i * length, 0);
        }
    }

    private void Update()
    {
        for (int i = 0; i < background.Length; i++)
        {
            background[i].Translate(new Vector3(0, -speed, 0) * Time.deltaTime);

            if (background[i].position.y < - topPosY)
            {
                Vector3 selfPosition = background[i].position;
                selfPosition.Set(selfPosition.x, selfPosition.y + bottomPosY, selfPosition.z);
                background[i].position = selfPosition;
            }
        }

    }
}

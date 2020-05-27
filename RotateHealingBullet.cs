using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHealingBullet : MonoBehaviour
{
    void Update()
    {
        transform.RotateAround(transform.parent.position, Vector3.forward, 1.0f);
    }
}

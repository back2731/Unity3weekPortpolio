using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveEffect : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine("SetObjectActive");
    }

    IEnumerator SetObjectActive()
    {
        yield return new WaitForSeconds(2.0f);
        gameObject.SetActive(false);
    }
}

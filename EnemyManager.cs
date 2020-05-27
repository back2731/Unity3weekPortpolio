using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
    public List<GameObject> onActiveEnemyUnits = new List<GameObject>();

    protected override void Awake()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            onActiveEnemyUnits.Add(other.gameObject);
            if (GameManager.instance.isGame && onActiveEnemyUnits.Count >= 50)
            {
                GameManager.instance.isGame = false;
                GameManager.instance.isMissionResult = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            onActiveEnemyUnits.Remove(other.gameObject);
        }
    }
}

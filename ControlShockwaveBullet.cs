using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlShockwaveBullet : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody rigidbody;
    private Vector3 newDirection;
    bool isBounce = false;

    private void OnEnable()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.up * 10.0f;
    }

    private void OnDisable()
    {
        rigidbody.velocity = new Vector3(0, 0, 0);
        newDirection = new Vector3(0, 0, 0);
        isBounce = false;
    }

    //void Update()
    //{
    //    if (GameManager.instance.isGame && !isBounce)
    //    {
    //        transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
    //    }
    //}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
            //gameObject.tag = "Untagged";
            Debug.Log("총알 벽 충돌 / 비활성화");
        }
        if (collision.CompareTag("Enemy"))
        {
            if(EnemyManager.instance.onActiveEnemyUnits.Count >= 2)
            {
                int myIndex = EnemyManager.instance.onActiveEnemyUnits.IndexOf(collision.gameObject.transform.gameObject);
                newDirection = GetEnemyDistance(myIndex) * 15.0f;
                rigidbody.velocity = newDirection;
                isBounce = true;
                return;
            }

            //collision.gameObject.GetComponent<ControlEnemy>().enemyHp -= 1.0f;
            //gameObject.SetActive(false);
            //gameObject.tag = "Untagged";
            //Debug.Log("총알 적 충돌 / 비활성화");
        }
    }

    public Vector3 GetEnemyDistance(int index)
    {
        int closetIndex = -1;
        float closetDistance = 1000.0f;
        float currentDistance = 0.0f;

        for (int i = 0; i < EnemyManager.instance.onActiveEnemyUnits.Count; i++)
        {
            if (i == index) continue;
            currentDistance = Vector3.Distance(EnemyManager.instance.onActiveEnemyUnits[i].transform.position, transform.position);

            if (currentDistance > 10.0f) continue;

            if (closetDistance > currentDistance)
            {
                closetDistance = currentDistance;
                closetIndex = i;
                break;
            }
        }

        if(closetIndex == -1)
        {
            gameObject.SetActive(false);
        }
        return (EnemyManager.instance.onActiveEnemyUnits[closetIndex].transform.position - transform.position).normalized;
    }
}

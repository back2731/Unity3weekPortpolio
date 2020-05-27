using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerUnit : MonoBehaviour
{
    Camera mainCam = null;
    private bool mouseState;
    private GameObject target;
    private Vector3 mousePos;

    void Awake()
    {
        mainCam = Camera.main;
    }

    void Update()
    {
        if (GameManager.instance.isGame)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hitInfo;
                target = GetClickedObject(out hitInfo);
                if (target != null)
                {
                    mouseState = true;
                    mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
                    target.transform.parent.position = new Vector3(mousePos.x, mousePos.y, target.transform.parent.position.z);
                }
            }
            if (Input.GetMouseButtonUp(0))
            {
                mouseState = false;
            }

            // 유닛 클릭을 유지하고 있을 때
            if (mouseState)
            {
                mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
                target.transform.parent.position = new Vector3(mousePos.x, mousePos.y, target.transform.parent.position.z);
            }

            // 플레이어 유닛 판매
            if (target != null)
            {
                if (target.transform.parent.position.y <= -3.5f)
                {
                    if (Input.GetMouseButtonUp(0))
                    {
                        for (int i = 0; i < PlayerManager.instance.onActiveUnits.Count; i++)
                        {
                            if (PlayerManager.instance.onActiveUnits[i].name == target.transform.parent.gameObject.name)
                            {
                                PlayerManager.instance.onActiveUnits[i].SetActive(false);
                                PlayerManager.instance.onActiveUnits.RemoveAt(i);

                                // 판매 후 돈 돌려주기
                                PlayerManager.instance.playerPower += PlayerManager.instance.unitBaseCost;

                                // 판매 후 환불용 오브젝트 null
                                PlayerManager.instance.refundUnit = null;
                                mouseState = false;
                            }
                        }
                    }
                }
            }
        }
    }

    GameObject GetClickedObject(out RaycastHit hit)
    {
        int layerMask = (1 << 11) | (1 << 8);
        layerMask = ~layerMask;

        GameObject target = null;
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit, Mathf.Infinity, layerMask))
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                target = hit.collider.gameObject;
            }
        }
        return target;
    }
}


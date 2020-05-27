using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefundUnit : MonoBehaviour
{
    private Text text;
    private Unit unit;



    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGame)
        {
            if (PlayerManager.instance.refundUnit != null)
            {
                switch (PlayerManager.instance.refundUnit.tag)
                {
                    case "BlueUnit_LV1":
                        text.text = PlayerManager.instance.lv1Cost.ToString();
                        break;
                    case "BlueUnit_LV2":
                        text.text = PlayerManager.instance.lv2Cost.ToString();
                        break;
                    case "BlueUnit_LV3":
                        text.text = PlayerManager.instance.lv3Cost.ToString();
                        break;
                    case "BlueUnit_LV4":
                        text.text = PlayerManager.instance.lv4Cost.ToString();
                        break;
                    case "BlueUnit_LV5":
                        text.text = PlayerManager.instance.lv5Cost.ToString();
                        break;
                    case "BlueUnit_LV6":
                        text.text = PlayerManager.instance.lv6Cost.ToString();
                        break;
                    case "GreenUnit_LV1":
                        text.text = PlayerManager.instance.lv1Cost.ToString();
                        break;
                    case "GreenUnit_LV2":
                        text.text = PlayerManager.instance.lv2Cost.ToString();
                        break;
                    case "GreenUnit_LV3":
                        text.text = PlayerManager.instance.lv3Cost.ToString();
                        break;
                    case "GreenUnit_LV4":
                        text.text = PlayerManager.instance.lv4Cost.ToString();
                        break;
                    case "GreenUnit_LV5":
                        text.text = PlayerManager.instance.lv5Cost.ToString();
                        break;
                    case "GreenUnit_LV6":
                        text.text = PlayerManager.instance.lv6Cost.ToString();
                        break;
                    case "OrangeUnit_LV1":
                        text.text = PlayerManager.instance.lv1Cost.ToString();
                        break;
                    case "OrangeUnit_LV2":
                        text.text = PlayerManager.instance.lv2Cost.ToString();
                        break;
                    case "OrangeUnit_LV3":
                        text.text = PlayerManager.instance.lv3Cost.ToString();
                        break;
                    case "OrangeUnit_LV4":
                        text.text = PlayerManager.instance.lv4Cost.ToString();
                        break;
                    case "OrangeUnit_LV5":
                        text.text = PlayerManager.instance.lv5Cost.ToString();
                        break;
                    case "OrangeUnit_LV6":
                        text.text = PlayerManager.instance.lv6Cost.ToString();
                        break;
                    case "GrayUnit_LV1":
                        text.text = PlayerManager.instance.lv1Cost.ToString();
                        break;
                    case "GrayUnit_LV2":
                        text.text = PlayerManager.instance.lv2Cost.ToString();
                        break;
                    case "GrayUnit_LV3":
                        text.text = PlayerManager.instance.lv3Cost.ToString();
                        break;
                    case "GrayUnit_LV4":
                        text.text = PlayerManager.instance.lv4Cost.ToString();
                        break;
                    case "GrayUnit_LV5":
                        text.text = PlayerManager.instance.lv5Cost.ToString();
                        break;
                    case "GrayUnit_LV6":
                        text.text = PlayerManager.instance.lv6Cost.ToString();
                        break;
                    case "RedUnit_LV1":
                        text.text = PlayerManager.instance.lv1Cost.ToString();
                        break;
                    case "RedUnit_LV2":
                        text.text = PlayerManager.instance.lv2Cost.ToString();
                        break;
                    case "RedUnit_LV3":
                        text.text = PlayerManager.instance.lv3Cost.ToString();
                        break;
                    case "RedUnit_LV4":
                        text.text = PlayerManager.instance.lv4Cost.ToString();
                        break;
                    case "RedUnit_LV5":
                        text.text = PlayerManager.instance.lv5Cost.ToString();
                        break;
                    case "RedUnit_LV6":
                        text.text = PlayerManager.instance.lv6Cost.ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                text.text = "Refund";
            }
        }
    }
}

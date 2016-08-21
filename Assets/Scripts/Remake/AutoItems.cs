using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoItems : MonoBehaviour {

    /* UI */
    private GameObject canvas;
    private ClicGold click;
    private Text itemNameInfo;
    private Text itemDPSInfo;
    private Text itemCostInfo;
    private Text countInfo;
    private Transform parent;
    /**/

    /* Values */
    public float cost;
    public float tickValue;
    public float count;
    public float power;
    public string itemName;
    /**/

    public Color standart;
    public Color affordable;
    public float baseCost;
    public Image button;

    void Start ()
    {
        LinkObjects();
        baseCost = cost;
        power = tickValue;
    }
	
	void Update ()
    {
        UI();

        if (click.gold >= cost)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
			GetComponent<Image>().color = standart;
		}
	}

    public void PurchasedItem()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.09f, count));
            tickValue = (Mathf.Round(Mathf.Pow(1.05f, count))) * power;
        }
    }

    public void LinkObjects()
    {
        canvas = GameObject.Find("Canvas");
        click = canvas.transform.FindChild("Clic2").GetComponent<ClicGold>();
        parent = this.transform.parent;
        itemNameInfo = parent.transform.FindChild("Name Text").GetComponent<Text>();
        itemDPSInfo = parent.transform.FindChild("DPS Text").GetComponent<Text>();
        countInfo = parent.transform.FindChild("Amout Text").GetComponent<Text>();
        itemCostInfo = parent.transform.FindChild("Upgrade Button/Upgrade Button Text").GetComponent<Text>();
    }

    public void UI()
    {
        itemNameInfo.text = itemName;
        itemCostInfo.text = "Cout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN";
        itemDPSInfo.text =  "Puissance : " + CurrencyConverter.Instance.GetCurrencyIntoString(tickValue, false, false, false) + " C/s";
        countInfo.text = count.ToString("F0");
    }
}

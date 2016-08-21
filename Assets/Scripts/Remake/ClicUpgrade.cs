using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClicUpgrade : MonoBehaviour {

    private GameObject canvas;
    private ClicGold click;

    /* Text Display */
    private Transform parent;
    private Text itemNameInfo;
    private Text damage;
    private Text itemCountInfo;
    private Text itemCoutInfo;
    /**/

    /* Cost,Count,Power and BasePower */
    public float cost;
    private float baseCost;
    public float count = 0;
    public float clickPower;
    public float baseClickPower;
    /**/

    /* PowerUp */
    private int Up = 0;

    /* Others */
    public string itemName;
    public Color standard;
    public Color affordable;
    public Image button;
    /**/

    void Start ()
    {
        LinkObjects();
        baseCost = cost;
        baseClickPower = clickPower;
        itemNameInfo.text = itemName;
        damage.text = "Puissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(clickPower, false, false, false) + " C/c";
        itemCoutInfo.text = "Cout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false);
        itemCountInfo.text = count.ToString("F0");
    }
	
	void Update ()
    {
        if (click.gold >= cost)
        {
            button.color = affordable;
        }
        else
        {
            button.color = standard;
        }

    }

    /* Method to Link objects fixed */
    public void LinkObjects()
    {
        canvas = GameObject.Find("Canvas");
        click = canvas.transform.FindChild("Clic2").GetComponent<ClicGold>();
        parent = this.transform.parent;
        itemNameInfo = parent.transform.FindChild("Name Text").GetComponent<Text>();
        damage = parent.transform.FindChild("DPS Text").GetComponent<Text>();
        itemCountInfo = parent.transform.FindChild("Amout Text").GetComponent<Text>();
        itemCoutInfo = parent.transform.FindChild("Upgrade Button/Upgrade Button Text").GetComponent<Text>();
    }

    public void BuyObject()
    {
        if (click.gold >= cost )
        {
            click.gold -= cost;
            count += 1;
            click.goldPerClick += (clickPower + ((clickPower / 100)));
            cost = baseCost * Mathf.Pow(1.09f, count);
        }
        PowerUp();
        UpdateUI();
    }

    public void UpdateUI()
    {
        damage.text = "Puissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(clickPower, false, false, false) + " C/c";
        itemCoutInfo.text = "Cout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false);
        itemCountInfo.text = count.ToString("F0");
    }

    public void PowerUp() // Give More Damage after X objects.
    {  
        if (count >= 10 && Up == 0)
        { // Ok pour ce PowerUp ci.
            click.goldPerClick += (10 * clickPower);
            clickPower = clickPower * 2;
            Up++;
            UpdateUI();
        }
        if (count >= 50 && Up == 1)
        { // Ok pour ce PowerUp ci.
            click.goldPerClick += (50 * clickPower);
            clickPower = clickPower * 2;
            Up++;
            UpdateUI();
        }
        if (count >= 100 && Up == 2)
        { // Ok pour ce PowerUp ci.
            click.goldPerClick += (100 * clickPower);
            clickPower = clickPower * 2;
            Up++;
            UpdateUI();
        }
        if (count >= 200 && Up == 3)
        { // Ok pour ce PowerUp ci.
            click.goldPerClick += (200 * clickPower);
            clickPower = clickPower * 2;
            Up++;
            UpdateUI();
        }
        if (count >= 300 && Up == 4)
        { // Ok pour ce PowerUp ci.
            click.goldPerClick += (300 * clickPower);
            clickPower = clickPower * 2;
            Up++;
            UpdateUI();
        }
        if (count >= 400 && Up == 5)
        { // Ok pour ce PowerUp ci.
            click.goldPerClick += (400 * clickPower);
            clickPower = clickPower * 2;
            Up++;
            UpdateUI();
        }
        if (count >= 500 && Up == 6)
        { // Ok pour ce PowerUp ci.
            click.goldPerClick += (500 * clickPower);
            clickPower = clickPower * 2;
            Up++;
            UpdateUI();
        }
    }
}

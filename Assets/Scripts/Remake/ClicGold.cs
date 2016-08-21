using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClicGold : MonoBehaviour {

    /* Text UI */
    private GameObject canvas;
    private Text goldPerClic;
    private Text goldDisplay;
    private Text goldDisplayTop;
    /**/

    /* Values */
    public float gold = 0.00f;
    public float goldPerClick = 1f;
    /**/

    void Start ()
    {
        LinkingObjects();
    }
	
	void Update ()
    {
        UI();
    }

    public void LinkingObjects()
    {
        canvas = GameObject.Find("Canvas");
        goldPerClic = canvas.transform.FindChild("Panel OnClicked TAP/Panel/TapSecond/TapSecond Text").GetComponent<Text>();
        goldDisplay = canvas.transform.FindChild("Panel OnClicked TAP/Panel/TapSecond/Gold Text").GetComponent<Text>();
        goldDisplayTop = canvas.transform.FindChild("Panel Level and Gold/gold text").GetComponent<Text>();
    }

    public void UI()
    {
        goldDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false, false) + " : Gold ";
        goldDisplayTop.text = "Gold : " + CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false, false);
        goldPerClic.text = " Gold / Clic : " + CurrencyConverter.Instance.GetCurrencyIntoString(goldPerClick, false, false, false);
    }

    public void Clicked()
    {
        gold += goldPerClick;
    }
}

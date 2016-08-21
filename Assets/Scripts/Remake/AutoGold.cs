using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoGold : MonoBehaviour {

    private GameObject canvas;
    private Text goldPerSecondDisplay;
    private ClicGold click;
    public int countItems;
    private AutoItems itemLink;
    private Transform parentItems;
    public AutoItems[] items;

    public float tick = 0;

	void Start ()
    {
        LinkingObjects();
        Application.runInBackground = true;
        StartCoroutine(AutoTick());
    }
	
	void Update ()
    {
        UI();
	}

    public void LinkingObjects()
    {
        canvas = GameObject.Find("Canvas");
        click = canvas.transform.FindChild("Clic2").GetComponent<ClicGold>();
        goldPerSecondDisplay = canvas.transform.FindChild("Panel OnClicked AutoClic/Panel Down (1)/AutoClic Button/AutoClic Text").GetComponent<Text>();

        parentItems = canvas.transform.FindChild("Panel OnClicked AutoClic/AutoClic/Contenu");
        countItems = parentItems.childCount;
        items = new AutoItems[countItems];
        
        for(int i=0;i<countItems;i++)
        {
            print("Upgrade" + i + "/Upgrade Button");
            itemLink = parentItems.transform.FindChild("Upgrade"+i+ "/Upgrade Button").GetComponent<AutoItems>();
            items.SetValue(itemLink, i);
        }
    }

    public void UI()
    {
        goldPerSecondDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(tick, false, false, false) + " C/s";
    }

    public void AutoGoldPerSec()
    {
        tick = 0;
        for (int j=0;j<countItems;j++)
        {
            tick += (items[j].count * items[j].tickValue);
        }
        click.gold += tick / 10;
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoGoldPerSec();
            yield return new WaitForSeconds(0.10f);
        }
    }
}

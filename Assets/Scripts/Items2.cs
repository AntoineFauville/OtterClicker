using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Items2 : MonoBehaviour {

	public UnityEngine.UI.Text itemInfo;
	public UnityEngine.UI.Text countInfo;
	public Click click;
	public float cost;
	public float tickValue;
	public float count;
	public string itemName;
	public Color standart;
	public Color affordable;
	public float baseCost;
	public Image button;
	public GameObject unlockNext;


	public float Power;

	private int i;
	private float MultipleCost10X;
	private int Flag10X = 0;
	private float MultipleCost25X;
	private int Flag25X = 0;
	private float MultipleCost100X;
	private int Flag100X = 0;

	//public int Flag = 0;

	// Use this for initialization
	void Start () {
		baseCost = cost;
		Power = tickValue;
		unlockNext.SetActive(false);

		itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN"+ "\nPuissance : " + CurrencyConverter.Instance.GetCurrencyIntoString(tickValue, false, false, false) + " C/s";
		countInfo.text = count.ToString ("F0");
	}
	
	// Update is called once per frame
	void Update () {
		if (click.gold >= cost) {
			GetComponent<Image> ().color = affordable;
			unlockNext.SetActive (true);

		} else {
			GetComponent<Image> ().color = standart;
		}

		if (count <= 0) {
			button.color = standart;
		} else {
			button.color = affordable;
		}
	}
	
	public void PurchasedItem(){
		if (click.gold >= MultipleCost10X && Flag10X == 1) { // fonctionne mais il faut prendre en compte le prix des dix exemplaires !!!
			click.gold -= MultipleCost10X;
			count += 10;
			cost = baseCost * Mathf.Pow (1.09f, count);
			tickValue = (Mathf.Round (Mathf.Pow (1.05f, count))) * Power;// puissance de 1.05 de base modif pour test
			tickValue = tickValue + ((tickValue / 100));
		}
	}
}
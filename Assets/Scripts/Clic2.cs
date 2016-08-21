using UnityEngine;
using System.Collections;

public class Clic2 : MonoBehaviour {

	public UnityEngine.UI.Text gpc;
	public UnityEngine.UI.Text goldDisplay;
	public UnityEngine.UI.Text goldDisplayTop;
	public float gold = 0.00f;
//	public float goldPerleaf = 0.1f;
	public float goldPerClick = 1f;
//	public float goldPerLeafBegginning = 5f;

	public int Flag = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		goldDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false, false) + " : Gold ";
		goldDisplayTop.text = "Gold : " + CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false, false);
		gpc.text = " Gold / Clic : " + CurrencyConverter.Instance.GetCurrencyIntoString(goldPerClick, false, false, false);

		if (goldPerClick >= 2 && Flag == 0) {
			Flag++;
		}
		if (goldPerClick >= 100 && Flag == 1) {
			Flag++;
		} 
		if (goldPerClick >= 1000 && Flag == 2) {
			Flag++;
		} 
		if (goldPerClick >= 10000 && Flag == 3) {
			Flag++;
		}
		if (goldPerClick >= 1000000 && Flag == 4) {
			Flag++;
		}
	}

	public void Clicked ()
    {
		gold += goldPerClick;
		//anim.GetComponent<Animation>().Play ("AttackClic");
	}
}

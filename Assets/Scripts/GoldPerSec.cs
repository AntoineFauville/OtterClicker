using UnityEngine;
using System.Collections;

public class GoldPerSec : MonoBehaviour {

	public UnityEngine.UI.Text gpsDisplay;
	public Click click;
	public Items[] items;

	public float tick = 0; // Modif

	//achievement
	
	public GameObject fleche;
	
	public GameObject One;
	public GameObject Two;
	public GameObject Three;
	public GameObject Four;
	public GameObject Five;
	
	public int Flag = 0;

	void Start ()
    {
		StartCoroutine (AutoTick ());
		One.SetActive(false);
		Two.SetActive(false);
		Three.SetActive(false);
		Four.SetActive(false);
		Five.SetActive(false);
		fleche.SetActive (false);

		Application.runInBackground = true; // Faire fonctionner le goldpersecond meme sans focus .
	}

	void Update () {
		//gpsDisplay.text = /*GetGoldPerSec ()*/ tick + " C/s";
		gpsDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(tick, false, false, false) + " C/s";

		if (tick >= 2 && Flag == 0) {
			One.SetActive (true);
			fleche.SetActive (true);
			Flag++;
		}
		if (tick >= 100 && Flag == 1) {
			Two.SetActive (true);
			fleche.SetActive (true);
			Flag++;
		} 
		if (tick >= 1000 && Flag == 2) {
			Three.SetActive (true);
			fleche.SetActive (true);
			Flag++;
		} 
		if (tick >= 10000 && Flag == 3) {
			Four.SetActive (true);
			fleche.SetActive (true);
			Flag++;
		}
		if (tick >= 1000000 && Flag == 4) {
			Five.SetActive(true);
			fleche.SetActive (true);
			Flag++;
		}
	}

	public float GetGoldPerSec()
    {
		tick = 0; // modif création variable float tick = 0;
		foreach (Items item in items) {
			tick += item.count * item.tickValue;
		}
		return tick;
	}

	public void AutoGoldPerSec()
    {
		click.gold += GetGoldPerSec() / 10;
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

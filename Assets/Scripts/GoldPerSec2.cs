using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoldPerSec2 : MonoBehaviour {

	public Text gpsDisplay;
	public Clic2 clic2;
	public Items[] items;

	public int Flag = 0;

	public float tick = 0; // Modif

	// Use this for initialization
	void Start () {
		Application.runInBackground = true; // Faire fonctionner le goldpersecond meme sans focus .
	}
	
	// Update is called once per frame
	void Update ()
    {
		//gpsDisplay.text = /*GetGoldPerSec ()*/ tick + " C/s";
		gpsDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(tick, false, false, false) + " C/s";

		if (tick >= 2 && Flag == 0) {
			Flag++;
		}
		if (tick >= 100 && Flag == 1) {
			Flag++;
		} 
		if (tick >= 1000 && Flag == 2) {
			Flag++;
		} 
		if (tick >= 10000 && Flag == 3) {
			Flag++;
		}
		if (tick >= 1000000 && Flag == 4) {
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

	public void AutoGoldPerSec ()
    {
		clic2.gold += GetGoldPerSec () / 10;
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

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Click : MonoBehaviour {

    private GameObject canvas;

	private Text gpc;
    private Text goldDisplay;
	public float gold = 0.00f;
	public float goldPerleaf = 0.1f;
	public float goldPerClick = 1f;
	public float goldPerLeafBegginning = 5f;

	//public GameObject anim;

	//achievement

	public GameObject fleche;

	public GameObject One;
	public GameObject Two;
	public GameObject Three;
	public GameObject Four;
	public GameObject Five;

	private int Flag = 0;

	void Start ()
    {
        LinkingObjects();

        One.SetActive(false);
		Two.SetActive(false);
		Three.SetActive(false);
		Four.SetActive(false);
		Five.SetActive(false);
		fleche.SetActive (false);
	} 

	void Update () {
		goldDisplay.text = "Castor Tue : " + CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false, false);
		gpc.text = CurrencyConverter.Instance.GetCurrencyIntoString(goldPerClick, false, false, false) + " C/c";

		if (goldPerClick >= 2 && Flag == 0) {
			One.SetActive (true);
			fleche.SetActive (true);
			Flag++;
		}
		if (goldPerClick >= 100 && Flag == 1) {
			Two.SetActive (true);
			fleche.SetActive (true);
			Flag++;
		} 
		if (goldPerClick >= 1000 && Flag == 2) {
			Three.SetActive (true);
			fleche.SetActive (true);
			Flag++;
		} 
		if (goldPerClick >= 10000 && Flag == 3) {
			Four.SetActive (true);
			fleche.SetActive (true);
			Flag++;
		}
		if (goldPerClick >= 1000000 && Flag == 4) {
			Five.SetActive(true);
			fleche.SetActive (true);
			Flag++;
		}
		//anim.GetComponent<Animation> ().Play ("IdleTete");
	}

    public void LinkingObjects()
    {
        canvas = GameObject.Find("Canvas Main");
        gpc = canvas.transform.FindChild("CastorParClick").FindChild("Text").GetComponent<Text>();
        goldDisplay = canvas.transform.FindChild("CastorTué").GetComponent<Text>();
    }

	public void Clicked ()
    {
		gold += goldPerClick;
		//anim.GetComponent<Animation>().Play ("AttackClic");
	}
	public void Leafed ()
    {
		gold += goldPerClick*goldPerleaf;
		//anim.GetComponent<Animation>().Play ("AttackClic");
	}
	public void ClickedLeafBeggining ()
    {
		gold += goldPerLeafBegginning;
		//anim.GetComponent<Animation>().Play ("AttackClic");
	}

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackInLoutreTime : MonoBehaviour {

	public float ClicPourcent;
	public float SecondePourcent;
	public bool BackAllowed = false;
	public GameObject ClicUp;
	public GameObject SecondeUp;
	public UnityEngine.UI.Text clicinfo;
	public UnityEngine.UI.Text secondeinfo;

	public SaveLoad softReset;
	public Items item;

	void Start()
	{
		ClicUp.SetActive(false);
		SecondeUp.SetActive(false);
		clicinfo.text = ClicPourcent.ToString () + " %";
		secondeinfo.text = SecondePourcent.ToString () + " %";
	}

	void Update () 
	{
		if (item.count >= 1) 
		{
			BackAllowed = true;

			if (BackAllowed == true) 
			{
				ClicUp.SetActive(true);
				SecondeUp.SetActive(true);
				BackAllowed = false;
			}
		}
	}

	public void PowerClic()
	{
		ClicPourcent = ClicPourcent + 5;
		softReset.SoftReset ();
		ClicUp.SetActive(false);
		SecondeUp.SetActive(false);
		clicinfo.text = ClicPourcent.ToString () + " %";
		secondeinfo.text = SecondePourcent.ToString () + " %";
	}

	public void PowerSeconde()
	{
		SecondePourcent = SecondePourcent + 1;
		softReset.SoftReset ();
		ClicUp.SetActive(false);
		SecondeUp.SetActive(false);
		clicinfo.text = ClicPourcent.ToString () + " %";
		secondeinfo.text = SecondePourcent.ToString () + " %";
	}
}

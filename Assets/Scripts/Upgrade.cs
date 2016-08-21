using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public UnityEngine.UI.Text countInfo;
	public float cost;
	public float count = 0;
	public float clickPower;
	public float baseClickPower;
	public string itemName;
	public Color standart;
	public Color affordable;
	public Image button;
	public GameObject unlockNext;
	public BackInLoutreTime back;

	public GameObject Rotate;

    // particules

    public Rigidbody particulePrefab;
    public Transform SpawnParticulePrefab;
    public float SpeedSpawn;

    private bool particuleP = false;

    // PowerUp

    public int Up = 0;
	public float Power = 1.09f;

	// Multiple Buy

	private int i;
	private float MultipleCost10X;
	private int Flag10X = 0;
	private float MultipleCost25X;
	private int Flag25X = 0;
	private float MultipleCost100X;
	private int Flag100X = 0;

	//achievement
	
	public GameObject One;
	public GameObject Two;
	public GameObject Three;
	public GameObject Four;
	public GameObject Five;

    // New look for my booty

    public GameObject NewLookDamIt;

    public int Flag = 0;

	private float baseCost;

	void Start ()
    {
		baseCost = cost;
		baseClickPower = clickPower;
		unlockNext.SetActive(false);

		Rotate.SetActive (false);

		One.SetActive(false);
		Two.SetActive(false);
		Three.SetActive(false);
		Four.SetActive(false);
		Five.SetActive(false);

        particuleP = false;

        NewLookDamIt.SetActive(false);

        itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(clickPower, false, false, false) + " C/c";
		countInfo.text = count.ToString ("F0");
	}

	void Update (){

		if(click.gold >= cost ){
			GetComponent<Image>().color = affordable;
            particuleP = true;
			unlockNext.SetActive(true);
            
			if (Flag10X == 1)
			{
				if (click.gold >= MultipleCost10X)
				{
					GetComponent<Image>().color = affordable;
				} else
				{
					GetComponent<Image>().color = standart;
				}
			}
			else if (Flag25X == 1)
			{
				if (click.gold >= MultipleCost25X)
				{
					GetComponent<Image>().color = affordable;
				} else
				{
					GetComponent<Image>().color = standart;
				}
			}
			else if (Flag100X == 1)
			{
				if (click.gold >= MultipleCost100X)
				{
					GetComponent<Image>().color = affordable;
				} else
				{
					GetComponent<Image>().color = standart;
				}
			}

		}else{
			GetComponent<Image>().color = standart;
		}

		if (count <= 0) {
			button.color = standart;
		} else {
			button.color = affordable;
		}

		//achievement

		if (count >= 1 && Flag == 0) {
			One.SetActive (true);
			Rotate.SetActive(true);
			Flag++;
		}else if (count >= 10 && Flag == 1) {
			Two.SetActive (true);
			Flag++;
		}else if (count >= 50 && Flag == 2) {
			Three.SetActive (true);
			Flag++;
		}else if (count >= 100 && Flag == 3) {
			Four.SetActive (true);
			Flag++;
            NewLookDamIt.SetActive(true);
        }
        else if (count >= 500 && Flag == 4) {
			Five.SetActive (true);
			Flag++;
		}

		// PowerUp

		PowerUp ();

		// Multiple Buy

		if (Input.GetKeyDown ("left alt")) {
			// Calcul du prix des 10 objets pour le multiple buy
			MultipleCost10X = 0;
			for (i=0; i<10; i++) 
			{
				MultipleCost10X += baseCost * Mathf.Pow (1.09f, (count+i));
			}

			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost10X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
			Flag10X = 1;
		}

		if (Input.GetKeyDown ("left ctrl")) {
			// Calcul du prix des 25 objets pour le multiple buy
			MultipleCost25X = 0;
			for (i=0; i<25; i++) 
			{
				MultipleCost25X += baseCost * Mathf.Pow (1.09f, (count+i));
			}
			
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost25X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
			Flag25X = 1;
		}

		if (Input.GetKeyDown ("left shift")) {
			// Calcul du prix des 100 objets pour le multiple buy
			MultipleCost100X = 0;
			for (i=0; i<100; i++) 
			{
				MultipleCost100X += baseCost * Mathf.Pow (1.09f, (count+i));
			}
			
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost100X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
			Flag100X = 1;
		}

		if (Input.GetKeyUp("left shift"))
		{
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
			Flag100X = 0;
		}

		if (Input.GetKeyUp("left ctrl"))
		{
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
			Flag25X = 0;
		}


		if (Input.GetKeyUp("left alt"))
		{
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
			Flag10X = 0;
		}
	}

	public void PurchasedUpgrade(){

		if (click.gold >= MultipleCost10X && Flag10X == 1) {
			click.gold -= MultipleCost10X;
			count += 10;
			click.goldPerClick += ((clickPower*10) + ((clickPower/100) * back.ClicPourcent));
			cost = baseCost * Mathf.Pow (1.09f, count);
		}

		else if (click.gold >= MultipleCost25X && Flag25X == 1) {
			click.gold -= MultipleCost25X;
			count += 25;
			click.goldPerClick += ((clickPower*25) + ((clickPower/100) * back.ClicPourcent));
			cost = baseCost * Mathf.Pow (1.09f, count);
		}

		else if (click.gold >= MultipleCost100X && Flag100X == 1) { 
			click.gold -= MultipleCost100X;
			count += 100;
			click.goldPerClick += ((clickPower*100) + ((clickPower/100) * back.ClicPourcent));
			cost = baseCost * Mathf.Pow (1.09f, count);
		}

		else if (click.gold >= cost && Flag10X == 0 && Flag25X == 0 && Flag100X == 0)  
		{
			click.gold -= cost;
			count += 1;
			click.goldPerClick += (clickPower + ((clickPower/100) * back.ClicPourcent));
			cost = baseCost * Mathf.Pow (1.09f, count);
		}

		if (Flag10X == 1) {
			MultipleCost10X = 0;
			for (i=0; i<10; i++) 
			{
				MultipleCost10X += baseCost * Mathf.Pow (1.09f, (count+i));
			}
			
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost10X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
		} else if (Flag25X == 1) {
			MultipleCost25X = 0;
			for (i=0; i<25; i++) 
			{
				MultipleCost25X += baseCost * Mathf.Pow (1.09f, (count+i));
			}
			
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost25X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
		} else if (Flag100X == 1) {
			MultipleCost100X = 0;
			for (i=0; i<100; i++) 
			{
				MultipleCost100X += baseCost * Mathf.Pow (1.09f, (count+i));
			}
			
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost100X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
		} else 
		{
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (clickPower, false, false, false) + " C/c";
			countInfo.text = count.ToString ("F0");
		}
	}

	public void MAJ()
	{
		itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (clickPower, false, false, false) + " C/c";
		countInfo.text = count.ToString ("F0");
	}

	/*public void Reset()
	{
		itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (baseClickPower, false, false, false) + " C/c";
		countInfo.text = count.ToString ("F0");
		unlockNext.SetActive (false);
		Rotate.SetActive (false);
		One.SetActive(false);
		Two.SetActive(false);
		Three.SetActive(false);
		Four.SetActive(false);
		Five.SetActive(false);
	}*/

	public void PowerUp(){ // Permets de doubler la puissance des degats des armes par tranche de niveau :) 
		if (count >= 10 && Up == 0) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (10*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 50 && Up == 1) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (50*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 100 && Up == 2) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (100*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 200 && Up == 3) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (200*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 300 && Up == 4) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (300*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 400 && Up == 5) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (400*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
		if (count >= 500 && Up == 6) { // Ok pour ce PowerUp ci.
			click.goldPerClick += (500*clickPower);
			clickPower = clickPower*2;
			Up++;
		}
	}

    public void OnClic()
    {
        if (particuleP == true)
        {
            Rigidbody praticuleInstance;
            praticuleInstance = Instantiate(particulePrefab, SpawnParticulePrefab.position, SpawnParticulePrefab.rotation) as Rigidbody;
            praticuleInstance.AddForce(SpawnParticulePrefab.forward * SpeedSpawn);
        }
    }
}

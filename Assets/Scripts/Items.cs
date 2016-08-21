using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Items : MonoBehaviour {

	public Text itemInfo;
	public Text countInfo;
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
	public BackInLoutreTime back;

    // particules

    public Rigidbody particulePrefab;
    public Transform SpawnParticulePrefab;
    public float SpeedSpawn;

    private bool particuleP = false;

    // PowerUp

    public float Power;

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

	public int Flag = 0;

	void Start ()
    {
		baseCost = cost;
		Power = tickValue;
		unlockNext.SetActive(false);

        particuleP = false;

        One.SetActive(false);
		Two.SetActive(false);
		Three.SetActive(false);
		Four.SetActive(false);
		Five.SetActive(false);

		itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN"+ "\nPuissance : " + CurrencyConverter.Instance.GetCurrencyIntoString(tickValue, false, false, false) + " C/s";
		countInfo.text = count.ToString ("F0");

	}

	void Update ()
    {
	
		if(click.gold >= cost )
        {
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

		if (count >= 1 && Flag == 0) {
			One.SetActive (true);
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
		}else if (count >= 500 && Flag == 4) {
			Five.SetActive (true);
			Flag++;
		}

		// Multiple Buy
		
		if (Input.GetKeyDown ("left alt")) {
			// Calcul du prix des 10 objets pour le multiple buy
			MultipleCost10X = 0;
			for (i=0; i<10; i++) 
			{
				MultipleCost10X += baseCost * Mathf.Pow (1.09f, (count+i));
			}
			
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost10X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (tickValue, false, false, false) + " C/s";
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
			
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost25X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (tickValue, false, false, false) + " C/s";
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
			
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost100X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (tickValue, false, false, false) + " C/s";
			countInfo.text = count.ToString ("F0");
			Flag100X = 1;
		}
		
		if (Input.GetKeyUp("left shift"))
		{
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(tickValue, false, false, false) + " C/s";
			countInfo.text = count.ToString ("F0");
			Flag100X = 0;
		}
		
		if (Input.GetKeyUp("left ctrl"))
		{
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(tickValue, false, false, false) + " C/s";
			countInfo.text = count.ToString ("F0");
			Flag25X = 0;
		}
		
		
		if (Input.GetKeyUp("left alt"))
		{
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString(tickValue, false, false, false) + " C/s";
			countInfo.text = count.ToString ("F0");
			Flag10X = 0;
		}
	} 

	public void PurchasedItem()
    {
		if (click.gold >= MultipleCost10X && Flag10X == 1) { // fonctionne mais il faut prendre en compte le prix des dix exemplaires !!!
			click.gold -= MultipleCost10X;
			count += 10;
			cost = baseCost * Mathf.Pow (1.09f, count);
			tickValue = (Mathf.Round(Mathf.Pow(1.05f, count))) * Power;// puissance de 1.05 de base modif pour test
			tickValue = tickValue + ( (tickValue/100) * back.SecondePourcent);
		}

		else if (click.gold >= MultipleCost25X && Flag25X == 1) {
			click.gold -= MultipleCost25X;
			count += 25;
			cost = baseCost * Mathf.Pow (1.09f, count);
			tickValue = (Mathf.Round(Mathf.Pow(1.05f, count))) * Power;
			tickValue = tickValue + ( (tickValue/100) * back.SecondePourcent);
		}
		
		else if (click.gold >= MultipleCost100X && Flag100X == 1) { 
			click.gold -= MultipleCost100X;
			count += 100;
			cost = baseCost * Mathf.Pow (1.09f, count);
			tickValue = (Mathf.Round(Mathf.Pow(1.05f, count))) * Power;
			tickValue = tickValue + ( (tickValue/100) * back.SecondePourcent);
		}

		else if (click.gold >= cost && Flag10X == 0 && Flag25X == 0 && Flag100X == 0) {
			click.gold -= cost;
			count += 1;
			cost = Mathf.Round (baseCost * Mathf.Pow(1.09f, count));
			tickValue = (Mathf.Round (Mathf.Pow(1.05f, count))) * Power;
			tickValue = tickValue + ( (tickValue/100) * back.SecondePourcent);
		}

		if (Flag10X == 1) {
			MultipleCost10X = 0;
			for (i=0; i<10; i++) 
			{
				MultipleCost10X += baseCost * Mathf.Pow (1.09f, (count+i));
			}

			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost10X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (tickValue, false, false, false) + " C/s";
			countInfo.text = count.ToString ("F0");
		} else if (Flag25X == 1) {
			MultipleCost25X = 0;
			for (i=0; i<25; i++) 
			{
				MultipleCost25X += baseCost * Mathf.Pow (1.09f, (count+i));
			}

			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost25X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (tickValue, false, false, false) + " C/s";
			countInfo.text = count.ToString ("F0");
		} else if (Flag100X == 1) {
			MultipleCost100X = 0;
			for (i=0; i<100; i++) 
			{
				MultipleCost100X += baseCost * Mathf.Pow (1.09f, (count+i));
			}

			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (MultipleCost100X, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (tickValue, false, false, false) + " C/s";
			countInfo.text = count.ToString ("F0");
		} else 
		{
			itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (tickValue, false, false, false) + " C/s";
			countInfo.text = count.ToString ("F0");
		}


	}

	public void MAJ()
	{
		itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (tickValue, false, false, false) + " C/s";
		countInfo.text = count.ToString ("F0");
	}

	public void Reset()
	{
		itemInfo.text = itemName + "\nCout : " + CurrencyConverter.Instance.GetCurrencyIntoString (cost, false, false, false) + " CTN" + "\nPuissance : +" + CurrencyConverter.Instance.GetCurrencyIntoString (tickValue, false, false, false) + " C/s";
		countInfo.text = count.ToString ("F0");
		unlockNext.SetActive (false);
		One.SetActive(false);
		Two.SetActive(false);
		Three.SetActive(false);
		Four.SetActive(false);
		Five.SetActive(false);
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
using UnityEngine;
using System.Collections;

public class SaveLoad : MonoBehaviour {

	public Click click;
	public BackInLoutreTime back;

	public Items aide1;
	public Items aide2;
	public Items aide3;
	public Items aide4;
	public Items aide5;
	public Items aide6;
	public Items aide7;
	public Items aide8;
	public Items aide9;
	public Items aide10;
	public Items aide11;
	public Items aide12;
	public Items aide13;
	public Items aide14;
	public Items aide15;

	public Upgrade arme1;
	public Upgrade arme2;
	public Upgrade arme3;
	public Upgrade arme4;
	public Upgrade arme5;
	public Upgrade arme6;
	public Upgrade arme7;
	public Upgrade arme8;
	public Upgrade arme9;

	public void Save()
	{
		PlayerPrefs.SetFloat ("Money", click.gold);
		PlayerPrefs.SetFloat ("Damage", click.goldPerClick);
		PlayerPrefs.SetFloat ("ClicPourcent",back.ClicPourcent);
		PlayerPrefs.SetFloat ("SecondePourcent",back.SecondePourcent);
		// Stockage nbre aides
		PlayerPrefs.SetFloat ("Paysanne", aide1.count);
		PlayerPrefs.SetFloat ("Soldat", aide2.count);
		PlayerPrefs.SetFloat ("Minigun", aide3.count);
		PlayerPrefs.SetFloat ("Commando", aide4.count);
		PlayerPrefs.SetFloat ("BoB", aide5.count);
		PlayerPrefs.SetFloat ("Tank", aide6.count);
		PlayerPrefs.SetFloat ("Avion", aide7.count);
		PlayerPrefs.SetFloat ("Bombardier", aide8.count);
		PlayerPrefs.SetFloat ("Lanceur", aide9.count);
		PlayerPrefs.SetFloat ("Vaisseau", aide10.count);
		PlayerPrefs.SetFloat ("Aneantisseur", aide11.count);
		PlayerPrefs.SetFloat ("Atomique", aide12.count);
		PlayerPrefs.SetFloat ("Station", aide13.count);
		PlayerPrefs.SetFloat ("Destructeur", aide14.count);
		PlayerPrefs.SetFloat ("Dark", aide15.count);
		//Stockage prix aide 
		PlayerPrefs.SetFloat ("costPaysanne", aide1.cost);
		PlayerPrefs.SetFloat ("costSoldat", aide2.cost);
		PlayerPrefs.SetFloat ("costMinigun", aide3.cost);
		PlayerPrefs.SetFloat ("costCommando", aide4.cost);
		PlayerPrefs.SetFloat ("costBoB", aide5.cost);
		PlayerPrefs.SetFloat ("costTank", aide6.cost);
		PlayerPrefs.SetFloat ("costAvion", aide7.cost);
		PlayerPrefs.SetFloat ("costBombardier", aide8.cost);
		PlayerPrefs.SetFloat ("costLanceur", aide9.cost);
		PlayerPrefs.SetFloat ("costVaisseau", aide10.cost);
		PlayerPrefs.SetFloat ("costAneantisseur", aide11.cost);
		PlayerPrefs.SetFloat ("costAtomique", aide12.cost);
		PlayerPrefs.SetFloat ("costStation", aide13.cost);
		PlayerPrefs.SetFloat ("costDestructeur", aide14.cost);
		PlayerPrefs.SetFloat ("costDark", aide15.cost);
		//Stockage nbre arme
		PlayerPrefs.SetFloat ("Poing", arme1.count);
		PlayerPrefs.SetFloat ("Couteau", arme2.count);
		PlayerPrefs.SetFloat ("Machette", arme3.count);
		PlayerPrefs.SetFloat ("Fusil", arme4.count);
		PlayerPrefs.SetFloat ("Mitraillette", arme5.count);
		PlayerPrefs.SetFloat ("Bazooka", arme6.count);
		PlayerPrefs.SetFloat ("Canon", arme7.count);
		PlayerPrefs.SetFloat ("Armure", arme8.count);
		PlayerPrefs.SetFloat ("Maggie", arme9.count);
		//Stockage prix arme
		PlayerPrefs.SetFloat ("costPoing", arme1.cost);
		PlayerPrefs.SetFloat ("costCouteau", arme2.cost);
		PlayerPrefs.SetFloat ("costMachette", arme3.cost);
		PlayerPrefs.SetFloat ("costFusil", arme4.cost);
		PlayerPrefs.SetFloat ("costMitraillette", arme5.cost);
		PlayerPrefs.SetFloat ("costBazooka", arme6.cost);
		PlayerPrefs.SetFloat ("costCanon", arme7.cost);
		PlayerPrefs.SetFloat ("costArmure", arme8.cost);
		PlayerPrefs.SetFloat ("costMaggie", arme9.cost);

		print("Save Done");
	}

	public void Load()
	{
		click.gold = PlayerPrefs.GetFloat ("Money");
		click.goldPerClick = PlayerPrefs.GetFloat ("Damage");
		back.ClicPourcent = PlayerPrefs.GetFloat ("ClicPourcent");
		back.SecondePourcent = PlayerPrefs.GetFloat ("SecondePourcent");

		aide1.count = PlayerPrefs.GetFloat ("Paysanne");
		aide2.count = PlayerPrefs.GetFloat ("Soldat");
		aide3.count = PlayerPrefs.GetFloat ("Minigun");
		aide4.count = PlayerPrefs.GetFloat ("Commando");
		aide5.count = PlayerPrefs.GetFloat ("BoB");
		aide6.count = PlayerPrefs.GetFloat ("Tank");
		aide7.count = PlayerPrefs.GetFloat ("Avion");
		aide8.count = PlayerPrefs.GetFloat ("Bombardier");
		aide9.count = PlayerPrefs.GetFloat ("Lanceur");
		aide10.count = PlayerPrefs.GetFloat ("Vaisseau");
		aide11.count = PlayerPrefs.GetFloat ("Aneantisseur");
		aide12.count = PlayerPrefs.GetFloat ("Atomique");
		aide13.count = PlayerPrefs.GetFloat ("Station");
		aide14.count = PlayerPrefs.GetFloat ("Destructeur");
		aide15.count = PlayerPrefs.GetFloat ("Dark");

		aide1.cost = PlayerPrefs.GetFloat ("costPaysanne");
		aide2.cost = PlayerPrefs.GetFloat ("costSoldat");
		aide3.cost = PlayerPrefs.GetFloat ("costMinigun");
		aide4.cost = PlayerPrefs.GetFloat ("costCommando");
		aide5.cost = PlayerPrefs.GetFloat ("costBoB");
		aide6.cost = PlayerPrefs.GetFloat ("costTank");
		aide7.cost = PlayerPrefs.GetFloat ("costAvion");
		aide8.cost = PlayerPrefs.GetFloat ("costBombardier");
		aide9.cost = PlayerPrefs.GetFloat ("costLanceur");
		aide10.cost = PlayerPrefs.GetFloat ("costVaisseau");
		aide11.cost = PlayerPrefs.GetFloat ("costAneantisseur");
		aide12.cost = PlayerPrefs.GetFloat ("costAtomique");
		aide13.cost = PlayerPrefs.GetFloat ("costStation");
		aide14.cost = PlayerPrefs.GetFloat ("costDestructeur");
		aide15.cost = PlayerPrefs.GetFloat ("costDark");

		if (aide1.count >= 1) 
		{
			aide1.MAJ ();

			if (aide2.count >= 1) 
			{
				aide2.MAJ ();

				if (aide3.count >= 1) 
				{
					aide3.MAJ ();

					if (aide4.count >= 1) 
					{
						aide4.MAJ ();

						if (aide5.count >= 1) 
						{
							aide5.MAJ ();

							if (aide6.count >= 1) 
							{
								aide6.MAJ ();

								if (aide7.count >= 1) 
								{
									aide7.MAJ ();

									if (aide8.count >= 1) 
									{
										aide8.MAJ ();

										if (aide9.count >= 1) 
										{
											aide9.MAJ ();

											if (aide10.count >= 1) 
											{
												aide10.MAJ ();

												if (aide11.count >= 1) 
												{
													aide11.MAJ ();

													if (aide12.count >= 1) 
													{
														aide12.MAJ ();

														if (aide13.count >= 1) 
														{
															aide13.MAJ ();

															if (aide14.count >= 1) 
															{
																aide14.MAJ ();

																if (aide15.count >= 1) 
																{
																	aide15.MAJ ();
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		arme1.count = PlayerPrefs.GetFloat ("Poing");
		arme2.count = PlayerPrefs.GetFloat ("Couteau");
		arme3.count = PlayerPrefs.GetFloat ("Machette");
		arme4.count = PlayerPrefs.GetFloat ("Fusil");
		arme5.count = PlayerPrefs.GetFloat ("Mitraillette");
		arme6.count = PlayerPrefs.GetFloat ("Bazooka");
		arme7.count = PlayerPrefs.GetFloat ("Canon");
		arme8.count = PlayerPrefs.GetFloat ("Armure");
		arme9.count = PlayerPrefs.GetFloat ("Maggie");

		arme1.cost = PlayerPrefs.GetFloat ("costPoing");
		arme2.cost = PlayerPrefs.GetFloat ("costCouteau");
		arme3.cost = PlayerPrefs.GetFloat ("costMachette");
		arme4.cost = PlayerPrefs.GetFloat ("costFusil");
		arme5.cost = PlayerPrefs.GetFloat ("costMitraillette");
		arme6.cost = PlayerPrefs.GetFloat ("costBazooka");
		arme7.cost = PlayerPrefs.GetFloat ("costCanon");
		arme8.cost = PlayerPrefs.GetFloat ("costArmure");
		arme9.cost = PlayerPrefs.GetFloat ("costMaggie");

		if (arme1.count >= 1) 
		{
			arme1.MAJ ();

			if (arme2.count >= 1) 
			{
				arme2.MAJ ();

				if (arme3.count >= 1) 
				{
					arme3.MAJ ();

					if (arme4.count >= 1) 
					{
						arme4.MAJ ();

						if (arme5.count >= 1) 
						{
							arme5.MAJ ();

							if (arme6.count >= 1) 
							{
								arme6.MAJ ();

								if (arme7.count >= 1) 
								{
									arme7.MAJ ();

									if (arme8.count >= 1) 
									{
										arme8.MAJ ();

										if (arme9.count >= 1) 
										{
											arme9.MAJ ();
										}
									}
								}
							}
						}
					}
				}
			}
		}


		print("Load Done");
	}

	public void Reset()
	{
		PlayerPrefs.SetFloat ("Money", 0);
		PlayerPrefs.SetFloat ("Damage", 1);
		PlayerPrefs.SetFloat ("ClicPourcent",0);
		PlayerPrefs.SetFloat ("SecondePourcent",0);
		// Stockage nbre aides
		PlayerPrefs.SetFloat ("Paysanne", 0);
		PlayerPrefs.SetFloat ("Soldat", 0);
		PlayerPrefs.SetFloat ("Minigun", 0);
		PlayerPrefs.SetFloat ("Commando", 0);
		PlayerPrefs.SetFloat ("BoB", 0);
		PlayerPrefs.SetFloat ("Tank", 0);
		PlayerPrefs.SetFloat ("Avion", 0);
		PlayerPrefs.SetFloat ("Bombardier", 0);
		PlayerPrefs.SetFloat ("Lanceur", 0);
		PlayerPrefs.SetFloat ("Vaisseau", 0);
		PlayerPrefs.SetFloat ("Aneantisseur", 0);
		PlayerPrefs.SetFloat ("Atomique", 0);
		PlayerPrefs.SetFloat ("Station", 0);
		PlayerPrefs.SetFloat ("Destructeur", 0);
		PlayerPrefs.SetFloat ("Dark", 0);
		//Stockage prix aide 
		PlayerPrefs.SetFloat ("costPaysanne", 50);
		PlayerPrefs.SetFloat ("costSoldat", 175);
		PlayerPrefs.SetFloat ("costMinigun", 674);
		PlayerPrefs.SetFloat ("costCommando", 2850);
		PlayerPrefs.SetFloat ("costBoB", 13300);
		PlayerPrefs.SetFloat ("costTank", 68100);
		PlayerPrefs.SetFloat ("costAvion", 384000);
		PlayerPrefs.SetFloat ("costBombardier", 2380000);
		PlayerPrefs.SetFloat ("costLanceur", 2.38e+07f);
		PlayerPrefs.SetFloat ("costVaisseau", 1.43e+08f);
		PlayerPrefs.SetFloat ("costAneantisseur", 9.43e+08f);
		PlayerPrefs.SetFloat ("costAtomique", 6.84e+09f);
		PlayerPrefs.SetFloat ("costStation", 5.47e+10f);
		PlayerPrefs.SetFloat ("costDestructeur", 8.2e+11f);
		PlayerPrefs.SetFloat ("costDark", 8.2e+12f);
		//Stockage nbre arme
		PlayerPrefs.SetFloat ("Poing", 0);
		PlayerPrefs.SetFloat ("Couteau", 0);
		PlayerPrefs.SetFloat ("Machette", 0);
		PlayerPrefs.SetFloat ("Fusil", 0);
		PlayerPrefs.SetFloat ("Mitraillette", 0);
		PlayerPrefs.SetFloat ("Bazooka", 0);
		PlayerPrefs.SetFloat ("Canon", 0);
		PlayerPrefs.SetFloat ("Armure", 0);
		PlayerPrefs.SetFloat ("Maggie", 0);
		//Stockage prix arme
		PlayerPrefs.SetFloat ("costPoing", 5);
		PlayerPrefs.SetFloat ("costCouteau", 20);
		PlayerPrefs.SetFloat ("costMachette", 100);
		PlayerPrefs.SetFloat ("costFusil", 500);
		PlayerPrefs.SetFloat ("costMitraillette", 3000);
		PlayerPrefs.SetFloat ("costBazooka", 10000);
		PlayerPrefs.SetFloat ("costCanon", 40000);
		PlayerPrefs.SetFloat ("costArmure", 300000);
		PlayerPrefs.SetFloat ("costMaggie", 1000000);

		click.gold = PlayerPrefs.GetFloat ("Money");
		click.goldPerClick = PlayerPrefs.GetFloat ("Damage");
		
		aide1.count = PlayerPrefs.GetFloat ("Paysanne");
		aide2.count = PlayerPrefs.GetFloat ("Soldat");
		aide3.count = PlayerPrefs.GetFloat ("Minigun");
		aide4.count = PlayerPrefs.GetFloat ("Commando");
		aide5.count = PlayerPrefs.GetFloat ("BoB");
		aide6.count = PlayerPrefs.GetFloat ("Tank");
		aide7.count = PlayerPrefs.GetFloat ("Avion");
		aide8.count = PlayerPrefs.GetFloat ("Bombardier");
		aide9.count = PlayerPrefs.GetFloat ("Lanceur");
		aide10.count = PlayerPrefs.GetFloat ("Vaisseau");
		aide11.count = PlayerPrefs.GetFloat ("Aneantisseur");
		aide12.count = PlayerPrefs.GetFloat ("Atomique");
		aide13.count = PlayerPrefs.GetFloat ("Station");
		aide14.count = PlayerPrefs.GetFloat ("Destructeur");
		aide15.count = PlayerPrefs.GetFloat ("Dark");
		
		aide1.cost = PlayerPrefs.GetFloat ("costPaysanne");
		aide2.cost = PlayerPrefs.GetFloat ("costSoldat");
		aide3.cost = PlayerPrefs.GetFloat ("costMinigun");
		aide4.cost = PlayerPrefs.GetFloat ("costCommando");
		aide5.cost = PlayerPrefs.GetFloat ("costBoB");
		aide6.cost = PlayerPrefs.GetFloat ("costTank");
		aide7.cost = PlayerPrefs.GetFloat ("costAvion");
		aide8.cost = PlayerPrefs.GetFloat ("costBombardier");
		aide9.cost = PlayerPrefs.GetFloat ("costLanceur");
		aide10.cost = PlayerPrefs.GetFloat ("costVaisseau");
		aide11.cost = PlayerPrefs.GetFloat ("costAneantisseur");
		aide12.cost = PlayerPrefs.GetFloat ("costAtomique");
		aide13.cost = PlayerPrefs.GetFloat ("costStation");
		aide14.cost = PlayerPrefs.GetFloat ("costDestructeur");
		aide15.cost = PlayerPrefs.GetFloat ("costDark");

		arme1.count = PlayerPrefs.GetFloat ("Poing");
		arme2.count = PlayerPrefs.GetFloat ("Couteau");
		arme3.count = PlayerPrefs.GetFloat ("Machette");
		arme4.count = PlayerPrefs.GetFloat ("Fusil");
		arme5.count = PlayerPrefs.GetFloat ("Mitraillette");
		arme6.count = PlayerPrefs.GetFloat ("Bazooka");
		arme7.count = PlayerPrefs.GetFloat ("Canon");
		arme8.count = PlayerPrefs.GetFloat ("Armure");
		arme9.count = PlayerPrefs.GetFloat ("Maggie");
		
		arme1.cost = PlayerPrefs.GetFloat ("costPoing");
		arme2.cost = PlayerPrefs.GetFloat ("costCouteau");
		arme3.cost = PlayerPrefs.GetFloat ("costMachette");
		arme4.cost = PlayerPrefs.GetFloat ("costFusil");
		arme5.cost = PlayerPrefs.GetFloat ("costMitraillette");
		arme6.cost = PlayerPrefs.GetFloat ("costBazooka");
		arme7.cost = PlayerPrefs.GetFloat ("costCanon");
		arme8.cost = PlayerPrefs.GetFloat ("costArmure");
		arme9.cost = PlayerPrefs.GetFloat ("costMaggie");

		aide15.Reset ();
		aide14.Reset ();
		aide13.Reset ();
		aide12.Reset ();
		aide11.Reset ();
		aide10.Reset ();
		aide9.Reset ();
		aide8.Reset ();
		aide7.Reset ();
		aide6.Reset ();
		aide5.Reset ();
		aide4.Reset ();
		aide3.Reset ();
		aide2.Reset ();
		aide1.Reset ();

		/*arme9.Reset ();
		arme8.Reset ();
		arme7.Reset ();
		arme6.Reset ();
		arme5.Reset ();
		arme4.Reset ();
		arme3.Reset ();
		arme2.Reset ();
		arme1.Reset ();*/

		print ("Reset Done");
	}

	public void SoftReset()
	{
		PlayerPrefs.SetFloat ("Money", 0);
		PlayerPrefs.SetFloat ("Damage", 1);
		// Stockage nbre aides
		PlayerPrefs.SetFloat ("Paysanne", 0);
		PlayerPrefs.SetFloat ("Soldat", 0);
		PlayerPrefs.SetFloat ("Minigun", 0);
		PlayerPrefs.SetFloat ("Commando", 0);
		PlayerPrefs.SetFloat ("BoB", 0);
		PlayerPrefs.SetFloat ("Tank", 0);
		PlayerPrefs.SetFloat ("Avion", 0);
		PlayerPrefs.SetFloat ("Bombardier", 0);
		PlayerPrefs.SetFloat ("Lanceur", 0);
		PlayerPrefs.SetFloat ("Vaisseau", 0);
		PlayerPrefs.SetFloat ("Aneantisseur", 0);
		PlayerPrefs.SetFloat ("Atomique", 0);
		PlayerPrefs.SetFloat ("Station", 0);
		PlayerPrefs.SetFloat ("Destructeur", 0);
		PlayerPrefs.SetFloat ("Dark", 0);
		//Stockage prix aide 
		PlayerPrefs.SetFloat ("costPaysanne", 50);
		PlayerPrefs.SetFloat ("costSoldat", 175);
		PlayerPrefs.SetFloat ("costMinigun", 674);
		PlayerPrefs.SetFloat ("costCommando", 2850);
		PlayerPrefs.SetFloat ("costBoB", 13300);
		PlayerPrefs.SetFloat ("costTank", 68100);
		PlayerPrefs.SetFloat ("costAvion", 384000);
		PlayerPrefs.SetFloat ("costBombardier", 2380000);
		PlayerPrefs.SetFloat ("costLanceur", 2.38e+07f);
		PlayerPrefs.SetFloat ("costVaisseau", 1.43e+08f);
		PlayerPrefs.SetFloat ("costAneantisseur", 9.43e+08f);
		PlayerPrefs.SetFloat ("costAtomique", 6.84e+09f);
		PlayerPrefs.SetFloat ("costStation", 5.47e+10f);
		PlayerPrefs.SetFloat ("costDestructeur", 8.2e+11f);
		PlayerPrefs.SetFloat ("costDark", 8.2e+12f);
		//Stockage nbre arme
		PlayerPrefs.SetFloat ("Poing", 0);
		PlayerPrefs.SetFloat ("Couteau", 0);
		PlayerPrefs.SetFloat ("Machette", 0);
		PlayerPrefs.SetFloat ("Fusil", 0);
		PlayerPrefs.SetFloat ("Mitraillette", 0);
		PlayerPrefs.SetFloat ("Bazooka", 0);
		PlayerPrefs.SetFloat ("Canon", 0);
		PlayerPrefs.SetFloat ("Armure", 0);
		PlayerPrefs.SetFloat ("Maggie", 0);
		//Stockage prix arme
		PlayerPrefs.SetFloat ("costPoing", 5);
		PlayerPrefs.SetFloat ("costCouteau", 20);
		PlayerPrefs.SetFloat ("costMachette", 100);
		PlayerPrefs.SetFloat ("costFusil", 500);
		PlayerPrefs.SetFloat ("costMitraillette", 3000);
		PlayerPrefs.SetFloat ("costBazooka", 10000);
		PlayerPrefs.SetFloat ("costCanon", 40000);
		PlayerPrefs.SetFloat ("costArmure", 300000);
		PlayerPrefs.SetFloat ("costMaggie", 1000000);
		
		click.gold = PlayerPrefs.GetFloat ("Money");
		click.goldPerClick = PlayerPrefs.GetFloat ("Damage");
		
		aide1.count = PlayerPrefs.GetFloat ("Paysanne");
		aide2.count = PlayerPrefs.GetFloat ("Soldat");
		aide3.count = PlayerPrefs.GetFloat ("Minigun");
		aide4.count = PlayerPrefs.GetFloat ("Commando");
		aide5.count = PlayerPrefs.GetFloat ("BoB");
		aide6.count = PlayerPrefs.GetFloat ("Tank");
		aide7.count = PlayerPrefs.GetFloat ("Avion");
		aide8.count = PlayerPrefs.GetFloat ("Bombardier");
		aide9.count = PlayerPrefs.GetFloat ("Lanceur");
		aide10.count = PlayerPrefs.GetFloat ("Vaisseau");
		aide11.count = PlayerPrefs.GetFloat ("Aneantisseur");
		aide12.count = PlayerPrefs.GetFloat ("Atomique");
		aide13.count = PlayerPrefs.GetFloat ("Station");
		aide14.count = PlayerPrefs.GetFloat ("Destructeur");
		aide15.count = PlayerPrefs.GetFloat ("Dark");
		
		aide1.cost = PlayerPrefs.GetFloat ("costPaysanne");
		aide2.cost = PlayerPrefs.GetFloat ("costSoldat");
		aide3.cost = PlayerPrefs.GetFloat ("costMinigun");
		aide4.cost = PlayerPrefs.GetFloat ("costCommando");
		aide5.cost = PlayerPrefs.GetFloat ("costBoB");
		aide6.cost = PlayerPrefs.GetFloat ("costTank");
		aide7.cost = PlayerPrefs.GetFloat ("costAvion");
		aide8.cost = PlayerPrefs.GetFloat ("costBombardier");
		aide9.cost = PlayerPrefs.GetFloat ("costLanceur");
		aide10.cost = PlayerPrefs.GetFloat ("costVaisseau");
		aide11.cost = PlayerPrefs.GetFloat ("costAneantisseur");
		aide12.cost = PlayerPrefs.GetFloat ("costAtomique");
		aide13.cost = PlayerPrefs.GetFloat ("costStation");
		aide14.cost = PlayerPrefs.GetFloat ("costDestructeur");
		aide15.cost = PlayerPrefs.GetFloat ("costDark");
		
		arme1.count = PlayerPrefs.GetFloat ("Poing");
		arme2.count = PlayerPrefs.GetFloat ("Couteau");
		arme3.count = PlayerPrefs.GetFloat ("Machette");
		arme4.count = PlayerPrefs.GetFloat ("Fusil");
		arme5.count = PlayerPrefs.GetFloat ("Mitraillette");
		arme6.count = PlayerPrefs.GetFloat ("Bazooka");
		arme7.count = PlayerPrefs.GetFloat ("Canon");
		arme8.count = PlayerPrefs.GetFloat ("Armure");
		arme9.count = PlayerPrefs.GetFloat ("Maggie");
		
		arme1.cost = PlayerPrefs.GetFloat ("costPoing");
		arme2.cost = PlayerPrefs.GetFloat ("costCouteau");
		arme3.cost = PlayerPrefs.GetFloat ("costMachette");
		arme4.cost = PlayerPrefs.GetFloat ("costFusil");
		arme5.cost = PlayerPrefs.GetFloat ("costMitraillette");
		arme6.cost = PlayerPrefs.GetFloat ("costBazooka");
		arme7.cost = PlayerPrefs.GetFloat ("costCanon");
		arme8.cost = PlayerPrefs.GetFloat ("costArmure");
		arme9.cost = PlayerPrefs.GetFloat ("costMaggie");
		
		aide15.Reset ();
		aide14.Reset ();
		aide13.Reset ();
		aide12.Reset ();
		aide11.Reset ();
		aide10.Reset ();
		aide9.Reset ();
		aide8.Reset ();
		aide7.Reset ();
		aide6.Reset ();
		aide5.Reset ();
		aide4.Reset ();
		aide3.Reset ();
		aide2.Reset ();
		aide1.Reset ();
		
		/*arme9.Reset ();
		arme8.Reset ();
		arme7.Reset ();
		arme6.Reset ();
		arme5.Reset ();
		arme4.Reset ();
		arme3.Reset ();
		arme2.Reset ();
		arme1.Reset ();*/
		
		print ("Reset Done");
	}
}

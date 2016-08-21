using UnityEngine;
using System.Collections;

public class BackGroundMovement : MonoBehaviour {

	private Vector3 Mouse;
	private Vector3 Gauche = new Vector3(0.5f,0,0);
	private Vector3 Droite = new Vector3 (-0.5f, 0, 0);
	public GameObject devant;
	public GameObject milieu;
	public GameObject arriere;
	private Vector3 PosX;
	private Vector3 MidX;
	private Vector3 BackX;
	private float valLeft;
	private float valRight;
	private float MidLeft;
	private float MidRight;
	private float BackLeft;
	private float BackRight;

	public void Start()
	{
		valLeft = (65 / 25);
		valRight = (-26 / 25);
	}
	
	void Update () {

		Mouse = Input.mousePosition;

		if (Mouse.x <= 0) 
		{
			/*if (devant.transform.position.x < 65)
			{
				devant.transform.Translate(Gauche);
			}*/
			PosX = new Vector3((valLeft*25),0,240);
			MidX = new Vector3((valLeft*25),0,520);
			BackX = new Vector3((valLeft*25),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > 0 && Mouse.x < (Screen.width/50)) 
		{
			/*if (devant.transform.position.x < 47.75f)
			{
				devant.transform.Translate(Gauche);
			} else if (devant.transform.position.x > 49.75f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*24),0,240);
			MidX = new Vector3((valLeft*24),0,520);
			BackX = new Vector3((valLeft*24),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;

		}

		if (Mouse.x > (Screen.width/50) && Mouse.x < ((Screen.width/50)*2)) 
		{
			/*if (devant.transform.position.x < 31.5f)
			{
				devant.transform.Translate(Gauche);
			} else if (devant.transform.position.x > 33.5f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*23),0,240);
			MidX = new Vector3((valLeft*23),0,520);
			BackX = new Vector3((valLeft*23),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*2) && Mouse.x < ((Screen.width/50)*3)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*22),0,240);
			MidX = new Vector3((valLeft*22),0,520);
			BackX = new Vector3((valLeft*22),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*3) && Mouse.x < ((Screen.width/50)*4)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*21),0,240);
			MidX = new Vector3((valLeft*21),0,520);
			BackX = new Vector3((valLeft*21),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*4) && Mouse.x < ((Screen.width/50)*5)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*20),0,240);
			MidX = new Vector3((valLeft*20),0,520);
			BackX = new Vector3((valLeft*20),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*5) && Mouse.x < ((Screen.width/50)*6)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*19),0,240);
			MidX = new Vector3((valLeft*19),0,520);
			BackX = new Vector3((valLeft*19),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*6) && Mouse.x < ((Screen.width/50)*7)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*18),0,240);
			MidX = new Vector3((valLeft*18),0,520);
			BackX = new Vector3((valLeft*18),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*7) && Mouse.x < ((Screen.width/50)*8)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*17),0,240);
			MidX = new Vector3((valLeft*17),0,520);
			BackX = new Vector3((valLeft*17),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*8) && Mouse.x < ((Screen.width/50)*9)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*16),0,240);
			MidX = new Vector3((valLeft*16),0,520);
			BackX = new Vector3((valLeft*16),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*9) && Mouse.x < ((Screen.width/50)*10)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*15),0,240);
			MidX = new Vector3((valLeft*15),0,520);
			BackX = new Vector3((valLeft*15),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*10) && Mouse.x < ((Screen.width/50)*11)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*14),0,240);
			MidX = new Vector3((valLeft*14),0,520);
			BackX = new Vector3((valLeft*14),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*11) && Mouse.x < ((Screen.width/50)*12)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*13),0,240);
			MidX = new Vector3((valLeft*13),0,520);
			BackX = new Vector3((valLeft*13),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*12) && Mouse.x < ((Screen.width/50)*13)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*12),0,240);
			MidX = new Vector3((valLeft*12),0,520);
			BackX = new Vector3((valLeft*12),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*13) && Mouse.x < ((Screen.width/50)*14)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*11),0,240);
			MidX = new Vector3((valLeft*11),0,520);
			BackX = new Vector3((valLeft*11),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*14) && Mouse.x < ((Screen.width/50)*15)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*10),0,240);
			MidX = new Vector3((valLeft*10),0,520);
			BackX = new Vector3((valLeft*10),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*15) && Mouse.x < ((Screen.width/50)*16)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*9),0,240);
			MidX = new Vector3((valLeft*9),0,520);
			BackX = new Vector3((valLeft*9),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*16) && Mouse.x < ((Screen.width/50)*17)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*8),0,240);
			MidX = new Vector3((valLeft*8),0,520);
			BackX = new Vector3((valLeft*8),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*17) && Mouse.x < ((Screen.width/50)*18)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*7),0,240);
			MidX = new Vector3((valLeft*7),0,520);
			BackX = new Vector3((valLeft*7),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*18) && Mouse.x < ((Screen.width/50)*19)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*6),0,240);
			MidX = new Vector3((valLeft*6),0,520);
			BackX = new Vector3((valLeft*6),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;;
		}

		if (Mouse.x > ((Screen.width/50)*19) && Mouse.x < ((Screen.width/50)*20)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*5),0,240);
			MidX = new Vector3((valLeft*5),0,520);
			BackX = new Vector3((valLeft*5),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*20) && Mouse.x < ((Screen.width/50)*21)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*4),0,240);
			MidX = new Vector3((valLeft*4),0,520);
			BackX = new Vector3((valLeft*4),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*21) && Mouse.x < ((Screen.width/50)*22)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*3),0,240);
			MidX = new Vector3((valLeft*3),0,520);
			BackX = new Vector3((valLeft*3),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*22) && Mouse.x < ((Screen.width/50)*23)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*2),0,240);
			MidX = new Vector3((valLeft*2),0,520);
			BackX = new Vector3((valLeft*2),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*23) && Mouse.x < ((Screen.width/50)*24)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valLeft*1),0,240);
			MidX = new Vector3((valLeft*1),0,520);
			BackX = new Vector3((valLeft*1),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x == ((Screen.width/50)*25) && devant.transform.position.x != 0) 
		{
			/* valLeft au dessus

				valRight en dessous
			 */

			// Centre de l'écran.
			PosX = new Vector3(0f,0,240);
			MidX = new Vector3(0f,0,520);
			BackX = new Vector3(0f,0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*25) && Mouse.x < ((Screen.width/50)*26)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*1),0,240);
			MidX = new Vector3((valRight*1),0,520);
			BackX = new Vector3((valRight*1),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*26) && Mouse.x < ((Screen.width/50)*27)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*2),0,240);
			MidX = new Vector3((valRight*2),0,520);
			BackX = new Vector3((valRight*2),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*27) && Mouse.x < ((Screen.width/50)*28)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*3),0,240);
			MidX = new Vector3((valRight*3),0,520);
			BackX = new Vector3((valRight*3),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;;
		}

		if (Mouse.x > ((Screen.width/50)*28) && Mouse.x < ((Screen.width/50)*29)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*4),0,240);
			MidX = new Vector3((valRight*4),0,520);
			BackX = new Vector3((valRight*4),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*29) && Mouse.x < ((Screen.width/50)*30)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*5),0,240);
			MidX = new Vector3((valRight*5),0,520);
			BackX = new Vector3((valRight*5),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*30) && Mouse.x < ((Screen.width/50)*31)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*6),0,240);
			MidX = new Vector3((valRight*6),0,520);
			BackX = new Vector3((valRight*6),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*31) && Mouse.x < ((Screen.width/50)*32)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*7),0,240);
			MidX = new Vector3((valRight*7),0,520);
			BackX = new Vector3((valRight*7),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*32) && Mouse.x < ((Screen.width/50)*33)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*8),0,240);
			MidX = new Vector3((valRight*8),0,520);
			BackX = new Vector3((valRight*8),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*33) && Mouse.x < ((Screen.width/50)*34)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*9),0,240);
			MidX = new Vector3((valRight*9),0,520);
			BackX = new Vector3((valRight*9),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*34) && Mouse.x < ((Screen.width/50)*35)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*10),0,240);
			MidX = new Vector3((valRight*10),0,520);
			BackX = new Vector3((valRight*10),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*35) && Mouse.x < ((Screen.width/50)*36)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*11),0,240);
			MidX = new Vector3((valRight*11),0,520);
			BackX = new Vector3((valRight*11),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*36) && Mouse.x < ((Screen.width/50)*37)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*12),0,240);
			MidX = new Vector3((valRight*12),0,520);
			BackX = new Vector3((valRight*12),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*37) && Mouse.x < ((Screen.width/50)*38)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*13),0,240);
			MidX = new Vector3((valRight*13),0,520);
			BackX = new Vector3((valRight*13),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*38) && Mouse.x < ((Screen.width/50)*39)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*14),0,240);
			MidX = new Vector3((valRight*14),0,520);
			BackX = new Vector3((valRight*14),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*39) && Mouse.x < ((Screen.width/50)*40)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*15),0,240);
			MidX = new Vector3((valRight*15),0,520);
			BackX = new Vector3((valRight*15),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*40) && Mouse.x < ((Screen.width/50)*41)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*16),0,240);
			MidX = new Vector3((valRight*16),0,520);
			BackX = new Vector3((valRight*16),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*41) && Mouse.x < ((Screen.width/50)*42)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*17),0,240);
			MidX = new Vector3((valRight*17),0,520);
			BackX = new Vector3((valRight*17),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*42) && Mouse.x < ((Screen.width/50)*43)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*18),0,240);
			MidX = new Vector3((valRight*18),0,520);
			BackX = new Vector3((valRight*18),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*43) && Mouse.x < ((Screen.width/50)*44)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*19),0,240);
			MidX = new Vector3((valRight*19),0,520);
			BackX = new Vector3((valRight*19),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*44) && Mouse.x < ((Screen.width/50)*45)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*20),0,240);
			MidX = new Vector3((valRight*20),0,520);
			BackX = new Vector3((valRight*20),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*45) && Mouse.x < ((Screen.width/50)*46)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*21),0,240);
			MidX = new Vector3((valRight*21),0,520);
			BackX = new Vector3((valRight*21),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*46) && Mouse.x < ((Screen.width/50)*47)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*22),0,240);
			MidX = new Vector3((valRight*22),0,520);
			BackX = new Vector3((valRight*22),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*47) && Mouse.x < ((Screen.width/50)*48)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*23),0,240);
			MidX = new Vector3((valRight*23),0,520);
			BackX = new Vector3((valRight*23),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*48) && Mouse.x < ((Screen.width/50)*49)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*24),0,240);
			MidX = new Vector3((valRight*24),0,520);
			BackX = new Vector3((valRight*24),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}

		if (Mouse.x > ((Screen.width/50)*49) && Mouse.x < ((Screen.width/50)*50)) 
		{
			/*if (devant.transform.position.x < 15.25f)
			{
				devant.transform.Translate(Gauche);
			}  else if (devant.transform.position.x > 17.25f){
				devant.transform.Translate(Droite);
			}*/
			PosX = new Vector3((valRight*25),0,240);
			MidX = new Vector3((valRight*25),0,520);
			BackX = new Vector3((valRight*25),0,900);
			devant.transform.position = PosX;
			milieu.transform.position = MidX;
			arriere.transform.position = BackX;
		}
	}
}

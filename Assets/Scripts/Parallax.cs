using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {

	private Vector3 Mouse;

	public GameObject devant;
	public GameObject milieu;
	public GameObject arriere;
	public float speedDevant;
	public float speedMilieu;
	public float speedArriere;

	void Update () {
		Mouse = Input.mousePosition;

		if (Mouse.x <= Screen.width/2) {
			//bouge a gauche
			devant.transform.Translate(Vector3.right * Time.deltaTime * speedDevant);
			milieu.transform.Translate(Vector3.right * Time.deltaTime * speedMilieu);
			arriere.transform.Translate(Vector3.right * Time.deltaTime * speedArriere);
		}

		if (Mouse.x >= Screen.width/2) {
			//bouge a droite
			devant.transform.Translate(Vector3.left * Time.deltaTime * speedDevant);
			milieu.transform.Translate(Vector3.left * Time.deltaTime * speedMilieu);
			arriere.transform.Translate(Vector3.left * Time.deltaTime * speedArriere);
		}
	}
}

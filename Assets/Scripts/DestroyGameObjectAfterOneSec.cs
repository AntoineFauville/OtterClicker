using UnityEngine;
using System.Collections;

public class DestroyGameObjectAfterOneSec : MonoBehaviour {

	public float v = 1f; 

	void Start () {
		Destroy (gameObject, v);
	}
}
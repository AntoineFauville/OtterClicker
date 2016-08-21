using UnityEngine;
using System.Collections;

public class ParticuleDeplacement : MonoBehaviour {

    public Transform goToParticule;
    private Transform myTransForm;

    public float particuleSpeed;
    public float rotationSpeedOfEnnemi = 10;

    void Awake(){
        myTransForm = transform;
    }

    void Update() {
        GoToPoint();
        LookAtPoint();
    }

    void GoToPoint() {
        float dist = Vector3.Distance(myTransForm.position, goToParticule.position);
        transform.position = Vector3.MoveTowards(transform.position, goToParticule.position, particuleSpeed * Time.deltaTime);
    }

    void LookAtPoint(){
        myTransForm.rotation = Quaternion.Slerp(myTransForm.rotation, Quaternion.LookRotation(goToParticule.position - myTransForm.position), rotationSpeedOfEnnemi * Time.deltaTime);
    }
}

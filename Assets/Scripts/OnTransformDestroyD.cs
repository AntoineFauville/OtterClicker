using UnityEngine;
using System.Collections;

public class OnTransformDestroyD : MonoBehaviour {

    public Transform startTransform;
    public Transform endTransform;
    public Rigidbody prefabToCreateWhenDestroy;
    
    void Update() {
        if (startTransform.position == endTransform.position) {
            Instantiate(prefabToCreateWhenDestroy, startTransform.position, endTransform.rotation);
            Destroy(gameObject);
        }
    }
}

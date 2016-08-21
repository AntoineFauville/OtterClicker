using UnityEngine;
using System.Collections;

public class LoadIntroLevel : MonoBehaviour {

    void Start() {
        Application.runInBackground = true;
    }

    public void ChargerIntro() {
        Application.LoadLevel("Intro");
    }

    public void ChargerMain() {
        Application.LoadLevel("Main Scene");
    }
}

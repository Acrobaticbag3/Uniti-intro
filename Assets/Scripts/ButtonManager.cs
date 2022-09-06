using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
    // Start is called before the first frame update
    GameObject optionsBtn;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void LoadNewScene() {
        SceneManager.LoadScene("SampleScene");
    }

    public void Options(){
        optionsBtn.SetActive(false);
    }
}

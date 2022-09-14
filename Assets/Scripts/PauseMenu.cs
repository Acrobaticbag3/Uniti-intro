using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public List<GameObject> hiddenBtn;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        int check = 0;

        if(Input.GetKeyDown(KeyCode.Escape)) {
            Time.timeScale = 0f;
            for (int i = 0; i < hiddenBtn.Count; i++) {
                hiddenBtn[i].SetActive(true);
                check++;
            }
        }
    }

    public void Pause() {

    }

    public void Resume(){
        
    }
}

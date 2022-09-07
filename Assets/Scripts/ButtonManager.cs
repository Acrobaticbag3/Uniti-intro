using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
    // Start is called before the first frame update
    public List<GameObject> showOptionBtn;
    public List<GameObject> optionsBtn;

    public void LoadNewScene() {
        SceneManager.LoadScene("SampleScene");
    }

    public void Options(){
        for (int i = 0; i < optionsBtn.Count; i++) {
            optionsBtn[i].SetActive(false);
        }

        for (int i = 0; i < showOptionBtn.Count; i++) {
            showOptionBtn[i].SetActive(true);
        }
    }

    public void Back() {
        for (int i = 0; i < optionsBtn.Count; i++) {
            optionsBtn[i].SetActive(true);
        }

        for (int i = 0; i < showOptionBtn.Count; i++) {
            showOptionBtn[i].SetActive(false);
        }
    }
}

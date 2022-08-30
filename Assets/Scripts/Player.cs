using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.01f;
    public int points = 0;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKey(KeyCode.W)) {
            transform.position += new Vector3(speed, 0, 0);
        }
        if(Input.GetKey(KeyCode.S)) {
            transform.position += new Vector3(-speed, 0, 0);
        }
        if(Input.GetKey(KeyCode.A)) {
            transform.position += new Vector3(0, 0, speed);
        }
        if(Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(0, 0, -speed);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Coin") {
            points++;
            Destroy(other.gameObject);
        }
    }
}

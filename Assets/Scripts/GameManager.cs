using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject coinPrefab;
    public GameObject coin;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if(coin == null){ // If the coin does not exist
            coin = Instantiate(coinPrefab); // Spawn new coin
            Vector3 position = Vector3.one;
            position.x = Random.Range(-13f, 13f);
            position.z = Random.Range(-13f, 13f);
            coin.transform.position = position;
        }
    }
}

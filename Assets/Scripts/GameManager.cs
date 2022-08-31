using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject coinPrefab;
    public GameObject coin;
    public GameObject blockerPrefab;
    public GameObject blocker;
    public int blockerAmount = 0;
    float time = 0;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if(coin == null){ // If the coin does not exist
            coin = Instantiate(coinPrefab); // Spawn new coin
            Vector3 position = Vector3.one;
            position.x = Random.Range(-20f, 20f);
            position.z = Random.Range(-20f, 20f);
            coin.transform.position = position;
        }
        if(blockerAmount != 20 && time >= 0.5){
            blocker = Instantiate(blockerPrefab);
            Vector3 positiontwo = Vector3.one;
            positiontwo.x = Random.Range(25f, 26f);
            positiontwo.y = Random.Range(1f, 10f);
            positiontwo.z = Random.Range(-20f, 20f);
            time = 0;
        }
        time += Time.deltaTime;
    }
}

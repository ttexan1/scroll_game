using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject coin;
    public GameObject player;
    public GameObject enemy;
    float generalTime;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        generalTime += Time.deltaTime;
        if (generalTime > 0.8f)
        {
            InstanciateCoin();
            InstanciateEnemy();
            generalTime = 0;
        }
    }
    void InstanciateCoin()
    {
        Vector3 playerPos = player.transform.position;
        Instantiate(coin, playerPos + new Vector3(3, 0, 0), Quaternion.identity);
    }
    void InstanciateEnemy()
    {
        Vector3 playerPos = player.transform.position;
        Instantiate(enemy, playerPos + new Vector3(3, Random.Range(-1,1), 0), Quaternion.identity);
    }
}

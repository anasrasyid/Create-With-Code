using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        // Get player controller by tag
        playerController = GameObject.FindGameObjectWithTag("Player")
            .GetComponent<PlayerController>();

        Invoke("SpawnObstacle", startDelay);
    }

    void SpawnObstacle()
    {
        if (!playerController.gameOver)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            Invoke("SpawnObstacle", repeatRate);
        }
    }
}

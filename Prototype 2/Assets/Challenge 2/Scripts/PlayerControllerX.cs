using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastSpawn;
    // Update is called once per frame
    void Update()
    {

        // On spacebar press and the current time greater than last Spawn + interval, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastSpawn + 0.5f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawn = Time.time;
        }
    }
}

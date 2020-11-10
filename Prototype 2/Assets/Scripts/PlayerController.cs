using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectilePrefabs;

    private float inputHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check left boundary
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        // check right boundary
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        // get player input and move the player
        inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * inputHorizontal);

        // launch projectile from player
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectilePrefabs, transform.position, projectilePrefabs.transform.rotation);
    }
}

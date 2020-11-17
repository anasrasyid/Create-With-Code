using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerController;

    private float leftBond = -15;

    // Start is called before the first frame update
    void Start()
    {
        // Get player controller by tag
        playerController = GameObject.FindGameObjectWithTag("Player")
            .GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // check is can move to left
        if(!playerController.gameOver)
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        // check obstacle Area
        if (transform.position.x < leftBond && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}

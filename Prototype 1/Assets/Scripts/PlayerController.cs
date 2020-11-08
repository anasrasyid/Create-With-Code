using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float inputHorizontal;
    private float inputForward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This catch input player
        inputHorizontal = Input.GetAxis("Horizontal");
        inputForward = Input.GetAxis("Vertical");

        // Move the vechicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * inputForward);

        // Turn the vechicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * inputHorizontal);
    }
}

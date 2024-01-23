using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20;
    private float turnSpeed = 25;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the car foward based on forward based on Forward Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Moves the card horizontal based on Horizontal Input
        transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed*horizontalInput);
    }
}

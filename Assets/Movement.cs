using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody MyRigidBody;
    // default 5m/s
    public float speed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Exactly Horizontal/Jump... because of they are keys
        float horizontalInput = Input.GetAxis("Horizontal");
        
        //move 1m/s
        float movement = speed * horizontalInput * Time.deltaTime;
        Debug.Log(horizontalInput);
        
        //shift in x-axis
        //0 on other stuff
        transform.position += new Vector3(movement, 0, 0);
        
        if (Input.GetButtonDown("Jump"))
        {
            MyRigidBody.AddForce(Vector3.up * 100);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlScript : MonoBehaviour
{

    Vector3 velocity, accelration;
    float rateOfRotation = 180f;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    
    
    // Update is called once per frame
    void Update()
    {
        accelration = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        { accelration = transform.forward; };

        if (Input.GetKey(KeyCode.S))
        { accelration = -transform.forward; };

        if (Input.GetKey(KeyCode.D))
        { transform.Rotate(Vector3.up, rateOfRotation * Time.deltaTime); }

        velocity += accelration * Time.deltaTime;

            //s      =       u       *      t
            transform.position += velocity * Time.deltaTime;
    }
}

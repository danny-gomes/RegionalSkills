using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveController : MonoBehaviour
{

    public float forwardSpeed = 50, strafeSpeed = 50, activeFallSpeed = -30;
    private float activeForwardSpeed, activeStrafeSpeed;
    public float forwardAcceleration = 2.5f, strafeAcceleration = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            activeForwardSpeed = Mathf.Lerp(activeForwardSpeed, Input.GetAxisRaw("Vertical") * forwardSpeed, forwardAcceleration * Time.deltaTime);

            transform.position -= transform.forward * activeForwardSpeed * Time.deltaTime;
        } else
        {
            transform.position -= transform.forward * activeFallSpeed * Time.deltaTime;
        }

        activeStrafeSpeed = Mathf.Lerp(activeStrafeSpeed, Input.GetAxisRaw("Horizontal") * strafeSpeed, strafeAcceleration * Time.deltaTime);

        transform.position += transform.right * activeStrafeSpeed * Time.deltaTime;

       
    }
}

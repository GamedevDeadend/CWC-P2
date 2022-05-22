using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float slidespeed;
    public float xrange = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange,transform.position.y, transform.position.z);
        }

        else if(transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange,transform.position.y, transform.position.z);
        }

        else
        {   
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * slidespeed);
        }
    }
}

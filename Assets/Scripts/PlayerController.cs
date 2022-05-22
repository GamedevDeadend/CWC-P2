using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float slidespeed;
    public float xrange = 10.0f;

    public Vector3 offset;

    public GameObject foodProjectile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        offset = new Vector3(0, 10, 0);

        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        else if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }

        else
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * slidespeed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodProjectile, transform.position + offset, foodProjectile.transform.rotation);
        }
    }
}

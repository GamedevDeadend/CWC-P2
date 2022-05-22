using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float upbound;
    public float lowerbound;

   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upbound)
        {
            Destroy(gameObject);
        }

        else if ( transform.position.z < lowerbound)
        {
            Destroy(gameObject);
        }
    }
}

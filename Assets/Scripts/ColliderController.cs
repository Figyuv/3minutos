using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Collider>().enabled = false;
        //disable gravity
        GetComponent<Rigidbody>().useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Collider>().enabled = true;
            //enable gravity
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}

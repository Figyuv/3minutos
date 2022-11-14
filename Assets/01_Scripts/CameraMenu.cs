using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour
{
    public float speed = 0.3f;
    void Update()
    {
        transform.Rotate(new Vector3(0 , 0, 1) * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScroll : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(0, speed, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffectDestroy : MonoBehaviour
{
    void FixedUpdate()
    {
        Destroy(gameObject, 0.9f);
    }
}

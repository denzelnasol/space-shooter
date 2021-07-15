using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{
    private float objectWidth;
    private float objectHeight;

    private void Start()
    {
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    void LateUpdate()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.035f, 0.97f);
        pos.y = Mathf.Clamp(pos.y, 0.065f, 0.935f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}

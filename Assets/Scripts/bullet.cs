using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 7f;
    public int damage = 2;
    private Rigidbody2D rb;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, +speed);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        PlayerCharacter player = hitInfo.GetComponent<PlayerCharacter>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        if (player == null)
        {
            Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }

    private void Update()
    {
        if (gameObject.transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }
}

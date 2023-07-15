using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebullet1 : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 5;
    public Rigidbody2D rb;
    private Boss boss;

    private bool isFacingRight = true; // Karakterin sağa dönük olduğunu takip eden bir flag

    void Start()
    {
        rb.velocity = (isFacingRight ? transform.right : -transform.right) * speed;
    }

    public void SetDirection(bool isRight)
    {
        isFacingRight = isRight;
    }

    private void OnCollider2D(Collider2D coll)
    {
        BossHealth boss = coll.GetComponent<BossHealth>();
        
        if(boss != null)
        {
            boss.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}

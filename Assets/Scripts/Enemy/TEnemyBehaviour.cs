using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEnemyBehaviour : MonoBehaviour
{
    public int EnemySpeed = 2;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    //    rb.velocity = transform.right * EnemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3 (-EnemySpeed, rb.velocity.y, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

           if(collision.collider.CompareTag("Wall"))
           {

            EnemySpeed *= -1;
        }  

    }
}

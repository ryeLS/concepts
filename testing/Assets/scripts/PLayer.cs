using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    public float initialForce;
    private Rigidbody2D rb;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(Vector2.right * initialForce);
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        //rb.collisionDetectionMode = CollisionDetectionMode2D.Discrete;
        
        if (Input.GetKey(KeyCode.Space))
        {
            sr.color = Color.white;
            rb.simulated = true;
        }
        else
        {
            sr.color = Color.cyan;
            rb.simulated = false;
        }
    }
}

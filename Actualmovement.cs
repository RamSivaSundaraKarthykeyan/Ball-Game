using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actualmovement : MonoBehaviour
{
    [SerializeField] private float jumpforce = 13f;
    [SerializeField] private float speed = 13f;
    private Rigidbody2D rb;
    private int jumpcount = 0;
    [SerializeField] private int jumps;
    private float hori = 0f;
    private bool isjumping;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        hori = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(hori * speed, rb.velocity.y);
       if (Input.GetButtonDown("Jump") && !isjumping)
       {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
                jumpcount++;
                
       }
       if (jumpcount > jumps-1)
       {
        isjumping = true;  
       }
    
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isjumping = false;
            jumpcount = 0;
        }
    }
}

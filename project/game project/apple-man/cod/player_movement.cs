using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class player_movement : MonoBehaviour{


    private Rigidbody2D rb;
    private Animator anim;
    private float dirx = 0f;
    private SpriteRenderer sprite;
    [SerializeField] private float movespeed = 7f;
    [SerializeField] private float jumpforce = 10f;
    private enum movement { idle, running, jumping, falling}
    private BoxCollider2D coll;
    [SerializeField] private LayerMask jumpableground;
    [SerializeField] private AudioSource jumpsound;
    

    // Start is called before the first frame update
    private void Start(){

        
        coll = GetComponent<BoxCollider2D>();   
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();    
    }

    // Update is called once per frame
    private void Update(){
        
        Updterunning();   
        UpdateAnimation();
        
    }
    // for running and jumping
    private void Updterunning(){

        dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new UnityEngine.Vector2(dirx * movespeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isgrounded()){

            jumpsound.Play();
            rb.velocity = new UnityEngine.Vector2(rb.velocity.x, jumpforce);

        }
    } 
    // For animation
    private void UpdateAnimation(){

        movement state;

        if (dirx > 0f){

            state = movement.running;
            sprite.flipX = false;

        }
        else if (dirx < 0f){

            state= movement.running;
            sprite.flipX = true;

        }
        else{

            state = movement.idle;

        }
        if (rb.velocity.y > .1f){

            state = movement.jumping;

        }
        else if (rb.velocity.y < -.1f){

            state = movement.falling;

        }
        anim.SetInteger("state", (int)state);
    }
    private bool isgrounded(){

       return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, UnityEngine.Vector2.down, .1f, jumpableground);

    }
}

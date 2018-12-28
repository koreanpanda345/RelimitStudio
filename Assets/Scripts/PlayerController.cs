//Imported Files
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The PlayerController Class
public class PlayerController : MonoBehaviour {
    //The Speed Variable
    public float speed;
    //The Rigidbody for 2D being defined as rb
    private Rigidbody2D rb;
    //classifing that moveVelocity will have x and y axis, and not the z axis.
    //Vector is the coordinate plane of a object. Vector2 is only grabing two of the 3 axis, which is x and y. Vector3 is grabbing all three, x, y, and z axis.
    private Vector2 moveVelocity;
    //Start method will execute when the game is started.
    void Start(){
        //we are classifing rb as the component Rigidbody2D which should be on the player. if not, then the code will not run.
        rb = GetComponent<Rigidbody2D>();
    }
    //Update method will execute every frame. The best way to remember this is that it UPDATES every frame.
    void Update(){
        //this is creating the basic controls, the movement. this use the arrow keys. When we press either the right or left arrow keys, it should move it left or right.
        //since this is a top down game, the vertical keys the up and down arrows, will move up and down.
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //this is tellint the program how fast the player will move.
        moveVelocity = moveInput.normalized * speed;
    }
    //FixedUpdate, is like the Update method, but it is used to mess with the physics of the game, while keeping it as smooth as possible.
    void FixedUpdate(){
        //this will tell the program where to move the player.
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}

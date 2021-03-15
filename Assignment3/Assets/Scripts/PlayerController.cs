/* * (Jerod Lockhart) 
 * * (Player Controller) 
 * * (Assignment1) 
 * * (This makes the character move) 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public Transform _camera;

    public float moveSpeed = 6f;
    public float jumpForce = 10f;

    public bool isGrounded = true;

    void Start()
    {

    }

    void Update()
    {
        

        


        //moving
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed;

        //jumping
        if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);

        //setting movement
        Vector3 move = transform.right * x + transform.forward * y;

        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
    }  
}

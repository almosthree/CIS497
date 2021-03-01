/* * (Jerod Lockhart) 
 * * (PlayerController) 
 * * (Assignment1) 
 * * (This code makes the player move) 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    public float horizontalInput;
    public float verticalInput;
    public float speed = 100.0f;
    public float hieght = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontalInput * Time.deltaTime * speed, 0, verticalInput * Time.deltaTime * speed);

        transform.Translate(Vector3.up * hieght * Time.deltaTime * 5);
        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        rb.MovePosition(transform.position + movement);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Powerup>() != null)
        {
            Powerup powerup = other.gameObject.GetComponent<Powerup>();

            StartCoroutine(powerup.Activate());
            
        }
    }
}

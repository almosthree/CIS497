/* * (Jerod Lockhart) 
 * * (Anti Gravity) 
 * * (Assignment1) 
 * * (This code makes the gravity different, it allows the player to hover for a little before falling) 
 */
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class AntiGravity : Powerup
{
    public Text text;
    private void Awake()
    {
        cooldownTime = 5f;
    }

    public override IEnumerator Activate()
    {
        Debug.Log("gravity off!");

        //Makes the gravity turn off
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = false;


        //overrides the starting text to tell the player they can fly
        text.text = "Now you can hover for the next 5 seconds! Be careful to land on the underground!";


        //set the powerup gameObject to not active to make it invisible and untriggerable
        gameObject.SetActive(false);

        //wait for cooldownTime seconds
        yield return new WaitForSeconds(cooldownTime);

        //then deactivate this powerup
        Deactivate();
    }

    public override void Deactivate()
    {
        Debug.Log("Gravity on!");

        //Deactivate the effect of the powerup: gravity is now a factor
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = true;

        text.text = "Oops! You're out of time, now you're falling!";
        
        //destroy this powerup
        Destroy(this.gameObject);
    }
}


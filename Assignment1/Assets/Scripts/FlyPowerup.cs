/* * (Jerod Lockhart) 
 * * (Anti Gravity) 
 * * (Assignment1) 
 * * (This code makes the gravity different, it allows the player to fly back up) 
 */
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class FlyPowerup : Powerup
{
    public Text text;
    private void Awake()
    {
        cooldownTime = 5f;
    }

    public override IEnumerator Activate()
    {
        Debug.Log("Flight on!");

        //Makes the gravity turn off, then lets you fly
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().hieght = 1;


        //overrides the starting text to tell the player they can fly
        text.text = "Now you can fly for the next 5 seconds! Try to get back up!";


        //set the powerup gameObject to not active to make it invisible and untriggerable
        gameObject.SetActive(false);

        //wait for cooldownTime seconds
        yield return new WaitForSeconds(cooldownTime);

        //then deactivate this powerup
        Deactivate();
    }

    public override void Deactivate()
    {
        Debug.Log("Flight off!");

        //Deactivate the effect of the powerup: gravity is now a factor, and can no longer fly
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().hieght = 0;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = true;

        text.text = "Oops! You're out of time, now you're falling again!";

        //destroy this powerup
        Destroy(this.gameObject);
    }
}


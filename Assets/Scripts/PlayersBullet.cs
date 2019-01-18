using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersBullet : MonoBehaviour {

    public float velX = 100f;
    float velY = 0f;

    Rigidbody2D rb;


    // Unity calls this function automatically
    // When our bullet touches any other object
    private void OnCollisionEnter2D(Collision2D collsion)
    {

        //Check if the thing that we collided with is the player
        Player playerScript = collsion.collider.GetComponent<Player>();
        
        // Only do something if the thing we run into was in fact the player (aka playerScript is not null)

        if (playerScript != null)
        {
            // We DID hit the player!

            //KILL THEM!
            playerScript.Kill();
        }
       

       



    }


    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update ()
    {
        // Sets players bullet velocity.
        rb.velocity = new Vector2(velX, velY);
        // Destroys players bullet after 3 seconds
        Destroy(gameObject, 3f);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {



    // Variable lets us add to the score.
    // Public so we can drag and drop.
    public Score scoreObject;
    // Variable to hold the coin's poin value.
    // Public so we can change it in the editor.
    public int coinValue;


    // Unity calls this function automatically
    // When our enemy touch any other object
    private void OnCollisionEnter2D(Collision2D collsion)
    {

        //Check if the thing that we collided with is the player (aka has a Player script)
        Player playerScript = collsion.collider.GetComponent<Player>();
        // Only do something if the thing we run into was in fact the player (aka playerScript is not null)

        if (playerScript != null)
        {
            // We DID hit the player!

            //KILL THEM!
            playerScript.Kill();
        }


        // Unity calls this function when our coin touches any other object.
        // If the players bullet touches us, the enemy should vanish and the score should go up.


        // Check if the thing we touched was the Player.
        PlayersBullet playersBulletscript = collision.collider.GetComponent<playersBullet>();

        // If the thing we touched is the players bullet script, that means it is the player, so...
        if (playersBulletScript)
        {
            // We hit the player.

            // Add to the score based on our value.
            scoreObject.AddScore(coinValue);

            // Destroy the gameObject that this script is attached to the coin.

            Destroy(gameObject);


        }
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    


}

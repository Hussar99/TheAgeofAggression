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
    // When our bullet touches any other object
    private void OnCollisionEnter2D(Collision2D collsion)
    {

        //Check if the thing that we collided with is the player or bullet
        Player playerScript = collsion.collider.GetComponent<Player>();
        PlayersBullet playersBulletScript = collsion.collider.GetComponent<PlayersBullet>();
        // Only do something if the thing we run into was in fact the player (aka playerScript is not null)

        if (playerScript != null)
        {
            // We DID hit the player!

            //KILL THEM!
            playerScript.Kill();
        }

        else

         if (playersBulletScript != null)
        {
            // We DID hit the enemy

            // Add to the score based on our value.
            scoreObject.AddScore(coinValue);


            // Kill the enemy!!!
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

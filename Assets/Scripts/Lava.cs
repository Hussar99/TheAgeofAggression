using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour {

    // Unity calls this function automatically
    // When our enemy touch any other object
    private void OnCollisionEnter2D(Collision2D collsion)
    {

        //Check if the thing that we collided with is the player (aka has a Player script)
        Player PlayerScript = collsion.collider.GetComponent<Player>();
        // Only do something if the thing we run into was in fact the player (aka playerScript is not null)

        if (PlayerScript != null)
        {
            // We DID hit the player!

            //KILL THEM!
            PlayerScript.Kill();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Sets players bullet velocity.
        fb.velocity = new Vector2(velocityY, velocityX);
        // Destroys players bullet after 3 seconds
        Destroy(gameObject, 3f);
	}
}

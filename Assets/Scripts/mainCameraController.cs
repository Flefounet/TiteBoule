using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCameraController : MonoBehaviour {

    // We want to make the camera following the player as the camera position is defined in the scene relatively to the player
    // basically it makes: mainCameraPosition = playerPosition + offsetAtInitialisation


    //Attributes : what we need?
    //the player itself so this the reference to the player game object

    public GameObject player;
    // a place to store the difference in position between player and camera. 
    //the offset is the camera position minus the player position

    private Vector3 offsetAtInitialisation;

    // and the objects to store the positions of the camera and the player

   
    // Methods
    //the initial offset is comptuted to ensure the camera will get the good offset if the player is not at 0,0,0 
    void Start () {
        
  


    //Offset computation and storage
    offsetAtInitialisation =  transform.position - player.transform.position;

	}
	
	// Update will be made after each frame's update (guaranteeing all items have been processed)
	void LateUpdate () {

        transform.position = player.transform.position + offsetAtInitialisation;


    }
}

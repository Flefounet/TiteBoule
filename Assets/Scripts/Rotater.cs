using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

	// Update is called once per frame
    //Note : collectibles have a rigidbody set to "is  kinematic" to save performance
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);	
	}
}

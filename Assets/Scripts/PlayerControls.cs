using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Reference:
/// https://www.youtube.com/watch?v=F5eE1YL1ZJY&t=1316s

public class PlayerControls : MonoBehaviour {


	public float speed = 2f; //Initialising the speed of the player
	CharacterController player; 
	float leftright; //Initialising the directions of the player
	float forwardback; //Initialising the directions of the player


	void Start () {
		player = GetComponent<CharacterController> (); //Get the Character Controller component - assigning it to the player
	
	}

	/// Reference:
	/// https://www.youtube.com/watch?v=F5eE1YL1ZJY&t=1316s

	void Update (){

		float leftright = Input.GetAxis ("Horizontal") * speed; //Input Get Axis multiplied by the speed
		float forwardback = Input.GetAxis ("Vertical") * speed;//Input Get Axis multiplied by the speed

		Vector3 moving = new Vector3 (leftright, 0, forwardback); //Subtituting the x,y,z coordinates 
		moving = transform.rotation * moving;	//based on the player rotation go forward
		player.Move (moving * Time.deltaTime);

	}
}

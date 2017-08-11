using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reference: TheCGMaster: https://www.youtube.com/watch?v=Kjb79y-Lp3k&t=803s

public class Football: MonoBehaviour {

	public void OnTriggerEnter(Collider other){ //Creating a public class for the collision of the ball 
		
		if (other.gameObject.tag == "FootballGoal") { //Initialising the game tag for the ball 
			
			transform.position = GameObject.Find("FootballPosition").transform.position; // Allows the ball to restart to its original positiion
			this.gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		}
	}


}
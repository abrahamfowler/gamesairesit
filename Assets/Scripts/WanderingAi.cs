using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reference:  https://www.youtube.com/watch?v=4CCAvUqAC7k&t=2s

public class WanderingAi : MonoBehaviour {

	public float detectorLength = 1.0f; // Initialising the length of the sensor which will be used for the raycast
	public float agentSpeed = 10.0f; //Initialising the speed of the agent
	public float swiftValue = 1.0f;//Initialising the value of the agent's movement
	public float spinValue = 0.0f;//Initialising the value of the turning value of the agent
	public float spinSpeed = 50.0f; //the speed at which the agent spins 
	Collider agentCollision;

	void Start () {
		agentCollision = transform.GetComponent<Collider> (); //Initialising the collider 
	}

//Reference:  https://www.youtube.com/watch?v=4CCAvUqAC7k&t=2s

	void Update () {
		
		RaycastHit hit; 
		int doublecheck = 0;

		//Right detector
		if (Physics.Raycast (transform.position, transform.right, out hit, (detectorLength + transform.localScale.x))) { //
			if (hit.collider.tag != "Obstacle" || hit.collider == agentCollision) {
				return;
			}
			spinValue -= 1; 		//the right detector detects if there is an obstacle, if there isn't an obstacle it will turn right
			doublecheck++; 
		}
		//Left detector 
		if (Physics.Raycast (transform.position, -transform.right, out hit, (detectorLength + transform.localScale.x))) {
			if (hit.collider.tag != "Obstacle" || hit.collider == agentCollision) {
				return;
			}
			spinValue += 1; 
			doublecheck++; 			//the left detector detects if there is an obstacle, if there isn't an obstacle it will turn left
		}
		//Forward detector
		if (Physics.Raycast (transform.position, transform.forward, out hit, (detectorLength + transform.localScale.z))) {
			if (hit.collider.tag != "Obstacle" || hit.collider == agentCollision) {
				return;
			}
			if (swiftValue == 1.0f) {
				swiftValue = -1; 	//the forward detector detects if there is an obstacle, if there isn't an obstacle it will turn backwards
			}

			doublecheck++;
		}
		//Back detector
		if (Physics.Raycast (transform.position, -transform.forward, out hit, (detectorLength + transform.localScale.z))) {
			if (hit.collider.tag != "Obstacle" || hit.collider == agentCollision) {
				return;
			}
			if (swiftValue == -1.0f) {
				
				swiftValue = 1; 	//the back detector detects if there is an obstacle, if there isn't an obstacle it will turn forward
			}
			doublecheck++;
		}
		if (doublecheck == 0) { 
			spinValue = 0; 
		}
		transform.Rotate (Vector3.up * (spinSpeed * spinValue) * Time.deltaTime); //Rotating the direction of the agent, updating every frame, detecting if objects
																				  //are in the way 
		transform.position += transform.forward * (agentSpeed * swiftValue) * Time.deltaTime; //This moves the agents every frame

	}

//Reference:  https://www.youtube.com/watch?v=4CCAvUqAC7k&t=2s

	void OnDrawGizmos() {
		//Draws gizmos allowing us to see that rays at the edges of the agents (this can be seen in scene mode)
		Gizmos.DrawRay (transform.position, transform.forward * (detectorLength + transform.localScale.z)); //forward ray
		Gizmos.DrawRay (transform.position, -transform.forward * (detectorLength + transform.localScale.z)); //backward ray 
		Gizmos.DrawRay (transform.position, transform.right * (detectorLength + transform.localScale.x)); //right ray  
		Gizmos.DrawRay (transform.position, -transform.right * (detectorLength + transform.localScale.x)); //left ray
	}
}

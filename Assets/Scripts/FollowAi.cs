using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;


//Reference:  https://www.youtube.com/watch?v=hyZPpACBW_8

public class FollowAi : MonoBehaviour {

	private NavMeshAgent footballplayerAgent; //Initialising the navmesh agent 
	public Transform target; //Initialising the target 

	void Start()
	{
		footballplayerAgent = GetComponent<NavMeshAgent> (); //Allowing the football agent to access the nav mesh

	}

	void Update(){

		footballplayerAgent.SetDestination (target.position); //setting the target of the agent 
	}

}




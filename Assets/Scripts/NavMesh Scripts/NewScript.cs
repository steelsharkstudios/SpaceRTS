﻿using UnityEngine;
using System.Collections;

public class NewScript : MonoBehaviour {

	public GameObject target;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {

		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

		agent.SetDestination(target.transform.position);
	}
}
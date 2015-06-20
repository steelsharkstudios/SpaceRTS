using UnityEngine;
using System.Collections;

public class UnitProperties : MonoBehaviour {

	public GameObject minimapIcon;

	// Use this for initialization
	void Start () {
		
		GameObject.Instantiate(minimapIcon, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
			
		
	}
}
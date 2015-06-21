using UnityEngine;
using System.Collections;

public class UnitProperties : MonoBehaviour {

	public GameObject minimapIconPrefab;

	// Use this for initialization
	void Start () {
		
		GameObject minimapIcon = GameObject.Instantiate(minimapIconPrefab, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {


	}
}
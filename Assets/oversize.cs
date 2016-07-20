using UnityEngine;
using System.Collections;

public class oversize: MonoBehaviour {
	public GameObject prefab001;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			Instantiate (prefab001);
		}
	
	}
}

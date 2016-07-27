using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float hor = Input.GetAxis ("Horizontal");
		if ( Mathf.Abs(hor)> 0) 
		{
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + hor);

		}
	}
}
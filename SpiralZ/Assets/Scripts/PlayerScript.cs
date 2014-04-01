using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public KeyCode jump;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (jump))
			transform.rigidbody2D.AddForce (new Vector2 (0, 400));
	}
}

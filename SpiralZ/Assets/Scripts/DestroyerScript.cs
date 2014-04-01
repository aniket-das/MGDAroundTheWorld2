using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	Spawner spwn;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") 
		{
			Application.LoadLevel (1);
			return;
		}
		if (other.gameObject.transform.parent)
		{
			Destroy (other.gameObject.transform.parent.gameObject);
			spwn.growOff();
			spwn.Spawn ();
		}
		else
		{
			Destroy (other.gameObject);
			spwn.growOff();
			spwn.Spawn ();
		}
	}
}

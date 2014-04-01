using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] obj;

	public float timestep=10.0f;

	public bool grow=false;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	public void growOn(){
				grow = true;
		}

	public void growOff(){
				grow = false;
		}

	public bool isGrowing(){
		return grow;
	}

	// Update is called once per frame
	public void Spawn () {
		Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		Invoke ("Spawn",timestep);
	}
}

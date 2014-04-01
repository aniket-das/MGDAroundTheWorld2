using UnityEngine;
using System.Collections;

public class Scaler : MonoBehaviour {

	public float scale;
	public float scaleMid=0.5f;
	public float scaleLarge=1.5f;
	float scaleStep=0.0009f;
	float rotSpeed=30.0f;
	float acceleration=0.02f;

	bool firstTouch=false;

	bool growFirst=true;
	bool growSecond=false;

	float t=0.0f;

	Spawner spwn;

	void Start(){
		spwn=GameObject.Find ("Spawner").GetComponent<Spawner>();
	}

	public void OnTriggerEnter2D(Collider2D other){
				if (other.tag == "Player" && firstTouch) {
					spwn.growOn();
				}
		}



	// Update is called once per frame
	void Update () {


				t += Time.deltaTime;
				Debug.Log (scale);
				spwn = GameObject.Find ("Spawner").GetComponent<Spawner> ();
				//t += Time.deltaTime * speed;
				rotSpeed += acceleration;
				transform.Rotate (Vector3.back, Time.deltaTime * rotSpeed);
				if (scale < scaleMid) {
						scale += scaleStep;
						transform.localScale = new Vector3 (scale, scale, scale);
				} else {
						if (t > 10.0f) {
								scale += scaleStep;
								transform.localScale = new Vector3 (scale, scale, scale);
						}
				}	
	}
}

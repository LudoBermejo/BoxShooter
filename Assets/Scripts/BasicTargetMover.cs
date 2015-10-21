using UnityEngine;
using System.Collections;

public class BasicTargetMover : MonoBehaviour {

	public float speed = 180.0f;
	public float motionMagnitude = 0.1f;

	public bool doSpin = true;
	public bool doMotion = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// rotate around the up axis of the gameObject
		if(doSpin)
			gameObject.transform.Rotate (Vector3.up * speed * Time.deltaTime);

		// move up & down over time
		if(doMotion)
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
	}
}

using UnityEngine;
using System.Collections;

public class BasicController : MonoBehaviour {

	private CharacterController myController;
	public float speed = 10;
	public float gravity = 9.8f;

	void Start() {

		myController = gameObject.GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		Vector3 zMovement = Vector3.forward * speed * Input.GetAxis ("Vertical") * Time.deltaTime;
		Vector3 xMovement = Vector3.right * speed * Input.GetAxis ("Horizontal") * Time.deltaTime;

		Vector3 movement = transform.TransformDirection(xMovement+zMovement);
		movement.y = -gravity * Time.deltaTime;

		myController.Move (movement);
	}
}

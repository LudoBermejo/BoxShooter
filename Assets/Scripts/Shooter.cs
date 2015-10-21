using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	// Reference to projectile prefab to shoot
	public GameObject projectile;
	public float power = 10.0f;
	
	// Reference to AudioClip to play
	public AudioClip shootSFX;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1") || Input.GetButtonDown ("Jump")) {

			if(projectile) {
				GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation) as GameObject;

				if(!newProjectile.GetComponent<Rigidbody>()) {
					newProjectile.AddComponent<Rigidbody>();
				}

				newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);

				if(shootSFX) {
					if(newProjectile.GetComponent<AudioSource>()) {
						newProjectile.GetComponent<AudioSource>().PlayOneShot(shootSFX);
					}
					else {
						newProjectile.AddComponent<AudioSource>().PlayOneShot(shootSFX);
					}
				}

				newProjectile.transform.parent = gameObject.transform;
			}

		}
	}
}

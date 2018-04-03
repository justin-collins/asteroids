using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour {
	public Laser laser;
	public float fireRate = 0.4f;

	private float nextFire = 0.0f;

	void fireLaser() {
		Laser laserClone = (Laser) Instantiate(laser, transform.position, transform.rotation);

		Rigidbody2D playerRigid = transform.parent.GetComponent<Rigidbody2D> ();
		Rigidbody2D laserRigid = laserClone.GetComponent<Rigidbody2D> ();
		laserRigid.velocity = playerRigid.velocity.normalized * laserClone.speed;
	}
		
	void FixedUpdate () {
		if ((Input.GetButton("Fire1") || Input.GetButton("Jump")) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			fireLaser();
		}
	}
}

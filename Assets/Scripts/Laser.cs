using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	public float speed = 20f;
	public float lifetime = 1.5f;

	void Start () {
		Destroy(gameObject, lifetime);
	}

}

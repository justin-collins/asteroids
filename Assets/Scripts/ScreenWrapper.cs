﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour {

	void FixedUpdate () {
		Vector3 newPosition = transform.position;
		Vector3 viewportPosition = Camera.main.WorldToViewportPoint(newPosition);

		if (viewportPosition.x > 1 || viewportPosition.x < 0) {
			newPosition.x = -newPosition.x;
		}

		if (viewportPosition.y > 1 || viewportPosition.y < 0) {
			newPosition.y = -newPosition.y;
		}

		transform.position = newPosition;
	}
}

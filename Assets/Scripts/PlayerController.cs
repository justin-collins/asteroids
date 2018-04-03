using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float thrust;
	public float yaw;

	private Rigidbody2D rigidBody;
	private float drag = 0.4f;
	private Transform engineEffects;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		engineEffects = transform.Find("EngineEffects");
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		transform.Rotate(new Vector3(0, 0, -moveHorizontal * yaw * Time.deltaTime));

		if (moveVertical != 0) {
			rigidBody.drag = 0.0f;
			rigidBody.AddForce(moveVertical * transform.up * thrust * Time.deltaTime);
			showEngineEffects();
		} else {
			rigidBody.drag = drag;
			hideEngineEffects();
		}
	}

	void showEngineEffects() {
		engineEffects.gameObject.SetActive(true);
	}

	void hideEngineEffects() {
		engineEffects.gameObject.SetActive(false);
	}
}

using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float thrust;
	public float yaw;

	private Rigidbody2D rigidBody;
	private float drag = 0.4f;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		transform.Rotate(new Vector3(0, 0, -moveHorizontal * yaw * Time.deltaTime));

		if (moveVertical != 0) {
			rigidBody.drag = 0.0f;
			rigidBody.AddForce(moveVertical * transform.up * thrust * Time.deltaTime);
		} else {
			rigidBody.drag = drag;
		}
	}
}

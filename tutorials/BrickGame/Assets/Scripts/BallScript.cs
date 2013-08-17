using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(50f, -300f, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Die() {
		Destroy(gameObject);
		// GameObject paddle = GameObject.Find("Paddle");
		// PaddleScript paddleScript = paddle.GetComponent<PaddleScript>();
	}
	
}

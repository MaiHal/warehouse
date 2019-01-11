using UnityEngine;
using System.Collections;

public class PlayerScript_03 : MonoBehaviour {

	Rigidbody2D _rigidbody;

	public float jumpPower = 8.0f;

	// Use this for initialization
	void Start () {
		_rigidbody = transform.GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButton(0)){
			Jump();
		}
			
	}

	void Jump(){
		_rigidbody.velocity = Vector3.up * jumpPower;
	}
}

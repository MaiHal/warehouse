using UnityEngine;
using System.Collections;

public class PlayerScript_01 : MonoBehaviour {

	public float moveRange = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){

			float posX =   Input.mousePosition.x / Screen.width;
			posX = posX * moveRange - moveRange / 2.0f;

			transform.position = new Vector3(posX, 0.0f, 0.0f);

		}
	}
}

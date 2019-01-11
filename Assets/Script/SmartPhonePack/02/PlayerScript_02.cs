using UnityEngine;
using System.Collections;

public class PlayerScript_02 : MonoBehaviour {

	public float moveRangeX = 10f;
	public float moveRangeY = 10f;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){

			float posX =   Input.mousePosition.x / Screen.width;
			float posY =   Input.mousePosition.y / Screen.height;

			posX = posX * moveRangeX - moveRangeX / 2.0f;
			posY = posY * moveRangeY - moveRangeY / 2.0f;


			transform.position = new Vector3(posX, posY, 0.0f);

		}
	}
}

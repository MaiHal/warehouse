using UnityEngine;
using System.Collections;

public class PlayerScript_04 : MonoBehaviour {

	public Vector3 fromPos;
	public Vector3 toPos;
	public Light _light;
	public float speed = 4f;
	bool flag = false;
	float timer = 0f;

	// Use this for initialization
	void Start () {
		print( Mathf.Atan(1f) / Mathf.PI * 180f);
	}
	
	// Update is called once per frame
	void Update () {
		if(flag){
			transform.position += transform.up * speed * Time.deltaTime;
			timer += Time.deltaTime;
			if(timer > 0.7f){
				flag = false;
				_light.intensity = 0f;
				timer = 0f;
			}
		}

		if(Input.GetMouseButtonDown(0)){
			fromPos = Input.mousePosition;
		}
			
		if(Input.GetMouseButton(0)){
			toPos = Input.mousePosition;
			float dx = toPos.x - fromPos.x;
			float dy = toPos.y - fromPos.y;
			float distance = Mathf.Sqrt( dx * dx + dy * dy );
			float direction = ( Mathf.Atan2 (dy ,dx) / Mathf.PI * -180f );
			transform.eulerAngles = new Vector3(0,0,(360f - direction) -90f + 180f);
			_light.intensity = 8.0f * (distance / 100f);
		}

		if(Input.GetMouseButtonUp(0)){
			speed = (_light.intensity / 8.0f) * 4f;
			_light.intensity = 0f;
			flag = true;
		}
	
	}
}

using UnityEngine;
using System.Collections;

public class Build : MonoBehaviour {
   
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        GameObject parent = gameObject.transform.parent.gameObject;

            if ((col.gameObject.tag == "Player") && (col.gameObject != parent))
            {
                parent.tag = "bottomPlayer";
            }
    }

    void OnTriggerExit(Collider col)
    {
        GameObject parent = gameObject.transform.parent.gameObject;
        parent.tag = "Player";
    }
}

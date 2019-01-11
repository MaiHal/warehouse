using UnityEngine;
using System.Collections;

public class SelectUpdate3Child : MonoBehaviour {
    public Material lightb;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" || col.tag =="bottomPlayer")
        {
            var sobj = transform.parent.GetComponent<SelectUpdate3Parent>();

            sobj.count();

            float col_y = col.transform.localScale.y;
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y + col_y + 0.03f, this.transform.localPosition.z);
        }
    }

    public void changeColor()
    {
        
        Destroy(this);
    }
}

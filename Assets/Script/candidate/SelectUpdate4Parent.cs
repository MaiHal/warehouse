using UnityEngine;
using System.Collections;

public class SelectUpdate4Parent: MonoBehaviour {

    public int flag;

    // Use this for initialization
    void Start () {
        //selectedUpdate = this;
        flag = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void count()
    {
        flag++;
    }

    void OnTriggerStay(Collider col)
    {
        if (flag == 4)
        {
            float col_y = col.transform.localScale.y;
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y + col_y + 0.04f, this.transform.localPosition.z);
        }
        else
        {
            GetComponent<Renderer>().tag = "Untagged";

        }
        flag = 0;
    }
}

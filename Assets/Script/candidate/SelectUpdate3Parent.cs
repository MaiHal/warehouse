using UnityEngine;
using System.Collections;

public class SelectUpdate3Parent : MonoBehaviour
{
    public Material lightb;
    public Material purple;
    public int flag;
    public int color;
    // Use this for initialization
    void Start()
    {
        flag = 0;
        color = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void count()
    {
        flag++;
        //Debug.Log(f);
    }

    void OnTriggerStay(Collider col)
    {
        if (flag == 4)
        {
            float col_y = col.transform.localScale.y;
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y + col_y + 0.03f, this.transform.localPosition.z);
            color++;
        }
        else
        {
            GetComponent<Renderer>().tag = "Untagged";
            GetComponent<Renderer>().material.color = lightb.color;

            Destroy(this);
        }
        flag = 0;
    }
}
using UnityEngine;
using System.Collections;

public class Color : MonoBehaviour {
    public Material red;
    public Material lightpurple;
    public Material purple;
    public Material blue;
    public Material aqua;
    public Material emeraldblue;
    public Material green;
    public Material lightgreen;
    public Material orange;
    public Material yellow;
 
    public static int c;
    
    // Use this for initialization
    void Start () {

            c = Random.Range(0, 10);
        //Debug.Log(c);

            switch (c)
            {
                case 0:
                    GetComponent<Renderer>().material.color = red.color;
                    break;
                case 1:
                    GetComponent<Renderer>().material.color = lightpurple.color;
                    break;
                case 2:
                    GetComponent<Renderer>().material.color = purple.color;
                    break;
                case 3:
                    GetComponent<Renderer>().material.color = blue.color;
                    break;
                case 4:
                    GetComponent<Renderer>().material.color = aqua.color;
                    break;
                case 5:
                    GetComponent<Renderer>().material.color = emeraldblue.color;
                    break;
                case 6:
                    GetComponent<Renderer>().material.color = green.color;
                    break;
                case 7:
                    GetComponent<Renderer>().material.color = lightgreen.color;
                    break;
                case 8:
                    GetComponent<Renderer>().material.color = orange.color;
                    break;
                case 9:
                    GetComponent<Renderer>().material.color = yellow.color;
                    break;
            }
            gameObject.SendMessage("colorhozon",c);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

}

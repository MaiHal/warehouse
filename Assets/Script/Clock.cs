using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Clock : MonoBehaviour {
    
    public Text minLabel;
    public int min = 0;
    public float minA = 0;
    public float hour = 0;
    public float hourA = 0.0f;
    public Text hourLabel;
    public static int color = 0;

    public Material red;
    public Material lightpurple;
    public Material purple;
    public Material blue;
    public Material aqua;
    public Material emeraldblue;
    public Material green;
    public Material lightgreen;
    public Material yellow;
    public Material orange;

    // Use this for initialization
    void Start () {
        minLabel.text = "0";
        hourLabel.text = "0";
    }
	
	// Update is called once per frame
	void Update () {
        
        
            minA += Time.deltaTime;
            hourA += Time.deltaTime;
       
        min = (int)(Math.Floor(minA)) * 5;
        if (min == 60)
        {
            min = 0;
            minA = 0;
            color++;
            changecolor(color);

        }

        
        hour = 8 + (int)(Math.Floor(hourA /12));
        hourLabel.text = hour.ToString("f0") + " :   ";

        if (min == 0 || min == 5)
        {
            minLabel.text = "0" + min.ToString("f0");
        }
        else
        {
            minLabel.text = min.ToString("f0");
        }

        hourLabel.text = hour.ToString("f0") + " :     ";

        if(hour == 18)
        {
            Application.LoadLevel("Finish");
        }
	}

    void changecolor(int c)
    {
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
                GetComponent<Renderer>().material.color = yellow.color;
                break;
            case 9:
                GetComponent<Renderer>().material.color = orange.color;
                break;
        }

    }
}

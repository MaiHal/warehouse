using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class Select : MonoBehaviour {
    public GameObject plane1;
    public GameObject plane2;
    public GameObject plane3;
    public GameObject plane4;
    public float clickObj_x;
    public float clickObj_z;
    public int i, j;

    public GameObject[,] p1 = new GameObject[20, 5];
    public GameObject[,] p2 = new GameObject[20, 5];
    public GameObject[,] p3 = new GameObject[20, 5];
    public GameObject[,] p4 = new GameObject[20, 5];

    public int num_x;
    public int num_z;
    
    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update() {

    }

    //候補地を生成する
    public void candidate(GameObject obj)
    {
        clickObj_x = obj.transform.localScale.x;
        clickObj_z = obj.transform.localScale.z;

        num_x = (int)(Math.Floor(20 / clickObj_x));
        num_z = (int)(Math.Floor(5 / clickObj_z));

        if (clickObj_x == 1)
        {
            for (i = 0; i < num_x ; i++)
            {
                for (j = 0; j < num_z ; j++)
                {
                    p1[i,j] = Instantiate(plane1, new Vector3(-9.5f + (float)(i), 0.02f, 2 - j), Quaternion.identity) as GameObject;
                    p2[i,j] = Instantiate(plane2, new Vector3(-9.49f + (float)(i), 0.03f, 2 - j), Quaternion.identity) as GameObject;
                }
            }
        }
        else if(clickObj_x == 2)
        {
            for (i = 0; i < num_x; i++)
            {
                for (j = 0; j < num_z; j++)
                {
                    p3[i,j] = Instantiate(plane3, new Vector3(-9 + (float)(2*i), 0.02f, 1.5f - 2*j), Quaternion.identity) as GameObject;
                    p4[i,j] = Instantiate(plane4, new Vector3(-8.99f + (float)(2*i), 0.03f, 1.5f - 2*j), Quaternion.identity) as GameObject;

                }
            }
        }
    }

    //候補地を消す
    public void destroy()
    {
        for (int i = 0; i < num_x; i++)
        {
            for (int j = 0; j < num_z; j++)
            {
                GameObject.Destroy(p1[i,j]);
                GameObject.Destroy(p2[i, j]);
                GameObject.Destroy(p3[i, j]);
                GameObject.Destroy(p4[i, j]);
            }
        
        }
    }
}

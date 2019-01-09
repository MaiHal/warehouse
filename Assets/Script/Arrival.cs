using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Arrival : MonoBehaviour {
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube4;
    public GameObject cube8;
    List<GameObject> c = new List<GameObject>();
   


    // Use this for initialization
    void Start () {
        
        arrive();      
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void arrive(){
     for (int i = 0; i< 4; i++)
        {
            
                int d = Random.Range(0, 4);
                switch (d)
                {
                    case 0:
                        c.Add(Instantiate(cube1, new Vector3(-9 + i * 3, 0.5f, -4), Quaternion.identity) as GameObject);
                        break;
                    case 1:
                        c.Add(Instantiate(cube2, new Vector3(-9 + i * 3, 1, -4), Quaternion.identity) as GameObject);
                        break;
                    case 2:
                        c.Add(Instantiate(cube4, new Vector3(-9 + i * 3, 0.5f, -4), Quaternion.identity) as GameObject);
                        break;
                    case 3:
                        c.Add(Instantiate(cube8, new Vector3(-9 + i * 3, 1, -4), Quaternion.identity) as GameObject);
                        break;
                } 

            ScoreScript.pluspoint(20);
        }
        
        Invoke("arrive", 12);
    }
}

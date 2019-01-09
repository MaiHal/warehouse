﻿using UnityEngine;
using System.Collections;

public class SelectUpdate4Child : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" || col.tag == "bottomPlayer")
        {
            var sobj = transform.parent.GetComponent<SelectUpdate4Parent>();
            sobj.count();

            float col_y = col.transform.localScale.y;
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y + col_y + 0.04f, this.transform.localPosition.z);
        }
    }
}

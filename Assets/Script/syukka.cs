using UnityEngine;
using System.Collections;

public class syukka : MonoBehaviour {
    public float timer = 0;
    public static int color = 0;
    int cubecolor;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        full();
        timer += Time.deltaTime;
	}

    void full()
    {
        float height = this.transform.localPosition.y + this.transform.localScale.y/2;
        if (8.0 < height)
        {
            Invoke("destroy", 0.5f);
        }
    }

    void OnTriggerStay(Collider col)
    {
        //まだ倉庫に格納されていないものとぶつかったら消して減点
            if ((col.tag == "Player") && (timer < 0.01))
            {
                Invoke("destroy", 0.3f);
                ScoreScript.pluspoint(-40);
            }
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "start")
        {
            Invoke("replace", 0.5f);
        }

        if (col.tag == "end")
        {
            Debug.Log(this.cubecolor);
            Debug.Log(Clock.color);

            if (this.cubecolor == Clock.color)
            {
                GetComponent<AudioSource>().Play();
                ScoreScript.pluspoint(100);
            }
            else
            {
                ScoreScript.pluspoint(-60);
            }

            Invoke("destroy", 3);
        }
    }

    //キューブを消す
    void destroy()
    {
        Object.Destroy(gameObject);
    }

    void replace()
    {
        gameObject.tag = "Player";
    }

    void colorhozon(int c)
    {
        cubecolor = c;
    }
}

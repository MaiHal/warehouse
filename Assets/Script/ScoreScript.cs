using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public Text scoreLabel;
    public static int score = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        scoreLabel.text = score.ToString();
    }

    public static void pluspoint(int point)
    {
        score += point;
    }

}

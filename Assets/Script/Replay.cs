using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour
{
    public GameObject clickObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) //1回目にクリックされたら
        {

            Ray ray1 = Camera.main.ScreenPointToRay(Input.mousePosition); //クリックした点にRayを飛ばす
            RaycastHit hit1 = new RaycastHit(); //rayが当たったものの色々な情報

            if (Physics.Raycast(ray1, out hit1)) //rayが当たったら
            {
                clickObject = hit1.collider.gameObject; //当たったgameobject情報をobjに代入

                if (clickObject.tag == "replay")
                {
                    ScoreScript.score = 0;
                    Application.LoadLevel("main");
                }
            }

        }
    }
}

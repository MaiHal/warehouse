using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Move : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube4;
    public GameObject cube8;
    public GameObject SelectPosition;
    public GameObject plane1;



    private GameObject clickObject;
    private GameObject clickSpace;

    int flag = 0;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && flag == 0) //1回目にクリックされたら
        {

            Ray ray1 = Camera.main.ScreenPointToRay(Input.mousePosition); //クリックした点にRayを飛ばす
            RaycastHit hit1 = new RaycastHit(); //rayが当たったものの色々な情報

            if (Physics.Raycast(ray1, out hit1) && flag == 0) //rayが当たったら
            {
                clickObject = hit1.collider.gameObject; //当たったgameobject情報をobjに代入

                if (clickObject.tag == "Player")
                {
                    GetComponent<AudioSource>().Play();
                  
                    clickObject.tag = "bottomPlayer";
                    SelectPosition.SendMessage("candidate", clickObject);
                    flag = 1;
                }
            }
        }else if (Input.GetMouseButtonDown(0) && flag == 1) //2回目にクリックされたら
        {
            Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit2 = new RaycastHit();

            if (Physics.Raycast(ray2, out hit2) && flag == 1) //rayが当たったら
            {
                clickSpace = hit2.collider.gameObject;

                if (clickSpace.tag == "plane")
                {
                    GetComponent<AudioSource>().Play();

                    clickObject.transform.position = new Vector3(clickSpace.transform.localPosition.x, clickSpace.transform.localPosition.y + (clickObject.transform.localScale.y / 2) - 0.06f, clickSpace.transform.localPosition.z);
                    clickObject.tag = "Player";
                    flag = 0;
                    SelectPosition.SendMessage("destroy");
                    if(clickObject.transform.localScale.x == 2)
                    {
                        ScoreScript.pluspoint(40);
                    }
                    else
                    {
                        ScoreScript.pluspoint(60);
                    }
                }
                else if (clickSpace.tag == "end")
                {
                    clickObject.transform.position = new Vector3(clickSpace.transform.localPosition.x, clickSpace.transform.localPosition.y + (clickObject.transform.localScale.y / 2) - 0.05f, clickSpace.transform.localPosition.z);

                    flag = 0;
                    SelectPosition.SendMessage("destroy");

                }
          
            }
        }

    }
}




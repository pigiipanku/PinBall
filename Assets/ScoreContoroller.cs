using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreContoroller : MonoBehaviour {

    private GameObject score;
    float sss=0;
	void Start () {
        this.score = GameObject.Find("Score");
        
    }
	
	// Update is called once per frame
	void Update () {
        this.score.GetComponent<Text>().text = string.Format("{0}", sss);
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            sss += 810;
        }
        else if( collision.gameObject.tag == "LargeStarTag")
        {
            sss += 1919;
        }
        else if (collision.gameObject.tag == "SmallCloudTag" || collision.gameObject.tag == "LargeCloudTag")
        {
            sss += 114514;
        }
    }
}


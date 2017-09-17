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
        if (tag == "SmallStarTag")
        {
            sss += 810;
        }
        else if (tag == "LargeStarTag")
        {
            sss += 1919;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            sss += 114514;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{


    private GameObject scoreText;
    
    int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find ("Score");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddScore(int addscore)
    {
        score += addscore;
        this.scoreText.GetComponent<Text>().text = score + "point";
    }
     void OnCollisionEnter(Collision other)
    {



        if (other.gameObject.tag == "SmallStarTag")
        {
            AddScore(100);
        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            AddScore(50);
        }

        if (other.gameObject.tag == "SmallCloudTag")
        {
            AddScore(30);
        }

        if (other.gameObject.tag == "LargeCloudTag")
        {
            AddScore(10);
        }
       
       

    }

}


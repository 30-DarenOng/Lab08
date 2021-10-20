using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollector : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreText.text = ("Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            score++;
            ScoreText.text = ("Score: " + score);
            Destroy(collision.gameObject);
            
        }
    }
}

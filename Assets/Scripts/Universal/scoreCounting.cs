using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounting : MonoBehaviour
{
    public scrip jump;
    // Start is called before the first frame update
    private int score = 0;
    public Text displayText;
    void Start()
    {
        displayText.text = "your current score is: 0";
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text = "your current score is : " + score;   
    }
    public void AddScore() {
        score = score + 10;
        jump.applyForce();
    }
    public int GetScore() {
        return score;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textAction : MonoBehaviour {

    public Text changingText;
    public scoreCounting score;
    private int ran1;
    private int ran2;
    public Text[] buttons;
    public Text display;
    public static string selectedAnswer;
    public static string choiceSelected = "n";
    private string correctName;
    private int num;
    public static string inputText;
    public string correctText;
    public string[] positiveText = {"YAY YOU GOT IT RIGHT", "CORRECT!!", "THAT'S RIGHT!","YOU GO GIRL!","YIPPEE"};
    public string[] negativeText = {"TOO BAD","TRY AGAIN","YOU CAN DO THIS!", "BETTER LUCK NEXT TIME","BOOOO"};


    void Start () {

    }

    void Update () {
        int name = num + 1;
        correctName = name.ToString();
        correctText = GetResult().ToString();
    }

    public void TextChange () {

        num = Random.Range(0,3);
        if(score.GetScore() <= 100){
            int random1 = Random.Range(0,10);
            int random2 = Random.Range(0,10);
            ran1 = random1;
            ran2 = random2;
            changingText.text = "What is " + random1 + " + " + random2 + " ?";
        }
        if(score.GetScore() > 100)
        {
            MonoBehaviour.print("test");
            int randomA = Random.Range(10,100);
            int randomB = Random.Range(10,100);
            ran1 = randomA;
            ran2 = randomB;
            changingText.text = "What is " + randomA + " + " + randomB + " ?";
            //harderQuestions();
        }
    }

    /* public void harderQuestions () {
            int randomA = Random.Range(10,100);
            int randomB = Random.Range(10,100);
            ran1 = randomA;
            ran2 = randomB;
            changingText.text = "What is " + randomA + " + " + randomB + " ?";
    }*/

    public int GetResult () {
        return ran1 + ran2;
    }

    public void GetCorrect() {
        buttons[num].text = GetResult().ToString();
        int count = 0;
        foreach(Text current in buttons){
            if(count != num && num != GetResult()){
                current.text= Random.Range(0,10).ToString();
            }
            count++;
        }
    }

    public bool AssertAns(){

        if(selectedAnswer==correctName || inputText == correctText)
        {
            int randomText = Random.Range(0, 5);
            display.text = positiveText[randomText];
            score.AddScore();
            return true;
        }
        else{
            int randomText = Random.Range(0, 5);
            display.text = negativeText[randomText];
            return false;
        }

    }   
}
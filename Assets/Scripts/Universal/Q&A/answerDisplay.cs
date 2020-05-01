using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class answerDisplay : MonoBehaviour
{
    public scoreCounting board;
    public GameObject inputBox;
    public GameObject submitButton;
    public GameObject currentB;
    public Button button;
    private string orderName;
    public textAction action;
    public InputField input;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        if(board.GetScore() < 100){
            inputBox.SetActive(false);
            submitButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        upGrade();
    }
    // public void Change(){
    //     if (action != null){
    //     answer.text = action.GetResult().ToString();
    //     }
    //     else{
    //         Random wrongNum = new Random();
    //         answer.text = wrongNum.Next(0,10).ToString();
    //     }
    // }

    public bool checkInclude() {
        return false;
    }

    public void upGrade() {
        if(board.GetScore() > 100){
            currentB.SetActive(false);
            inputBox.SetActive(true);
            submitButton.SetActive(true);
        }

    }
     void TaskOnClick(){
        textAction.selectedAnswer = EventSystem.current.currentSelectedGameObject.name;    
        textAction.inputText = input.text;
        action.AssertAns();
        input.text = "Enter your answer...";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
//using Mono.Data.Sqlite;

public class RegisterManager : MonoBehaviour
{
    private string connectionString;
    // Start is called before the first frame update
    void Start()
    {
        connectionString = "URI=file:" + Application.dataPath + "/Database/StudentData.sqlite";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void getData(){
    
    }

    private void getStudentData(){

    }

    private void getTeacherData() {

    }
}

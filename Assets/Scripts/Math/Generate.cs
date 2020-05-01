using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    int firstPart = 0;
    int secondPart = 0;

    // Start is called before the first frame update
    void Start()
    {
        firstPart = Random.Range( 0, 9 );
        secondPart = Random.Range( 0, 9 );
    }
    
    string randomEquation()
    {
        string chars = "+-";
        string returnString = "";
            
        for( int i = 0; i < chars.Length; i++ ) 
        {
            returnString += chars[ Random.Range( 0, chars.Length ) ];
        }
            
        return returnString;
    }
    
    void onGUI()
    {
        GUI.Label( new Rect( Screen.width / 2, Screen.height / 2, 500, 30 ), firstPart.ToString() );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

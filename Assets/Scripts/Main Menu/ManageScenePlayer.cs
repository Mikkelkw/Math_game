using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenePlayer : MonoBehaviour
{
    public scrip Player;
    
    void Update(){
        if (Player.onMoon()==false){
            ChangeScene("GG");
        }
    }
	public void ChangeScene( string sceneName )
	{
		SceneManager.LoadScene( sceneName );
	}
	public void Exit()
	{
		Application.Quit();
	}
}

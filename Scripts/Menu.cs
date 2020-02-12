//This script handles the scene transitions.
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {	
		Debug.Log(gameObject.name);
		switch(this.gameObject.name){
		case "Start":
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			break;
		case "Instant Replay":
			SceneManager.LoadScene("Level04");		
			break;
		}

    }

}

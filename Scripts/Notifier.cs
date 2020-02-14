using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notifier : MonoBehaviour
{
    //Animator animator;
    // Start is called before the first frame update
	public Text notificationText;

    void OnEnable()
    {
        Score.onBlazeIt += GiveMessage;
        //animator = GetComponent<Animator>();
    }

    private void OnDisable()
    {
        Score.onBlazeIt -= GiveMessage;
    }

    void GiveMessage(float distance)
	
    {
        notificationText.text  = "That's " + distance/420 + " 420's!";
		Invoke("erase",1f);
		

	}
	void erase()
	
    {
        notificationText.text  = " ";

	}
	
	
}

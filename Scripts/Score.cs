//This script handles the scoring system of the game.
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	//Define public variables
	public delegate void BlazeIt(float targetIncrement);
	public static event BlazeIt onBlazeIt;
	public Transform player;
	public Text scoreText;
	public float targetIncrement = 420f;
//	public Text CommandText;
	//Command command;
	
	
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); 
		
		if (player.position.z >= targetIncrement)
		{
			onBlazeIt(targetIncrement);
            targetIncrement += 420;
			Debug.Log(targetIncrement);
		}
		
		//As the player travels further on the z axis, their score will increase.
		//if(CommandLog.commands.Count > 0)
		//{
			//Debug.Log(CommandLog.commands.Count);
		//	command = CommandLog.commands.Dequeue();
		//	CommandText.text = command.ToString();
//			Debug.Log(ToString(command));
		//	Debug.Log(CommandLog.commands.Count);
		//}
		
    }
}

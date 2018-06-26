using UnityEngine;
using System.Collections;

public class GameControll : MonoBehaviour {
	public bool gameClear = false;

	void Update()
	{
		if(gameClear){
				Application.LoadLevel("clear");
			}
			return;
	}

	public void GameClear()
	{
		gameClear = true;
	}
}

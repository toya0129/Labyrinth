using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{
	GameControll gameRuleCtrl;

	void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player")) {

			Destroy(gameObject);

			gameRuleCtrl = GameObject.FindObjectOfType(typeof(GameControll)) as GameControll;

			gameRuleCtrl.GameClear ();

		}
	}
}


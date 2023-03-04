using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
	public Text notificationText;

	public void ClickButton()
	{
		StartCoroutine(SendNotification("Plase enter the password to boot the spaceship", 3));
	}

	IEnumerator SendNotification(string text, int time)
	{
		notificationText.text = text;
		yield return new WaitForSeconds(time);
		notificationText.text = "";
	}
}

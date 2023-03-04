using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EarthMessage : MonoBehaviour
{
    // Start is called before the first frame update


    public Text notificationText;

    public void Start()
    {


        StartCoroutine(SendNotification("Congratulations! You made it to earth!", 10));

    }


    IEnumerator SendNotification(string text, int time)
    {
        notificationText.text = text;
        yield return new WaitForSeconds(time);
        notificationText.text = "";
    }


}

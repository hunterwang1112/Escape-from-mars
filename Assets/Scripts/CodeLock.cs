using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CodeLock : MonoBehaviour
{
    int codeLength;
    int placeInCode;
    public Text notificationText;

    public string code = "";
    public string attemptedCode;

    [PunRPC]
    private void Start()
    {
        codeLength = code.Length;
    }

    [PunRPC]
    public void SetValue(string value)
    {
        placeInCode++;

        if (placeInCode <= codeLength)
        {
            attemptedCode += value;
        }

        if (placeInCode == codeLength)
        {
            CheckCode();
            attemptedCode = "";
            placeInCode = 0;
        }
    }

    [PunRPC]
    public void CheckCode()
    {
        if (attemptedCode == code)
        {
            Debug.Log("Correct Code!");
            NotificationRPC();
            //StartCoroutine(SendNotification("Congratulations! Now you can boot the spaceship", 3));
            PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);

            GameObject loader = GameObject.Find("LevelLoader");
            LevelLoader script = (LevelLoader)loader.GetComponent(typeof(LevelLoader));
            script.LoadNextLevel();
        }
        else
        {
            Debug.Log("Wrong Code!");
            StartCoroutine(SendNotification("The password you entered is wrong. Please try again.", 3));
        }
    }

    [PunRPC]
    public void NotificationRPC()
    {
        StartCoroutine(SendNotification("Congratulations! Now you can boot the spaceship", 3));
    }

    [PunRPC]
    IEnumerator SendNotification(string text, int time)
    {
        notificationText.text = text;
        yield return new WaitForSeconds(time);
        notificationText.text = "";
    }
}

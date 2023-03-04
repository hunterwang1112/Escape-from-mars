using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class AircraftTrigger : MonoBehaviour
{
    public Text notificationText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            NotificationRPC();
            //StartCoroutine(SendNotification("Congratulations! You find the spaceship!", 3));
            GameObject loader = GameObject.Find("LevelLoader");
            LevelLoader script = (LevelLoader)loader.GetComponent(typeof(LevelLoader));
            script.LoadNextLevel();
        }
    }

    [PunRPC]
    public void NotificationRPC()
    {
        StartCoroutine(SendNotification("Congratulations! You find the spaceship!", 3));
    }

    IEnumerator SendNotification(string text, int time)
    {
        notificationText.text = text;
        yield return new WaitForSeconds(time);
        notificationText.text = "";
    }


    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}

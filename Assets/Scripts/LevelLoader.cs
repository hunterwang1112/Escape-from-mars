using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        // right click to transit to the next scene
        //if (Input.GetMouseButtonDown(1) && SceneManager.GetActiveScene().name != "Earth")
        //{
        //    LoadNextLevel();
        //}

    }

    public void LoadNextLevel() {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        //SceneManager.LoadScene(levelIndex);
        if (SceneManager.GetActiveScene().name == "Mars")
        {
            SceneManager.LoadScene("InsideSpaceship");
            //PhotonNetwork.AutomaticallySyncScene = true;
            //PhotonNetwork.LoadLevel("InsideSpaceship");
        }
        else if (SceneManager.GetActiveScene().name == "InsideSpaceship")
        {
            SceneManager.LoadScene("Earth");
            //PhotonNetwork.AutomaticallySyncScene = true;
            //PhotonNetwork.LoadLevel("Earth");
        }
        else
        {
            SceneManager.LoadScene("Lobby");
            //PhotonNetwork.AutomaticallySyncScene = true;
            //PhotonNetwork.LoadLevel("Lobby");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    private void Start()
    {
        //starting the process of connecting to the server
        PhotonNetwork.ConnectUsingSettings();
    }

    //Success connected and load up Main Menu
    public override void OnConnectedToMaster() {
        SceneManager.LoadScene("Main Menu");
    }

}

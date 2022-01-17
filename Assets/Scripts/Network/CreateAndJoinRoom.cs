using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using System;


public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{
    public InputField joinInput;

    string RoomName;
    public Text RoomID;
    bool Joined = false;
    bool OnJoinedaRoom = false;

    private void Start()
    {
        Joined = false;
    }
    public void CreateRoom()
    {
        RoomOptions opts = new RoomOptions();
        opts.MaxPlayers = 3;
        RoomName = RandomStringGenerator();
        PhotonNetwork.CreateRoom( "hana" , opts);
    }
    public void JoinRoom()
    {
        Debug.Log("Here");
        PhotonNetwork.JoinRoom("hana");
        OnJoinedaRoom = true;
        
    }
    public override void OnJoinedRoom()
    {
        Debug.Log(RoomName);
        RoomID.text = "Room ID - " + "hana";
        Joined = true;
        if(OnJoinedaRoom == true)
        {
            StartClicked();
        }
    }
    public void StartClicked()
    {
        if (Joined == true)
        {
            Debug.Log("clicked");
            PhotonNetwork.LoadLevel("GameScenario");
        }
    }
     public string RandomStringGenerator()
    {
        Guid g = Guid.NewGuid();
        string GuidString = Convert.ToBase64String(g.ToByteArray());
        GuidString = GuidString.Replace("=", "");
        GuidString = GuidString.Replace("+", "");

        return GuidString;
    }
}

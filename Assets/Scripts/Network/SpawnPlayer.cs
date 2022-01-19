using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayer : MonoBehaviour
{
    public GameObject Big;
    public GameObject Tall;
    public GameObject Small;

    float X , Y;
    
    void Start()
    {
        X = -5.27f;
        Y = 0.27f;

        Vector2 Position = new Vector2(X, Y);

        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            PhotonNetwork.Instantiate(Big.name, Position, Quaternion.identity);
        }
        if(PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            PhotonNetwork.Instantiate(Tall.name, Position, Quaternion.identity);
        }
        if(PhotonNetwork.CurrentRoom.PlayerCount == 3)
        {
            PhotonNetwork.Instantiate(Small.name, Position, Quaternion.identity);
        }
        
    }
   
}

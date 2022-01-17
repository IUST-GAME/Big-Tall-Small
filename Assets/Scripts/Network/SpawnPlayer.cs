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
    
    public List<int> randomList = new List<int>{ 1, 2, 3 };
    void Start()
    {
        X = -5.27f;
        Y = 0.27f;

        Vector2 Position = new Vector2(X, Y);

        if (randomList.Count == 1)
        {
            PhotonNetwork.Instantiate(Big.name, Position, Quaternion.identity);
            randomList.Remove(0);
        }
        if(randomList.Count == 2)
        {
            PhotonNetwork.Instantiate(Tall.name, Position, Quaternion.identity);
            randomList.Remove(1);
        }
        if(randomList.Count == 3)
        {
            PhotonNetwork.Instantiate(Small.name, Position, Quaternion.identity);
            randomList.Remove(2);
        }
        
    }
   
}

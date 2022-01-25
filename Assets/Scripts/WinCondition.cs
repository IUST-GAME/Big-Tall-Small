using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Repository;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    private bool isBigIn;
    private bool isSmallIn;
    private bool isTallIn;

    // Start is called before the first frame update
    void Start()
    {
        //PhotonNetwork.AutomaticallySyncScene = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBigIn & isTallIn & isSmallIn)
        {
            DontDestroyOnLoad(GameObject.FindWithTag("Big"));
            DontDestroyOnLoad(GameObject.FindWithTag("Tall"));
            DontDestroyOnLoad(GameObject.FindWithTag("Small"));
            
            PhotonNetwork.LoadLevel("Level02");
            //SceneManager.LoadScene("Level02");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Big"))
        {
            Debug.Log("big");
            isBigIn = true;
        }
        if (other.gameObject.CompareTag("Small"))
        {
            isSmallIn = true;
        }
        if (other.gameObject.CompareTag("Tall"))
        {
            isTallIn = true;
        }
    }
}

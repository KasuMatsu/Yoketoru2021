﻿#define DEBUG_KEY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TinyAudio.PlaySE(TinyAudio.SE.Menu_ugoki);
    }

    // Update is called once per frame
    void Update()
    {
#if DEBUG_KEY
        if(Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Gameover",LoadSceneMode.Additive);
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("Clear",LoadSceneMode.Additive);
        }
#endif
    }
}

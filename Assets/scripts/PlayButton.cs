using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] Button BtnPlay;
    void Start()
    {
        BtnPlay.onClick.AddListener(Play);
    }
    private void Play()
    {
        int IndexScene = PlayerPrefs.GetInt("LVL", 1);

        if (IndexScene == 0) 
        {
            PlayerPrefs.SetInt("LVL", 1);
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(IndexScene);
        }
    }
}

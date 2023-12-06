using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlended : MonoBehaviour
{
    [SerializeField] int Scene;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerPrefs.SetInt("LVL", Scene);
            SceneManager.LoadScene(Scene);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            Debug.Log(Scene);
            PlayerPrefs.SetInt("LVL", Scene);
            Debug.Log(PlayerPrefs.GetInt("LVL"));
            SceneManager.LoadScene(Scene);
        }
    }
}

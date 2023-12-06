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
            PlayerPrefs.SetInt("LVL", Scene);
            SceneManager.LoadScene(Scene);
        }
    }
}

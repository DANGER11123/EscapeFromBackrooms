using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class triggger : MonoBehaviour
{
    [SerializeField] AudioSource sound;
    [SerializeField] GameObject cube;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            sound.Play();
            cube.transform.position = new Vector3(0, -10, 0);
        }
    }
}

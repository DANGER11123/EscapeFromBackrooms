using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class truba : MonoBehaviour
{
    [SerializeField] AudioSource sound;
    [SerializeField] BoxCollider bc;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Player")
        {
            sound.Play();
            bc.enabled = false;
        }
    }
}

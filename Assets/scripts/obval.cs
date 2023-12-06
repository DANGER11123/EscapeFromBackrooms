using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obval : MonoBehaviour
{
    [SerializeField] GameObject zaval;
    [SerializeField] AudioSource audio;
    bool obvval;
    private void OnTriggerEnter(Collider other)
    {
        if (obvval == false)
        {
            zaval.SetActive(true);
            audio.Play();
            obvval = true;
        }
    }
}

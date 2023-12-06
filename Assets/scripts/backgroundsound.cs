using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundsound : MonoBehaviour
{
    [SerializeField] private AudioSource sound;
    private void Awake()
    {
        StartCoroutine(RepeaterSound());
    }
    IEnumerator RepeaterSound() 
    {
        while (true) 
        {
            yield return new WaitForSeconds(2);
            sound.Play();
        }
    }
}

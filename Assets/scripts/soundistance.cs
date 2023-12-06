using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundistance : MonoBehaviour
{
    private AudioSource AudioSource;
    [SerializeField] GameObject Player;
    [SerializeField] float maxDistance=100f;
    private void Awake()
    {
         AudioSource = this.GetComponent<AudioSource>();
    }
    void Update()
    {
        float distance = Vector3.Distance(this.transform.position,Player.transform.position);
        if(distance<=maxDistance)
        {
            AudioSource.volume = 1f-distance/maxDistance;
            if(!AudioSource.isPlaying)
            {
                AudioSource.Play();
            }
        }
        else
        {
            AudioSource.Stop();
        }
    }
}

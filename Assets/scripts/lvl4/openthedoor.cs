using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openthedoor : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject wire;
    [SerializeField] GameObject Object1;
    [SerializeField] GameObject Object2;
    [SerializeField] AudioSource sound;
    [SerializeField] BoxCollider collider;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Player" && Object1.transform.position.y * Object2.transform.position.y==-12*-12)
        {
            door.SetActive(false);
            wire.SetActive(true);
            collider.enabled= false;
            sound.Play();
        }
    }
}

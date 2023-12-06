using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakwood : MonoBehaviour
{
    [SerializeField] BoxCollider bc;
    [SerializeField] MeshRenderer mr;
    [SerializeField] AudioSource sound;
    [SerializeField] GameObject IsHunting;
    private void OnCollisionEnter(Collision collision)
    {
        if(IsHunting.transform.position== new Vector3(0,-10,0)&&collision.collider.transform.tag=="Player")
        {
            bc.enabled = false;
            mr.enabled = false;
            sound.Play();
        }
    }
}

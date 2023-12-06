using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pogona : MonoBehaviour
{
    [SerializeField] GameObject IsHunting;
    private void OnTriggerEnter(Collider other)
    {
        IsHunting.transform.position = new Vector3(0,-10,0);
    }
}

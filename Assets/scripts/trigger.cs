using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    [SerializeField] GameObject objecte;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            objecte.transform.position = new Vector3(0, -10, 0);
        }
    }
}

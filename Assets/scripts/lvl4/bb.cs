using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bb : MonoBehaviour
{
    [SerializeField] GameObject ylibaki;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag =="Player")
        {
            ylibaki.SetActive(false);
        }
    }
}

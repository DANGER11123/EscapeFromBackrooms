using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickeduped : MonoBehaviour
{
    [SerializeField] GameObject Object;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            Object.transform.position = new Vector3(0, -12, 0);
            this.gameObject.SetActive(false);
        }
    }
}

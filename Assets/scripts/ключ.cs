using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ключ : MonoBehaviour
{
    [SerializeField]GameObject Door;
    [SerializeField] AudioSource Sound;
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(KeyPickedUped());
    }
    IEnumerator KeyPickedUped()
    {
        Door.SetActive(false);
        Sound.Play();
        yield return new WaitForSeconds(2f);
        this.gameObject.SetActive(false);
    }
}

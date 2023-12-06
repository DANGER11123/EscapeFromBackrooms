using UnityEngine;

public class Pogona : MonoBehaviour
{
    [SerializeField] GameObject IsHunting;
    private void OnTriggerEnter(Collider other)
    {
        IsHunting.transform.position = new Vector3(0,-10,0);
    }
}

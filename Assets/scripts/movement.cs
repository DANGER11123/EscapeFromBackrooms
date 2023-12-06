using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class movement : MonoBehaviour
{
    [SerializeField] private float _speed = 7;
    [SerializeField] private float _sensitivity = 2;
    [SerializeField] private Rigidbody _rb;
    private float X;

    private void Awake()
    {
        _rb = _rb == null ? GetComponent<Rigidbody>() : _rb;
        Cursor.visible = false;
        Physics.defaultMaxDepenetrationVelocity = 100f;
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            MovePlayer(transform.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(-transform.forward);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(transform.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(-transform.right);
        }
    }

    private void Update()
    {
        X = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, X * _sensitivity, Space.World);
    }
    private void MovePlayer(Vector3 direction)
    {
        _rb.MovePosition(_rb.position + direction * Time.deltaTime * _speed);
    }
}

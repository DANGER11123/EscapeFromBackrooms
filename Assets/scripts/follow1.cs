using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class follow1 : MonoBehaviour
{
    [SerializeField] Transform Target;
    [SerializeField] GameObject IsHunting;
    bool isHunt;
    UnityEngine.AI.NavMeshAgent Ai;
    private void Start()
    {
        Ai = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        if (isHunt==false&&IsHunting.transform.position == new Vector3(0, -10, 0)) 
        {
            isHunt= true;
        }
        if(isHunt)
        {
            Ai.destination = Target.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class follow : MonoBehaviour
{
    [SerializeField]Transform Target;
    [SerializeField] GameObject objecte;
    UnityEngine.AI.NavMeshAgent Ai;
    [SerializeField] float maxdistance;
    bool Istriggred;
    private void Start()
    {
        Ai = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        if (objecte.transform.position == new Vector3(0, -10, 0)&&Istriggred==false) 
        {
            Istriggred= true;
        }
        if(Istriggred)
        {
            StartCoroutine(Follow());
        }
    }
    IEnumerator Follow()
    {
        Istriggred= false;
        objecte.transform.position += new Vector3(0, -1, 0);
        while(true) 
        {
            Ai.destination = Target.position;
            float Distance = Vector3.Distance(this.transform.position, Target.transform.position);
            while (Distance <= maxdistance)
            {
                Ai.destination = Target.position;
                yield return new WaitForSeconds(0.01f);
            }
            yield return new WaitForSeconds(10);
        }


    }
}

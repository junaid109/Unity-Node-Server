using UnityEngine;
using System.Collections;

public class Navigator : MonoBehaviour
{

    UnityEngine.AI.NavMeshAgent agent;
    Targeter targeter;
    Animator animator;

    void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        targeter = GetComponent<Targeter>();
    }

    public void NavigateTo(Vector3 position)
    {
        agent.SetDestination(position);
        targeter.target = null;
    }

    void Update()
    {
        GetComponent<Animator>().SetFloat("Distance", agent.remainingDistance);
    }
}

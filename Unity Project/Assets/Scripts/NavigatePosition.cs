using UnityEngine;
using UnityEngine.AI;

public class NavigatePosition : MonoBehaviour {

    NavMeshAgent agent;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}


    public void NavigateTo(Vector3 position)
    {
        agent.SetDestination(position);
    }

    private void Update()
    {
        GetComponent<Animator>().SetFloat("Distance", agent.remainingDistance);
    }
}

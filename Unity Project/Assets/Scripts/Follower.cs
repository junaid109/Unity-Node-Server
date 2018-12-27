using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follower : MonoBehaviour {

    public Targeter targeter;
    public Transform target;

    public float scanFrequency = 0.5f;

    public float stopFollowDistance = 2f;

    NavMeshAgent agent;

    float lastScanTime;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targeter = GetComponent<Targeter>();
    }

    private void Update()
    {
        if (isReadyToScan() && !targeter.IsInRange(stopFollowDistance))
        {
            Debug.Log("scanning nav path");
            agent.SetDestination(target.position);
        }
    }

    private bool isReadyToScan()
    {
        return Time.time - lastScanTime > scanFrequency && targeter.target;
    }

    private bool isInRange()
    {
      var distance = Vector3.Distance( target.position , transform.position);
      return distance < stopFollowDistance;
    }
}

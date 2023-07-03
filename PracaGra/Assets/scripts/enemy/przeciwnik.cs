using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class przeciwnik : MonoBehaviour
{
    public float zasieg = 10f;

    Transform target;
    NavMeshAgent agent;
     void Start()
    {
        target = gracz.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= zasieg)
        {
            agent.SetDestination(target.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, zasieg);
    }
}

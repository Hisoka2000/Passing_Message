using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    [SerializeField] private List<Transform> movePositionTransforms;
    private Transform currentMovePositionTransform;
    private int random;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //random = Random.Range(0, movePositionTransforms.Count - 1);
        currentMovePositionTransform = movePositionTransforms[0];
    }

    private void Update()
    {
        navMeshAgent.destination = currentMovePositionTransform.position;

        if(transform.position.x == currentMovePositionTransform.position.x && transform.position.z == currentMovePositionTransform.position.z)
        {
            random = Random.Range(0, movePositionTransforms.Count - 1);
            currentMovePositionTransform = movePositionTransforms[random];
        }
    }
}

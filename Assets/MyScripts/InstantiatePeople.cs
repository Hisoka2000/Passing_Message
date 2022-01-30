using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InstantiatePeople : MonoBehaviour
{
    [SerializeField] private List<GameObject> peopleLocations;
    [SerializeField] private List<GameObject> peoplePrefabs;

    int random;
    float randomCharacterSpeedOffset;

    private void Awake()
    {
        foreach(GameObject locationObject in peopleLocations)
        {
            random = Random.Range(0, peoplePrefabs.Count - 1);
            GameObject currentHuman = Instantiate(peoplePrefabs[random], locationObject.transform.position, Quaternion.identity);

            randomCharacterSpeedOffset = Random.Range(-1.5f, 1.5f);
            currentHuman.GetComponent<NavMeshAgent>().speed += randomCharacterSpeedOffset;

            currentHuman.GetComponent<Animator>().Play("Walking", 0, Random.value);
        }
    }
}

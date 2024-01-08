using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        GameObject _finish = GameObject.FindGameObjectWithTag("Finish");    //find the gameobject with the tag Finish
        GetComponent<NavMeshAgent>().SetDestination(_finish.transform.position);    //set the enemy's destination to the finish's postion
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nav : MonoBehaviour
{
    public Animator animator;
    private NavMeshAgent agent;
    private Vector3 posichange;
    private Vector2 moveer;
    Vector2 velocity = Vector2.zero;
     public bool movement=true;


    [SerializeField] private Transform dest;
    private void Awake()
    {
        animator = GetComponent<Animator>();    
        agent = GetComponent<NavMeshAgent>();
       
    }

    private void Update()
    {
        if (movement == true)
        {
            bool move = velocity.magnitude > 0.25f && agent.remainingDistance > agent.radius;
            animator.SetFloat("Blend", 0.3f, 0.15f, Time.deltaTime);
        }
        else
        {
           // animator.SetFloat("Blend", 0.0f, 0.0f, Time.deltaTime);
        }
        

       

    }
    private void OnAnimatorMove()
    {
        agent.destination = dest.position;
       //movement = false;
    }

}

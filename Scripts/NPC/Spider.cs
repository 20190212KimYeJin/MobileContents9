using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : StrongAnimal
{
    protected override void ReSet()
    {
        base.ReSet(); //기존의 부모 개체에 리셋을 실행시키고
    }

    
    public List<Transform> locations;
    public Transform patrolRoute;
    public Transform player; //목적지를 플레이어로

    private int locationIndex = 0;
    private UnityEngine.AI.NavMeshAgent agent;

    private int _lives = 3;
    public int EnemyLives
    {
        get { return _lives; }
        set
        {
            _lives = value;

            if (_lives <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.Find("Player").transform;
        InitializePatrolRoute();
        MoveToNextPatrolPoint();
    }

    void Update() //네개 지점 순찰하도록
    {
        if (agent.remainingDistance < 0.2f && !agent.pathPending)
        {
            MoveToNextPatrolPoint();
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            agent.destination = player.position; //플레이어에게 오도록
            Debug.Log("공격");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.name == "Player")
        {
            Debug.Log("공격 범위 이상");
        }
    }

    void InitializePatrolRoute()
    {
        foreach (Transform child in patrolRoute)
        {
            locations.Add(child);
        }
    }

    void MoveToNextPatrolPoint()
    {
        agent.destination = locations[locationIndex].position; //GUI

        locationIndex = (locationIndex + 1) % locations.Count;
        //locations.Count : location.list의 원소 개수(4개)
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "HitEffect(Clone)")
        {
            EnemyLives -= 1;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{

    [SerializeField]
    private string animalName;

    [SerializeField]
    private int hp;

    [SerializeField]
    private float walkSpeed;

    private Vector3 direction; //돼지 방향

    private bool isAction; //행동 여부 판별
    private bool isWalking; //걸음 여부 판별

    [SerializeField]
    private float walkTime;//걷는 시간

    [SerializeField]
    private float waitTime; //대기시간

    [SerializeField]
    private float currentTime; //대기시간

    //필요 컴포넌트
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private Rigidbody rigid;
    [SerializeField]
    private BoxCollider boxCol;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = waitTime;
        isAction = true; //행동중
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotation();
        ElapseTime(); //시간경과함수        
    }

    private void Move()
    {
        if (isWalking)
            rigid.MovePosition(transform.position + (transform.forward * walkSpeed * Time.deltaTime)); //1초에 walkspeed만큼 나아감
    }

    private void Rotation()
    {
        if (isWalking)
        {
            Vector3 _rotation = Vector3.Lerp(transform.eulerAngles, direction, 0.01f);
            //자기자신 위치(transform.eulerAngles), 목표
            rigid.MoveRotation(Quaternion.Euler(_rotation)); //벡터3를 쿼터니언으로 만들어 자연스러운 회전값
        }
    }

    private void ElapseTime()
    {
        if (isAction)
        {
            currentTime -= Time.deltaTime; //1초마다 깎음
            if(currentTime <= 0)
            {
                ReSet(); //다음 행동 개시
            }
        }
    }

    private void ReSet()
    {
        isWalking = false; //무한 걷기 막음
        isAction = true;
        direction.Set(0f, Random.Range(0f, 360f), 0f); // y값 자유 회전

        anim.SetBool("Walking", isWalking);
        RandomAction();
    }

    private void RandomAction()
    {
        int _random = Random.Range(0, 4); //랜덤한 행동을 하도록(대기, 먹기, 두리번, 걷기)

        if (_random == 0)
            Wait();

        else if (_random == 1)
            Eat();


        else if (_random == 2)
            Peek();


        else if (_random == 3)
            TryWalk();
    }

    private void Wait()
    {
        currentTime = waitTime;
        Debug.Log("대기");
    }

    private void Eat()
    {
        currentTime = waitTime;
        anim.SetTrigger("Eat");
        Debug.Log("먹기");
    }

    private void Peek()
    {
        currentTime = waitTime;
        anim.SetTrigger("Peek");
        Debug.Log("두리번");
    }

    private void TryWalk()
    {
        isWalking = true;
        anim.SetBool("Walking", isWalking);
        currentTime = walkTime;        
        Debug.Log("걷기");
    }
}

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

    [SerializeField]
    private float runSpeed;

    private float applySpeed;

    private Vector3 direction; //돼지 방향

    private bool isAction; //행동 여부 판별
    private bool isWalking; //걸음 여부 판별
    private bool isRunning; //뜀 판별
    private bool isDead; //죽음 판별

    [SerializeField]
    private float walkTime;//걷는 시간

    [SerializeField]
    private float waitTime; //대기 시간

    [SerializeField]
    private float runTime; //뛰는 시간

    private float currentTime; //대기 시간

    //필요 컴포넌트
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private Rigidbody rigid;
    [SerializeField]
    private BoxCollider boxCol;
    private AudioSource theAudio; //pan level custom에서 3d 사운드 조절

    [SerializeField]
    private AudioClip[] sound_pig;

    [SerializeField]
    private AudioClip sound_pig_hurt;

    [SerializeField]
    private AudioClip sound_pig_dead;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
        currentTime = waitTime;
        isAction = true; //행동중
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            Move();
            Rotation();
            ElapseTime(); //시간경과함수 
        }
               
    }

    private void Move()
    {
        if (isWalking || isRunning)
            rigid.MovePosition(transform.position + (transform.forward * applySpeed * Time.deltaTime)); //1초에 walkspeed만큼 나아감
    }

    private void Rotation()
    {
        if (isWalking || isRunning)
        {
            Vector3 _rotation = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, direction.y, 0f), 0.01f);
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
        isRunning = false;
        isAction = true;
        applySpeed = walkSpeed;
        direction.Set(0f, Random.Range(0f, 360f), 0f); // y값 자유 회전

        anim.SetBool("Walking", isWalking);
        anim.SetBool("Running", isRunning);
        //리셋할 때 뛰든 걷든 다 취소되게 만듦
        RandomAction();
    }

    private void RandomAction()
    {
        RandomSound();

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
        applySpeed = walkSpeed;
        Debug.Log("걷기");
    }

    public void Run(Vector3 _targetPos) //플레이어 반대방향으로 뛰도록
    {
        direction = Quaternion.LookRotation(transform.position - _targetPos).eulerAngles; //반대방향을 바라보도록, xz값은 설정되지 않게 해야함
        currentTime = runTime;
        isWalking = false;
        isRunning = true;
        applySpeed = runSpeed;
        anim.SetBool("Running", isRunning);
    }

    public void Damage(int _dmg, Vector3 _targetPos) //데미지 맞으면 런 호출하도록
    {
        if (!isDead)
        {
            hp -= _dmg;

            if (hp <= 0)
            {
                Dead();
                return;
            }

            PlaySE(sound_pig_hurt);
            anim.SetTrigger("Hurt");
            Run(_targetPos);
        }        
    }

    private void Dead()
    {
        PlaySE(sound_pig_dead);
        isWalking = false;
        isRunning = false;
        isDead = true;
        anim.SetTrigger("Dead");
    }

    private void RandomSound()
    {
        int _random = Random.Range(0, 3); //일상 사운드
        PlaySE(sound_pig[_random]);
    }

    private void PlaySE(AudioClip _clip)
    {
        theAudio.clip = _clip;
        theAudio.Play();
    }
}

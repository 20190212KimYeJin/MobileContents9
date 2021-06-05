using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //네비게이션 AI용

public class Animal : MonoBehaviour
{
    [SerializeField]
    private protected string animalName;

    [SerializeField]
    protected int hp;

    [SerializeField]
    protected float walkSpeed;

    [SerializeField]
    protected float runSpeed;
    //protected float applySpeed;

    //[SerializeField]
    //protected float turningSpeed; //회전속도

    protected Vector3 destination; //돼지 방향

    protected bool isAction; //행동 여부 판별
    protected bool isWalking; //걸음 여부 판별
    protected bool isRunning; //뜀 판별
    protected bool isDead; //죽음 판별

    [SerializeField]
    protected float walkTime;//걷는 시간

    [SerializeField]
    protected float waitTime; //대기 시간

    [SerializeField]
    protected float runTime; //뛰는 시간

    protected float currentTime; //대기 시간

    [SerializeField]
    private float destroyTime; //삭제 시간

    //필요 컴포넌트
    [SerializeField]
    protected Animator anim;
    [SerializeField]
    protected Rigidbody rigid;
    [SerializeField]
    protected BoxCollider boxCol;
    protected AudioSource theAudio; //pan level custom에서 3d 사운드 조절
    protected NavMeshAgent nav; //네비게이션

    [SerializeField]
    protected AudioClip[] sound_normal;

    [SerializeField]
    protected AudioClip sound_hurt;

    [SerializeField]
    protected AudioClip sound_dead;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
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
            ElapseTime(); //시간경과함수 
        }

    }

    protected void Move()
    {
        if (isWalking || isRunning)
            //rigid.MovePosition(transform.position + (transform.forward * applySpeed * Time.deltaTime)); //1초에 walkspeed만큼 나아감
            nav.SetDestination(transform.position + destination * 5f); //네비 자체에 방향을 설정함, 5배 정도 더 멀리 도망가도록
    }

    protected void ElapseTime()
    {
        if (isAction)
        {
            currentTime -= Time.deltaTime; //1초마다 깎음
            if (currentTime <= 0)
            {
                ReSet(); //다음 행동 개시
            }
        }
    }

   protected virtual void ReSet() // virtual 사용으로 기능 완성을 pig에서 해도 됨
    {
        isWalking = false; //무한 걷기 막음
        isRunning = false;
        isAction = true;
        nav.speed = walkSpeed;
        nav.ResetPath(); //목적지를 없애 경사 있는 언덕 사이로 들어가지 못하게 함
        destination.Set(Random.Range(-0.2f, 0.2f), 0f, Random.Range(0.5f, 1f));

        anim.SetBool("Walking", isWalking);
        anim.SetBool("Running", isRunning);
        //리셋할 때 뛰든 걷든 다 취소되게 만듦
    }



    protected void TryWalk()
    {
        isWalking = true;
        anim.SetBool("Walking", isWalking);
        currentTime = walkTime;
        nav.speed = walkSpeed;
        Debug.Log("걷기");
    }



    public virtual void Damage(int _dmg, Vector3 _targetPos) //데미지 맞으면 런 호출하도록
    {
        if (!isDead)
        {
            hp -= _dmg;

            if (hp <= 0)
            {
                Dead();
                return;
            }

            PlaySE(sound_hurt);
            anim.SetTrigger("Hurt");
        }
    }

    protected void Dead()
    {
        PlaySE(sound_dead);
        isWalking = false;
        isRunning = false;
        isDead = true;
        anim.SetTrigger("Dead");
        Destroy(this.gameObject, destroyTime); // 죽으면 삭제
    }

    protected void RandomSound()
    {
        int _random = Random.Range(0, 3); //일상 사운드
        PlaySE(sound_normal[_random]);
    }

    protected void PlaySE(AudioClip _clip)
    {
        theAudio.clip = _clip;
        theAudio.Play();
    }
}

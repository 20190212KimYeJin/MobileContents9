using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class SardineCharacter : MonoBehaviour {
	public Animator sardineAnimator;
	Rigidbody sardineRigid;
	public float turnSpeed=5f;
	public float forwardSpeed=5f;

	protected bool isDead; //죽음 판별
	[SerializeField]
	private float destroyTime; //삭제 시간
	[SerializeField]
	protected GameObject fish_item; //죽이면 나오는 아이템
	[SerializeField]
	protected GameObject go_sardine;

	[SerializeField]
	protected Animator anim;
	[SerializeField]
	protected Rigidbody rigid;
	[SerializeField]
	protected BoxCollider boxCol;

	void Start () {
		sardineAnimator = GetComponent<Animator> ();
		sardineAnimator.SetFloat ("Forward", forwardSpeed);
		sardineRigid = GetComponent<Rigidbody> ();
	}

	public void TurnLeft(){
		sardineRigid.AddTorque (-transform.up*turnSpeed,ForceMode.Impulse);
		sardineAnimator.SetTrigger ("TurnLeft");
	}

	public void TurnRight(){
		sardineRigid.AddTorque (transform.up*turnSpeed,ForceMode.Impulse);
		sardineAnimator.SetTrigger ("TurnRight");
	}

	public void MoveForward(){
		sardineRigid.AddForce (transform.forward*forwardSpeed,ForceMode.Impulse);
		sardineAnimator.SetTrigger ("MoveForward");
	}

	public void TurnUp(){
		sardineRigid.AddTorque (-transform.right*turnSpeed,ForceMode.Impulse);
	}

	public void TurnDown(){
		sardineRigid.AddTorque (transform.right*turnSpeed,ForceMode.Impulse);
	}

	public void setForwardSpeed(float fSpeed){
		forwardSpeed = fSpeed;
		sardineAnimator.SetFloat ("Forward", forwardSpeed);
	}

	public void Move(float v,float h){
		sardineAnimator.SetFloat ("Up", -v);
		sardineAnimator.SetFloat ("Turn", h);

		sardineRigid.AddForce (transform.forward*forwardSpeed);
		sardineRigid.AddTorque (transform.right*turnSpeed*v);
		sardineRigid.AddTorque (transform.up*turnSpeed*h);
	}

	protected void Dead()
	{

		isDead = true;
		anim.SetTrigger("Dead");
		Destroy(this.gameObject, destroyTime); // 죽으면 삭제
		Instantiate(fish_item, go_sardine.transform.position, Quaternion.identity);
	}
}

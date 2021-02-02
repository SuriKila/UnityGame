
using UnityEngine;


public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Joystick joystick;

	public float runSpeed = 40f;
	
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	private Animator _animator;

	
	private void Start()
	{

		_animator = GetComponent<Animator>();

	}
	void Update () {	
		
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
		

		var _ground = CharacterController2D.m_Grounded;
		
		if (_ground == false)
		{	
			horizontalMove = joystick.Horizontal * runSpeed + Time.deltaTime;
		}
		else
		{
			horizontalMove = 0;
		}
		
		
		
		_animator.SetBool("JumpB", !_ground);
		if (jump == true)
		{
			_animator.SetBool("JumpB",true);
		}
		



	}
	public void Jump()
	{
		jump = true;
	}
	void FixedUpdate ()
	{
		
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name.Equals("lift"))
		{
			this.transform.parent = collision.transform;
		}
	}
	private void OnCollisionExit2D(Collision2D collision)
	{

		if (collision.gameObject.name.Equals("lift"))
		{
			this.transform.parent = null;
		}
	}
}

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private float moveVelocity;
	public bool canMove;

	private Rigidbody2D rb;
	private Animator anim;
	private SpriteRenderer sp;

	public float knockBack;
	public float knockBackLength;
	public float knockBackHeight;
	public float knockBackCound;
	public bool knockFromRight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public bool grounded;

	public GameObject currentGun;
	public GameObject[] guns;
	public GameObject[] knifes;
	public GameObject currentKnife;

	private SpriteRenderer s;
	public Sprite currentSprite;
	public Sprite[] sprites;

	public bool swinging;
	// Use this for initialization

	void Awake()
	{
		s = GetComponent<SpriteRenderer> ();
		currentSprite = sprites [PlayerPrefs.GetInt ("PlayerCostume")];
		s.sprite = currentSprite;
	}
	void Start () {


		currentKnife = knifes [PlayerPrefs.GetInt ("CurrentKnife")];
		currentGun = guns [PlayerPrefs.GetInt ("CurrentGun")];


		currentKnife.SetActive (true);
		currentGun.SetActive (false);
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		sp = GetComponent<SpriteRenderer> ();

		canMove = true;

	}

	// Update is called once per frame
	void FixedUpdate () {


		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

		if (knockBackCound <= 0) {
			canMove = true;
			rb.velocity = new Vector2 (moveVelocity, 0);
		} 

		if (knockBackCound >= 0) {
			canMove = false;
			if (knockFromRight)
				rb.AddForce(new Vector2 (-knockBack, knockBackHeight));
			if (!knockFromRight)
				rb.AddForce(new Vector2 (knockBack, knockBackHeight));
			knockBackCound -= Time.deltaTime;
		}

		if (!canMove || !grounded)
			moveVelocity = 0;

		if(canMove && grounded)
		{

		if(Input.GetKey(KeyCode.D))
			{
			moveVelocity = moveSpeed;
			anim.SetBool ("Is Walking", true);
			sp.flipX = false;
			}
			if (Input.GetKey (KeyCode.A)) {
				moveVelocity = -moveSpeed;
				anim.SetBool ("Is Walking", true);
				sp.flipX = true;
			}
		}
		if (Input.GetKeyUp(KeyCode.A)|| Input.GetKeyUp(KeyCode.D)){
			moveVelocity = 0;
			anim.SetBool ("Is Walking", false);
		}
		rb.velocity = new Vector2 ( moveVelocity, 0);

		if (anim.GetBool ("Swinging")) {
			anim.SetBool ("Swinging", false);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Zombie"))
			{

				if(other.transform.position.x > transform.transform.position.x)
				{
					knockFromRight = true;
				}
				if(other.transform.position.x < transform.transform.position.x)
				{
					knockFromRight = false;
				}
			}

	}
	public void MoveRight(float movingSpeed)
	{
		if (canMove && grounded) {
			moveVelocity = movingSpeed;
			anim.SetBool ("Is Walking", true);
			transform.localScale = new Vector3 (1, 1, 1);
		}
	}
	public void MoveLeft(float movingSpeed)
	{
		if (canMove && grounded) {
			moveVelocity = -movingSpeed;
			anim.SetBool ("Is Walking", true);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	private float speed = -12;


	private float deadLine = -10;


	// 課題
	

	public AudioClip block;
	AudioSource audioSource;




	// Use this for initialization
	void Start () {

		audioSource = GetComponent<AudioSource>();
		
	}




	// Update is called once per frame
	void Update () {


		transform.Translate(this.speed * Time.deltaTime, 0, 0);


		if (transform.position.x < this.deadLine)
		{
			Destroy(gameObject);
		}

	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		
		if (collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
		{
			audioSource.PlayOneShot(block, 1.0f);
			
		}
	}
}

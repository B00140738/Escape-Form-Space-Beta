using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }
	public float horizontalInput;
	public float speed = 35.0f;
	public float xRange = 35;
	public GameObject projectile;

		// time the player has to wait to fire again
	private float fireRate = 1;
	// time since start after which player can fire again
	private float nextFire = 0;


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input. GetAxis("Horizontal");
		transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

		if (transform.position.x < -xRange){
			transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
		if (transform.position.x > xRange){
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}


		if(Input.GetKey(KeyCode.Space)  && Time.time > nextFire){
		// reset nextFire to current time + fireRate
		nextFire = Time.time + fireRate;
		//Launch projectile from the player
		Instantiate(projectile, transform.position, projectile.transform.rotation);
		}
    }
}

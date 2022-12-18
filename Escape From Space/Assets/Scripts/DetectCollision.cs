using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DetectCollision : MonoBehaviour
{
    public bool gameOver;
	
    public float floatForce;
    private float gravityModifier;
 	private Rigidbody playerRb;


    public ParticleSystem explosionParticle;
  
    public ParticleSystem smokeParticle;

 	private AudioSource playerAudio;
    public AudioClip smokeSound;
    public AudioClip explodeSound;
	public AudioClip moneySound;
 	public TextMeshProUGUI gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
		
		
    }

// if player or rocket collides with enemy, explode.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
        Destroy(gameObject);
        Destroy(other.gameObject);
	
        explosionParticle.Play();
		smokeParticle.Play();
        }

        // if player collides with Powerup
        else if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);

        }

    }

}

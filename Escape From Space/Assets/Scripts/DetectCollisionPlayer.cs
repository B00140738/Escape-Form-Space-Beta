using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DetectCollisionPlayer : MonoBehaviour
{
    public bool gameOver;
	public bool isGameActive;
    public float floatForce;
    private float gravityModifier;

    public ParticleSystem explosionParticle;
 
 	private AudioSource playerAudio;
    public AudioClip explodeSound;
	


    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

    }

// if player or rocket collides with enemy, explode.
    private void OnTriggerEnter(Collider other)
    {
     if (other.gameObject.CompareTag("Enemy")) {	
	 	explosionParticle.Play();
        Destroy(gameObject);
        Destroy(other.gameObject);
        
	
	 }
        
        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);

        }

    }

}

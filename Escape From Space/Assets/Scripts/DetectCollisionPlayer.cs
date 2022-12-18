using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class DetectCollisionPlayer : MonoBehaviour
{
    
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
	 	
        Destroy(gameObject);
        Destroy(other.gameObject);
		explosionParticle.Play();
		SceneManager.LoadScene("GameOverScreen");
		
		
		
		
		
	 }      

    }

}

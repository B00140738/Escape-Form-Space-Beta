using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupDetection : MonoBehaviour
{
    public bool gameOver;
	
    public float floatForce;
    private float gravityModifier;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;
    public ParticleSystem smokeParticle;

 	private AudioSource playerAudio;
    public AudioClip fireworkSound;
    public AudioClip smokeSound;
    public AudioClip explodeSound;
	public AudioClip moneySound;



    // Start is called before the first frame update
    void Start()
    {

        playerAudio = GetComponent<AudioSource>();

    }


    private void OnTriggerEnter(Collider other)
    {
  
        // if player collides with money, fireworks
       

    }

}

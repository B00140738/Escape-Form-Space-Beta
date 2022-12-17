using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private int damage;
 	[SerializeField] private HealthController _healthController;
	
	private void OnTriggerEnter(Collider collision)
	{
		if(collision.CompareTag("Player"))
		{
			Damage();
		}	
	}
	
	void Damage()
	{
		_healthController.playerHealth = _healthController.playerHealth - damage;
		_healthController.UpdateHealth();
		gameObject.SetActive(false);
	}
}

	
	

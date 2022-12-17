using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthController : MonoBehaviour
{
	public int playerHealth;
	public int numOfHealth;
	
	public Image[] hearts;
	public Sprite fullHeart;
	public Sprite emptyHeart;
	
	
	private void start()
	{
		UpdateHealth();	
	}
	
	public void UpdateHealth()
	{
	
	if(playerHealth <= 0)
	{
			//restartgame
			//respawnplayer
	}
		if(playerHealth > numOfHealth)
	{
			playerHealth = numOfHealth;
	}
	
		for(int i = 0; i < hearts.Length; i++)
		{
			if(i < playerHealth)
			{
					hearts[i].sprite = fullHeart;
			}
			else
			{
			 	hearts[i].sprite = emptyHeart;
			}
			 
			 
			if (i < numOfHealth)
			{
				hearts[i].enabled = true;
			}
			else
			{
				hearts[i].enabled = false;
			}
		}
	}
}

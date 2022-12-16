using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public GameObject titleScreen;
    public Button restartButton; 
    public bool isGameActive;
	public TextMeshProUGUI gameOverText;

    public void StartGame(int difficulty)
    {
        isGameActive = true;
        titleScreen.SetActive(false);

		
    }
   
    // Stop game, bring up game over text and restart button
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }
	private void Update() {
 		if (isGameActive) {
		
 			if (gameObject.CompareTag("Enemy")) 
				GameOver();
			
			
		}
	}
    // Restart game by reloading the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

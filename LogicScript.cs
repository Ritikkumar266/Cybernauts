using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject GameOverScreen;
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) 
    {

        playerScore += 1;
        score.text = playerScore.ToString();
    }

    public void restartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() 
    {
        GameOverScreen.SetActive(true);
    }
    public void ExitGame()
    {
        if (Application.isPlaying & !Application.isEditor)
            Application.Quit(); // We may return from this, but the program will terminate at the end of the frame
#if false
	else
		UnityEditor.EditorApplication.isPlaying = false;    // Handle being in the editor, but set #if to true to use it
#endif
    }// ExitGame()
}

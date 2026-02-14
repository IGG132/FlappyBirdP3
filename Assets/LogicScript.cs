using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 public int PlayerScore;
 public Text text1;
 public GameObject gameOverScreen;
 [ContextMenu("Increase Score")]
 public void  addScore()
 {
    PlayerScore+=1;
    text1.text = PlayerScore.ToString();
 }
 public void RestartGame()
 {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }
 public void gameOver()
 {
    gameOverScreen.SetActive(true);
     Debug.Log("Hit: " + gameObject.name);
 }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI instance;

    public Text scoreText;

    public Text bestScoreText, ssText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UbdateScore()
    {
        scoreText.text = LevelManager.instance.pickUpCollected.ToString();

        if (LevelManager.instance.player == null)
        {
            ssText.text = scoreText.text;
        }
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneManagerr : MonoBehaviour {

    public PlayerMovement playerScript;
    public bool playerIsDead;

    public ButterflyBoss butterflyBossScript;
    public Button playAgain;
    public bool playAgainDone;

    public Scene currentScene;
    public string gameOverScene;
    void Start () {
        playAgainDone = false;
       // playAgain.onClick.AddListener(PlayAgainButton);
        playerIsDead = false;
        playerScript = GetComponent<PlayerMovement>();
        butterflyBossScript = GetComponent<ButterflyBoss>();
        
        currentScene = SceneManager.GetActiveScene();
        gameOverScene = "GameOver";
    }


    void Update () {
        GameOverScene();
        //PlayAgainButton();
	}

    public void GameOverScene()
    {
        if (!gameOverScene.Equals(currentScene.name))
        {
            if ((playerScript.playerHP <= 0) && playerIsDead == false)
            {
                SceneManager.LoadScene("GameOver");
                playerIsDead = true;
            }
        }
    }

    public void ButterflyBossIsDead()
    {
        if (butterflyBossScript.bossDead == true)
        {
            //code for what happens when butterfly boss is dead
        }
    }
  //  public void PlayAgainButton()
   // {
    //    if(playAgainDone == false)
     //   {
      //      SceneManager.LoadScene("IntroductionArea");
       //     playAgainDone = true;
        //}
   // }
}

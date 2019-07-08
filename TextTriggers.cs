using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextTriggers : MonoBehaviour
{

    public UITextManager UITextManager;
    public BeamPickUp BeamPickUp;

    public ButterflyBoss bossScript;
    public GameObject butterflyObject;
    public Scene currentScene;
    public string smallBossAreaName = "SmallBossArea";
    //public string smallBossScene;
    public bool bossExecutedDead = false;
    public bool bossCheck = false;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        UITextManager.GetComponent<UITextManager>();
        BeamPickUp.GetComponent<BeamPickUp>();


    }

    void Update()
    {
        CurrentSceneChanger();

        if (BeamPickUp.pickedUp == true) //First text - when you receive the red beam
        {
            UITextManager.currentLine = 4;
            UITextManager.lastLine = 5;
            UITextManager.DialogueActive();
            UITextManager.NextDialogue();
            UITextManager.DialogueInactive();
            BeamPickUp.pickedUp = false;
        }


        if (currentScene.name == smallBossAreaName) //text after boss dies
        {
            if (bossCheck == false)
            {
                butterflyObject = GameObject.FindWithTag("Boss");
                bossScript = butterflyObject.GetComponent<ButterflyBoss>();
                bossCheck = true;
            }

            if ((bossScript.HP <= 0) && (bossExecutedDead == false))    
            {
                print("OOF");
                UITextManager.currentLine = 7;
                UITextManager.lastLine = 9;
                UITextManager.DialogueActive();
                UITextManager.NextDialogue();
                UITextManager.DialogueInactive();
                bossExecutedDead = true;
            }
        }
    }

    void CurrentSceneChanger()
    {
        currentScene = SceneManager.GetActiveScene();
    }
}


        


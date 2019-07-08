using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextManager : MonoBehaviour
{
    //UI
    public Text UIText;
    public Image UIImage;

    //Integers, Strings, Texts
    public string[] dialogues;
    public TextAsset gameDialogues;
    public int currentLine;
    public int lastLine;

    public bool textFinished = true;

    //References
    public BeamPickUp beamPickUp;
    public bool chatActive = false;

    void Start()
    {
        UIImage.gameObject.SetActive(false);
        beamPickUp.GetComponent<BeamPickUp>();
        if (gameDialogues != null)
        {
            dialogues = (gameDialogues.text.Split('\n'));
        }

        if (lastLine == 0)
        {
            lastLine = dialogues.Length - 1;
        }
    }

    void Update()
    {
        UIText.text = dialogues[currentLine];
     //   ObtainedItemTexts();

            if (currentLine > lastLine)
            {
                UIImage.gameObject.SetActive(false);
                Time.timeScale = 1;
            currentLine = 0;
            textFinished = true;

        }
        else
        {
            textFinished = false;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine++;
        }

 
        if(textFinished == false)
        {
            
        }
    }

    //void ObtainedItemTexts()
    //{
    //    if ((beamPickUp.pickedUp == true) || (currentLine == 4))
    //    {
    //        chatActive = true;
    //        if (currentLine != 4)
    //        {
    //            beamPickUp.pickedUp = false;
    //            currentLine = 4;
    //        }
    //        UIImage.gameObject.SetActive(true);
    //        Time.timeScale = 0;
    //        if (Input.GetKeyDown(KeyCode.Return))
    //        {
    //            currentLine++;
    //        }
    //    }
    //    }

    public void DialogueActive()
    {
        UIImage.gameObject.SetActive(true);
        Time.timeScale = 0;

    }

    public void DialogueInactive()
    {
        if (currentLine >= lastLine)
        {
            UIImage.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }


    public void NextDialogue()
    {
        if((UIImage.gameObject == true) && (Input.GetKeyDown(KeyCode.Return)) && (currentLine <= lastLine))
        {
            currentLine++;
        }
    }

}

    


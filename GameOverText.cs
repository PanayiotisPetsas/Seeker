using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{

    public float move = 10;
    public GameObject gameOverText;
    public bool check;
    public Vector3 movement;
    //Vector3 position = gameOverText.rectTransform.position;

    void Start()
    {
        check = true;
    }

    void FixedUpdate()
    {
      //  if ((gameOverText.transform.position.x <= -15)||(gameOverText.transform.position.x <= 15))
      //  {
      //      gameOverText.transform.Translate(0.2f, 0, 0);
      //  }
      //   if (gameOverText.transform.position.x >= 10)
      //   {
      //      gameOverText.transform.Translate(-0.2f, 0, 0);
      //   }
    

        if(check == true)
        {
            gameOverText.transform.Translate(0.1f, 0, 0);
            if(gameOverText.transform.position.x >= 2)
            {
                check = false;
            }
        }
        if(check == false)
        {
            gameOverText.transform.Translate(-0.1f, 0, 0);
            if (gameOverText.transform.position.x <= -2)
            {
                check = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionScript : MonoBehaviour {

    public GameObject leftBall;
    public Transform leftBallSpawner;
    public Transform rightBallSpawner;
    public bool waited;

    // Use this for initialization
    void Start () {
        waited = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "purpleHair1") && (waited == true))
        {
            print("BEAM BEAM");
            Instantiate(leftBall, leftBallSpawner);
            Instantiate(leftBall, rightBallSpawner);
            waited = false;
            StartCoroutine(AttackBallDelay());
        }
    }

    public IEnumerator AttackBallDelay()
    {
        yield return new WaitForSeconds(2.5f);
        waited = true;
    }
}

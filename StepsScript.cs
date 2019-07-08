using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsScripts : MonoBehaviour {
    public GameObject steps1;
    public GameObject steps2;
    public GameObject steps3;
    public GameObject steps4;
    public GameObject steps5;

    public ButterflyBoss bossScript;


    // Use this for initialization
    void Start () {
        bossScript = GetComponent<ButterflyBoss>();
        bossScript.GetComponent<ButterflyBoss>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

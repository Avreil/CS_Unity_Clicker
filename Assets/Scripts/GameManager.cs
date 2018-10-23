using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {



    public Text goldDisp;
    public Text goldPSDisp;
    public Text goldPCDisp;

    public float gold=0;
    public float goldPS=0;
    public float goldPC=0;

	
	



    void Start () {}
	void Update () {
        goldDisp.text = "Gold:  " + gold;
        goldPSDisp.text = "Gold Per Second: " + goldPS;
        goldPCDisp.text = "Gold Per Click: " + goldPC;
    
    
    }






}

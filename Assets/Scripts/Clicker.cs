using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour {


    public GameManager gm;







	void Start () {
		
	}
	
	
	void Update () {
        if(Input.GetMouseButtonDown(0)){
            gm.gold += gm.goldPC;
        }	
	}
}

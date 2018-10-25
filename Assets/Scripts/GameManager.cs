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

    private IEnumerator coroutine;
	



    void Start () {
        coroutine = makemoney(1.0f);
        StartCoroutine(coroutine);

    }

	void Update () {
        Clickit();
    
    }

    private IEnumerator makemoney(float latencyTime){
        while(true){
            yield return new WaitForSeconds(latencyTime);
            gold += goldPS;
            goldDisp.text = "Gold:  " + gold;

        }
    }


    //legacy 
    private void Clickit(){
        goldDisp.text = "Gold:  " + gold;
        goldPSDisp.text = "Gold Per Second: " + goldPS;
        goldPCDisp.text = "Gold Per Click: " + goldPC;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanels : MonoBehaviour {

   

    public GameObject Panel;
    public GameObject panelToClose1;
    public GameObject panelToClose2;
    public GameObject panelToClose3;
    public Button button;

    int counter=1;

    public void ShowPanel(){
        counter++;
        if (counter %2 == 1){
            Panel.gameObject.SetActive(false);


        }else{
            Panel.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
            closePreviousPanels();
            counter=1;
            
        }
    }



    void closePreviousPanels(){
        panelToClose1.gameObject.SetActive(false);
        panelToClose2.gameObject.SetActive(false);
        panelToClose3.gameObject.SetActive(false);


    }
}

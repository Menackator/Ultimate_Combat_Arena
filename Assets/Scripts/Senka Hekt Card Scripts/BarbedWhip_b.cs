using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class BarbedWhip_b : MonoBehaviour
{
    private string target = "";
    private string player = "";

    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        target = GameObject.Find("CombatController").GetComponent<CombatController>().targetName;
        int damageToTarget = 2;
        player = GameObject.Find("CombatController").GetComponent<CombatController>().playerName;
        int damageToSelf = 1;

        // Takes away health
        switch (target)
        {
            case "Senka Hekt":
                GameObject.Find("CombatController").GetComponent<CombatController>().SH.GetComponent<SH_Control>().health -= damageToTarget;
                break;
            case "Tatakai":
                GameObject.Find("CombatController").GetComponent<CombatController>().TK.GetComponent<TK_Control>().health -= damageToTarget;
                break;
            case "Rama Lux":
                GameObject.Find("CombatController").GetComponent<CombatController>().RL.GetComponent<RL_Control>().health -= damageToTarget;
                break;
            case "Ansell V'Han":
                GameObject.Find("CombatController").GetComponent<CombatController>().AV.GetComponent<AV_Control>().health -= damageToTarget;
                break;
        }

        switch (player)
        {
            case "Senka Hekt":
                GameObject.Find("CombatController").GetComponent<CombatController>().SH.GetComponent<SH_Control>().health -= damageToSelf;
                break;
            case "Tatakai":
                GameObject.Find("CombatController").GetComponent<CombatController>().TK.GetComponent<TK_Control>().health -= damageToSelf;
                break;
            case "Rama Lux":
                GameObject.Find("CombatController").GetComponent<CombatController>().RL.GetComponent<RL_Control>().health -= damageToSelf;
                break;
            case "Ansell V'Han":
                GameObject.Find("CombatController").GetComponent<CombatController>().AV.GetComponent<AV_Control>().health -= damageToSelf;
                break;
        }

        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Desperation_b : MonoBehaviour
{
    private string target = "";
    private string player = "";

    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        target = GameObject.Find("CombatController").GetComponent<CombatController>().targetName;
        int damageToTarget = 0;
        player = GameObject.Find("CombatController").GetComponent<CombatController>().playerName;

        switch (player)
        {
            case "Senka Hekt":
                if (GameObject.Find("CombatController").GetComponent<CombatController>().SH.GetComponent<SH_Control>().health < 0)
                {
                    damageToTarget = 2;
                }
                else
                {
                    damageToTarget = 1;
                }
                break;
            case "Tatakai":
                if (GameObject.Find("CombatController").GetComponent<CombatController>().TK.GetComponent<TK_Control>().health < 0)
                {
                    damageToTarget = 2;
                }
                else
                {
                    damageToTarget = 1;
                }
                break;
            case "Rama Lux":
                if (GameObject.Find("CombatController").GetComponent<CombatController>().RL.GetComponent<RL_Control>().health < 0)
                {
                    damageToTarget = 2;
                }
                else
                {
                    damageToTarget = 1;
                }
                break;
            case "Ansell V'Han":
                if (GameObject.Find("CombatController").GetComponent<CombatController>().AV.GetComponent<AV_Control>().health < 0)
                {
                    damageToTarget = 2;
                }
                else
                {
                    damageToTarget = 1;
                }
                break;
        }

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

        Destroy(gameObject);
    }
}

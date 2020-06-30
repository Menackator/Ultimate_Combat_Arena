using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Scratch_b: MonoBehaviour
{
    private string target = "";

    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        target = GameObject.Find("CombatController").GetComponent<CombatController>().targetName;
        int damageToTarget = 1;

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

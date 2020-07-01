using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class GatherDarkness_b : MonoBehaviour
{
    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        GameObject.Find("CombatController").GetComponent<CombatController>().UpdateEndOfTurnEffects(0, 1, 0);

        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;

public class SH_Cards : MonoBehaviour
{
    public GameObject BarbedWhip_b;
    public GameObject BloodMagic_b;
    public GameObject Desperation_b;
    public GameObject GatherDarkness_b;
    public GameObject Payback_b;
    public GameObject Regret_b;
    public GameObject Scratch_b;
    public GameObject ShadowBolt_b;
    public GameObject Shatter_b;
    public GameObject TelepathicAssault_b;
    public GameObject Curse_g;
    public GameObject DemonicStrength_g;
    public GameObject DragDown_g;
    public GameObject HarvestSouls_g;
    public GameObject Infection_g;
    public GameObject Retribution_g;
    public GameObject StealLife_g;
    public GameObject Terrorize_g;
    public GameObject Weakness_g;
    public GameObject Annihilation_y;
    public GameObject Darkness_y;
    public GameObject Masochism_y;
    public GameObject MindControl_y;
    public GameObject MistForm_y;
    public GameObject Vengeance_y;
    public GameObject Amnesia_p;
    public GameObject BecomeUndead_p;
    public GameObject Despair_p;
    public GameObject RaiseHell_p;
    public GameObject SelfMutilation_p;

    // Awake is called before start functions
    private void Awake()
    {
        BarbedWhip_b = Resources.Load("Prefabs/Senka Hekt Card Deck/BarbedWhip_b") as GameObject;
        BloodMagic_b = Resources.Load("Prefabs/Senka Hekt Card Deck/BloodMagic_b") as GameObject;
        Desperation_b = Resources.Load("Prefabs/Senka Hekt Card Deck/Desperation_b") as GameObject;
        GatherDarkness_b = Resources.Load("Prefabs/Senka Hekt Card Deck/GatherDarkness_b") as GameObject;
        Scratch_b = Resources.Load("Prefabs/Senka Hekt Card Deck/Scratch_b") as GameObject;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;

public class SH_Cards : MonoBehaviour
{
    /*public GameObject BarbedWhip_b;
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
    public GameObject SelfMutilation_p;*/
    public GameObject[] SH_CardChoices = new GameObject[30];

    // Awake is called before start functions
    private void Awake()
    {
        // Replace with Asset Bundles in production build: https://learn.unity.com/tutorial/assets-resources-and-assetbundles#5c7f8528edbc2a002053b5a5
        /*string currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        BarbedWhip_b = Resources.Load("Prefabs/Senka Hekt Card Deck/BarbedWhip_b") as GameObject;

        foreach (string file in Directory.GetFiles(BarbedWhip_b.Path)) ;
        string[] filenames = Directory.GetFiles(currentDirectory + "/Senka Hekt Card Deck/", "*.prefab");
        Debug.Log(currentDirectory);
        Debug.Log(filenames);

        for (int i = 0; i < SH_CardChoices.Length; i++)
        {
            SH_CardChoices[i] = Resources.Load("Prefabs/Senka Hekt Card Deck/" + filenames[i]) as GameObject;
        }*/

        /*BarbedWhip_b = Resources.Load("Prefabs/Senka Hekt Card Deck/BarbedWhip_b") as GameObject;
        BloodMagic_b = Resources.Load("Prefabs/Senka Hekt Card Deck/BloodMagic_b") as GameObject;
        Desperation_b = Resources.Load("Prefabs/Senka Hekt Card Deck/Desperation_b") as GameObject;
        GatherDarkness_b = Resources.Load("Prefabs/Senka Hekt Card Deck/GatherDarkness_b") as GameObject;
        Payback_b = Resources.Load("Prefabs/Senka Hekt Card Deck/Payback_b") as GameObject;
        Regret_b = Resources.Load("Prefabs/Senka Hekt Card Deck/Regret_b") as GameObject;
        Scratch_b = Resources.Load("Prefabs/Senka Hekt Card Deck/Scratch_b") as GameObject;
        ShadowBolt_b = Resources.Load("Prefabs/Senka Hekt Card Deck/" + "ShadowBolt_b") as GameObject;
        Shatter_b = Resources.Load("Prefabs/Senka Hekt Card Deck/Shatter_b") as GameObject;
        TelepathicAssault_b = Resources.Load("Prefabs/Senka Hekt Card Deck/TelepathicAssault_b") as GameObject;
        Curse_g = Resources.Load("Prefabs/Senka Hekt Card Deck/Curse_g") as GameObject;
        DemonicStrength_g = Resources.Load("Prefabs/Senka Hekt Card Deck/DemonicStrength_g") as GameObject;
        DragDown_g = Resources.Load("Prefabs/Senka Hekt Card Deck/DragDown_g") as GameObject;
        HarvestSouls_g = Resources.Load("Prefabs/Senka Hekt Card Deck/HarvestSouls_g") as GameObject;
        Infection_g = Resources.Load("Prefabs/Senka Hekt Card Deck/Infection_g") as GameObject;
        Retribution_g = Resources.Load("Prefabs/Senka Hekt Card Deck/Retribution_g") as GameObject;
        StealLife_g = Resources.Load("Prefabs/Senka Hekt Card Deck/StealLife_g") as GameObject;
        Terrorize_g = Resources.Load("Prefabs/Senka Hekt Card Deck/Terrorize_g") as GameObject;
        Weakness_g = Resources.Load("Prefabs/Senka Hekt Card Deck/Weakness_g") as GameObject;
        Annihilation_y = Resources.Load("Prefabs/Senka Hekt Card Deck/Annihilation_y") as GameObject;
        Darkness_y = Resources.Load("Prefabs/Senka Hekt Card Deck/Darkness_y") as GameObject;
        Masochism_y = Resources.Load("Prefabs/Senka Hekt Card Deck/Masochism_y") as GameObject;
        MindControl_y = Resources.Load("Prefabs/Senka Hekt Card Deck/MindControl_y") as GameObject;
        MistForm_y = Resources.Load("Prefabs/Senka Hekt Card Deck/MistForm_y") as GameObject;
        Vengeance_y = Resources.Load("Prefabs/Senka Hekt Card Deck/Vengeance_y") as GameObject;
        Amnesia_p = Resources.Load("Prefabs/Senka Hekt Card Deck/Amnesia_p") as GameObject;
        BecomeUndead_p = Resources.Load("Prefabs/Senka Hekt Card Deck/BecomeUndead_p") as GameObject;
        Despair_p = Resources.Load("Prefabs/Senka Hekt Card Deck/Despair_p") as GameObject;
        RaiseHell_p = Resources.Load("Prefabs/Senka Hekt Card Deck/RaiseHell_p") as GameObject;
        SelfMutilation_p = Resources.Load("Prefabs/Senka Hekt Card Deck/SelfMutilation_p") as GameObject;*/

        SH_CardChoices = Resources.LoadAll<GameObject>("Prefabs/Senka Hekt Card Deck") as GameObject[];
    }
}

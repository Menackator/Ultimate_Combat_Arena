using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TK_Cards : MonoBehaviour
{
    public GameObject Bargain_b;
    public GameObject Block_b;
    public GameObject BuyTime_b;
    public GameObject CutAndRun_b;
    public GameObject DefensiveStrike_b;
    public GameObject GunpowderBomb_b;
    public GameObject Kick_b;
    public GameObject PoisonDart_b;
    public GameObject Slice_b;
    public GameObject Stab_b;
    public GameObject Caltrops_g;
    public GameObject CauterizeWound_g;
    public GameObject EvasiveManeuvers_g;
    public GameObject FlurryOfBlades_g;
    public GameObject GasGrenade_g;
    public GameObject HitTheLights_g;
    public GameObject LieInWait_g;
    public GameObject PoisonBlades_g;
    public GameObject SuperSpeed_g;
    public GameObject ToxicDart_g;
    public GameObject BackAgainstAWall_y;
    public GameObject Backstab_y;
    public GameObject ExplosiveCharges_y;
    public GameObject GatherInformation_y;
    public GameObject HiddenTraps_y;
    public GameObject PoisonGas_y;
    public GameObject SetFires_y;
    public GameObject SmokeScreen_y;
    public GameObject Assasinate_p;
    public GameObject Decoy_p;

    // Awake is called before start functions
    void Awake()
    {
        Bargain_b = Resources.Load("Prefabs/Senka Hekt Card Deck/BarbedWhip_b") as GameObject;
        BuyTime_b = Resources.Load("Prefabs/Senka Hekt Card Deck/BloodMagic_b") as GameObject;
        Kick_b = Resources.Load("Prefabs/Senka Hekt Card Deck/Desperation_b") as GameObject;
        Slice_b = Resources.Load("Prefabs/Senka Hekt Card Deck/GatherDarkness_b") as GameObject;
        Stab_b = Resources.Load("Prefabs/Senka Hekt Card Deck/Scratch_b") as GameObject;
    }

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class AV_Kick_b : MonoBehaviour
{
    // Calls upon the card action when clicked on
    public void DoAction() 
    {

        Destroy(gameObject);
    }
}

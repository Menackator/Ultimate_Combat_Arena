﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class PoisonGas_y : MonoBehaviour
{
    // Calls upon the card action when clicked on
    public void DoAction() 
    {

        Destroy(gameObject);
    }
}

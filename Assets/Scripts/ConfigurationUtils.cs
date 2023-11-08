using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ConfigurationUtils
{
    public static ConfigurationData configData;

    public static float TeddyBearMoveUnitsPerSecond
    {
        get { return 5; }
    }

   
    public static float CooldownSeconds
    {
        get { return 1; }
    }

 
    public static void Initialize()
    {
        configData = new ConfigurationData();
        
    }
}

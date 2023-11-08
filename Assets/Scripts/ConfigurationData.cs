using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ConfigurationData : MonoBehaviour
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data with default values
     static float teddyBearMoveUnitsPerSecond = 5;
     static float cooldownSeconds = 1;

    #endregion

    #region Properties


    public float TeddyBearMoveUnitsPerSecond
    {
        get { return teddyBearMoveUnitsPerSecond; }
    }

   
    public float CooldownSeconds
    {
        get { return cooldownSeconds; }
    }

    #endregion

    #region Constructor

   
    public ConfigurationData()
    {
        // read and save configuration data from file
        string filePath = Path.Combine(Application.streamingAssetsPath, ConfigurationDataFileName);
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the first line to get the value names (not used in this example)
                reader.ReadLine();

                // Read the second line to get the values
                string csvValues = reader.ReadLine();
                SetConfigurationDataFields(csvValues);
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error reading configuration data: " + e.Message);
        }

    }


    /// <param name="csvValues">csv string of values</param>
     static void SetConfigurationDataFields(string csvValues)
    {
        string[] values = csvValues.Split(',');
        if (values.Length == 2)
        {
            if (float.TryParse(values[0], out float moveUnitsPerSecond))
            {
                teddyBearMoveUnitsPerSecond = moveUnitsPerSecond;
            }
            if (float.TryParse(values[1], out float cooldown))
            {
                cooldownSeconds = cooldown;
            }
        }
    }

    #endregion
}

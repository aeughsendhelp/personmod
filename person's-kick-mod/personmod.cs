using System;
using System.Collections.Generic;
using BepInEx;
using UnityEngine;
using System.Collections;
using HarmonyLib;
using System.Reflection;
using System.Reflection.Emit;
namespace personsmod
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class personmod : BaseUnityPlugin
    {

        public const string pluginGuid = "personperhaps.ravenfield.personsmod";
        public const string pluginName = "personsmod";
        public const string pluginVersion = "0.1";
        public void Awake()
        {
            Harmony.DEBUG = true;
            Logger.LogInfo("person's mod active");
        }
        public void Update()
        {
            if (!PlayerPrefs.HasKey("sword unlock"))
            {
                PlayerPrefs.SetInt("sword unlock", 1);
                PlayerPrefs.Save();
            }
            if (!PlayerPrefs.HasKey("railgun unlock"))
            {
                PlayerPrefs.SetInt("railgun unlock", 1);
                PlayerPrefs.Save();
            }
        }
    }
}
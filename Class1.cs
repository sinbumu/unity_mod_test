using BepInEx;
using UnityEngine;

[BepInPlugin("com.example.runinbackground", "Run In Background", "1.0.0")]
public class RunInBackgroundPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("RunInBackgroundPlugin is loaded!");
        Application.runInBackground = true;
    }
}

using System;
using OWML.Common;
using OWML.ModHelper;

namespace BreakOnDemand;

public class BreakOnDemand : ModBehaviour
{
    private void Awake()
    {
        // You won't be able to access OWML's mod helper in Awake.
        // So you probably don't want to do anything here.
        // Use Start() instead.
    }

    private void Start()
    {
        // // Starting here, you'll have access to OWML's mod helper.
        // ModHelper.Console.WriteLine($"My mod {nameof(BreakOnDemand)} is loaded!", MessageType.Success);
        //
        // // Example of accessing game code.
        // LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
        // {
        //     if (loadScene != OWScene.SolarSystem) return;
        //     ModHelper.Console.WriteLine("Loaded into solar system!", MessageType.Success);
        // };
    }

    private void Update()
    {
        if (OWInput.IsPressed(InputLibrary.rollMode) && OWInput.IsPressed(InputLibrary.cancel) && Locator.GetProbe().IsLaunched())
        {
            ModHelper.Console.WriteLine("oiaaiioaioai PARADOX INTERACTIVE HAS LAUNCHED OAAIIAORAIEIAZOEIUA", MessageType.Success);
            Locator.GetTimelineObliterationController().BeginTimelineObliteration(TimelineObliterationController.ObliterationType.TIME_LOOP_EXPERIMENT, Locator.GetProbe());
        }
    }
}

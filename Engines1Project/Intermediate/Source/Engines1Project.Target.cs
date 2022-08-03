using UnrealBuildTool;

public class Engines1ProjectTarget : TargetRules
{
	public Engines1ProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Engines1Project");
	}
}

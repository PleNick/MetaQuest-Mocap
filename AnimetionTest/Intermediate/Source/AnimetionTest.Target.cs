using UnrealBuildTool;

public class AnimetionTestTarget : TargetRules
{
	public AnimetionTestTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("AnimetionTest");
	}
}

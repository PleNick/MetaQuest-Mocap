using UnrealBuildTool;

public class AnimetionTestServerTarget : TargetRules
{
	public AnimetionTestServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("AnimetionTest");
	}
}

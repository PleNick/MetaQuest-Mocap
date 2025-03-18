using UnrealBuildTool;

public class AnimetionTestClientTarget : TargetRules
{
	public AnimetionTestClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("AnimetionTest");
	}
}

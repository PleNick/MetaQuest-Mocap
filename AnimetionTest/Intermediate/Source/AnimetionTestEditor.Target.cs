using UnrealBuildTool;

public class AnimetionTestEditorTarget : TargetRules
{
	public AnimetionTestEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("AnimetionTest");
	}
}

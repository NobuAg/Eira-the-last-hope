using UnrealBuildTool;

public class EiraTheLastHopeEditorTarget : TargetRules
{
	public EiraTheLastHopeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("EiraTheLastHope");
	}
}

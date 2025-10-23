using UnrealBuildTool;

public class EiraTheLastHopeClientTarget : TargetRules
{
	public EiraTheLastHopeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("EiraTheLastHope");
	}
}

using UnrealBuildTool;

public class EiraTheLastHopeServerTarget : TargetRules
{
	public EiraTheLastHopeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("EiraTheLastHope");
	}
}

using UnrealBuildTool;

public class EiraTheLastHopeTarget : TargetRules
{
	public EiraTheLastHopeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("EiraTheLastHope");
	}
}

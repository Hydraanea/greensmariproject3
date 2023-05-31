using UnrealBuildTool;

public class DSDN102MarinaTarget : TargetRules
{
	public DSDN102MarinaTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("DSDN102Marina");
	}
}

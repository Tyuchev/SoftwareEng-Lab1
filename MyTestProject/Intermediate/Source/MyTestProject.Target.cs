using UnrealBuildTool;

public class MyTestProjectTarget : TargetRules
{
	public MyTestProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyTestProject");
	}
}

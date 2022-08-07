

using UnrealBuildTool;
using System.Collections.Generic;

public class ALSV_LearnTarget : TargetRules
{
	public ALSV_LearnTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ALSV_Learn" } );
	}
}

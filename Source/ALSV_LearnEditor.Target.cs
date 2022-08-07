

using UnrealBuildTool;
using System.Collections.Generic;

public class ALSV_LearnEditorTarget : TargetRules
{
	public ALSV_LearnEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ALSV_Learn" } );
	}
}

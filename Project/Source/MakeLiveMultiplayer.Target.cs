// Built with ❤ by Make Live

using UnrealBuildTool;
using System.Collections.Generic;

public class MakeLiveMultiplayerTarget : TargetRules
{
	public MakeLiveMultiplayerTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "MakeLiveMultiplayer" } );
		//
		//test
		//
		//
		//test commit git and pull from plastic scm
		//
		//feature brnach commit
		//
	}
}

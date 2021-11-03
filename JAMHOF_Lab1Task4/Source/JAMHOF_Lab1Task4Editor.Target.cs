// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class JAMHOF_Lab1Task4EditorTarget : TargetRules
{
	public JAMHOF_Lab1Task4EditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "JAMHOF_Lab1Task4" } );
	}
}

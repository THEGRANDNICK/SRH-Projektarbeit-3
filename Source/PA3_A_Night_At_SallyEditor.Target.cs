// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class PA3_A_Night_At_SallyEditorTarget : TargetRules
{
	public PA3_A_Night_At_SallyEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "PA3_A_Night_At_Sally" } );
	}
}

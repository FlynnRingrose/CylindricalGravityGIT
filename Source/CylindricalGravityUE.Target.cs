// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class CylindricalGravityUETarget : TargetRules
{
	public CylindricalGravityUETarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "CylindricalGravityUE" } );
	}
}

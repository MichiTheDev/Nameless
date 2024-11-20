// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Nameless : ModuleRules
{
	public Nameless(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}

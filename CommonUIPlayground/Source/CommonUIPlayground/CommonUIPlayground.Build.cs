// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CommonUIPlayground : ModuleRules
{
	public CommonUIPlayground(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}

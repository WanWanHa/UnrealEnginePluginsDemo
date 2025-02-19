// Copyright 2025 (c) WanWanHa, LLC. All Rights Reserved.

using UnrealBuildTool;

public class FlyingAIDemo : ModuleRules
{
	public FlyingAIDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
		
        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "FlyingAI"
        });
		
	}
}

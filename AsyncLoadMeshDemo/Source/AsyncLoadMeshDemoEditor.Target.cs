// Copyright 2024 (c) WanWanHa NetWork Technology, LLC. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class AsyncLoadMeshDemoEditorTarget : TargetRules
{
	public AsyncLoadMeshDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "AsyncLoadMeshDemo" } );
	}
}
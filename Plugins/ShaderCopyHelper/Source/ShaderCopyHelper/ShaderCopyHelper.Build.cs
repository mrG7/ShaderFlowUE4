namespace UnrealBuildTool.Rules
{
    using System.IO;

    public class ShaderCopyHelper : ModuleRules
    {
        public ShaderCopyHelper(TargetInfo Target)
        {
            PublicIncludePaths.AddRange(
                new string[]
                {
                    "ShaderCopyHelper/Public"
                }
            );


            PrivateIncludePaths.AddRange(
                new string[]
                {
                    "ShaderCopyHelper/Private"
                }
            );

            PublicDependencyModuleNames.AddRange(
                new string[]
                {
                    "Core"
                }
            );


            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "CoreUObject",
                    "Engine",
                    "InputCore"
                }
            );

            DynamicallyLoadedModuleNames.AddRange(
                new string[]
                {

                }
            );
        }
    }
}
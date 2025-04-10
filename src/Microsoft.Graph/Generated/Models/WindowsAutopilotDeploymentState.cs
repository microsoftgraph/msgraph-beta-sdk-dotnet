// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Deployment states for Autopilot devices</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum WindowsAutopilotDeploymentState
    {
        /// <summary>The deployment state is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>The deployment succeeded.</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>The deployment state is in progress.</summary>
        [EnumMember(Value = "inProgress")]
        InProgress,
        /// <summary>The deployment failed.</summary>
        [EnumMember(Value = "failure")]
        Failure,
        /// <summary>The deployment timed out but user clicked past failure.</summary>
        [EnumMember(Value = "successWithTimeout")]
        SuccessWithTimeout,
        /// <summary>The deployment was not run.</summary>
        [EnumMember(Value = "notAttempted")]
        NotAttempted,
        /// <summary>The deployment is disabled.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>The deployment succeeded after hitting an initial timeout failure.</summary>
        [EnumMember(Value = "successOnRetry")]
        SuccessOnRetry,
    }
}

using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SynchronizationMetadata {
        [EnumMember(Value = "galleryApplicationIdentifier")]
        GalleryApplicationIdentifier,
        [EnumMember(Value = "galleryApplicationKey")]
        GalleryApplicationKey,
        [EnumMember(Value = "isOAuthEnabled")]
        IsOAuthEnabled,
        [EnumMember(Value = "IsSynchronizationAgentAssignmentRequired")]
        IsSynchronizationAgentAssignmentRequired,
        [EnumMember(Value = "isSynchronizationAgentRequired")]
        IsSynchronizationAgentRequired,
        [EnumMember(Value = "isSynchronizationInPreview")]
        IsSynchronizationInPreview,
        [EnumMember(Value = "oAuthSettings")]
        OAuthSettings,
        [EnumMember(Value = "synchronizationLearnMoreIbizaFwLink")]
        SynchronizationLearnMoreIbizaFwLink,
        [EnumMember(Value = "configurationFields")]
        ConfigurationFields,
    }
}

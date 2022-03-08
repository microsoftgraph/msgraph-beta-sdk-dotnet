using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class WindowsFeatureUpdateProfile : Entity, IParsable {
        /// <summary>The list of group assignments of the profile.</summary>
        public List<WindowsFeatureUpdateProfileAssignment> Assignments { get; set; }
        /// <summary>The date time that the profile was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Friendly display name of the quality update profile deployable content</summary>
        public string DeployableContentDisplayName { get; set; }
        /// <summary>The description of the profile which is specified by the user.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the profile.</summary>
        public string DisplayName { get; set; }
        /// <summary>The last supported date for a feature update</summary>
        public DateTimeOffset? EndOfSupportDate { get; set; }
        /// <summary>The feature update version that will be deployed to the devices targeted by this profile. The version could be any supported version for example 1709, 1803 or 1809 and so on.</summary>
        public string FeatureUpdateVersion { get; set; }
        /// <summary>The date time that the profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>List of Scope Tags for this Feature Update entity.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>The windows update rollout settings, including offer start date time, offer end date time, and days between each set of offers.</summary>
        public WindowsUpdateRolloutSettings RolloutSettings { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsFeatureUpdateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsFeatureUpdateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as WindowsFeatureUpdateProfile).Assignments = n.GetCollectionOfObjectValues<WindowsFeatureUpdateProfileAssignment>(WindowsFeatureUpdateProfileAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as WindowsFeatureUpdateProfile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deployableContentDisplayName", (o,n) => { (o as WindowsFeatureUpdateProfile).DeployableContentDisplayName = n.GetStringValue(); } },
                {"description", (o,n) => { (o as WindowsFeatureUpdateProfile).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as WindowsFeatureUpdateProfile).DisplayName = n.GetStringValue(); } },
                {"endOfSupportDate", (o,n) => { (o as WindowsFeatureUpdateProfile).EndOfSupportDate = n.GetDateTimeOffsetValue(); } },
                {"featureUpdateVersion", (o,n) => { (o as WindowsFeatureUpdateProfile).FeatureUpdateVersion = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as WindowsFeatureUpdateProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as WindowsFeatureUpdateProfile).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"rolloutSettings", (o,n) => { (o as WindowsFeatureUpdateProfile).RolloutSettings = n.GetObjectValue<WindowsUpdateRolloutSettings>(WindowsUpdateRolloutSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WindowsFeatureUpdateProfileAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deployableContentDisplayName", DeployableContentDisplayName);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endOfSupportDate", EndOfSupportDate);
            writer.WriteStringValue("featureUpdateVersion", FeatureUpdateVersion);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteObjectValue<WindowsUpdateRolloutSettings>("rolloutSettings", RolloutSettings);
        }
    }
}

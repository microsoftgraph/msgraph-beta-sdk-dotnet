using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class WindowsQualityUpdateProfile : Entity, IParsable {
        /// <summary>The list of group assignments of the profile.</summary>
        public List<WindowsQualityUpdateProfileAssignment> Assignments { get; set; }
        /// <summary>The date time that the profile was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Friendly display name of the quality update profile deployable content</summary>
        public string DeployableContentDisplayName { get; set; }
        /// <summary>The description of the profile which is specified by the user.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the profile.</summary>
        public string DisplayName { get; set; }
        /// <summary>Expedited update settings.</summary>
        public ExpeditedWindowsQualityUpdateSettings ExpeditedUpdateSettings { get; set; }
        /// <summary>The date time that the profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Friendly release date to display for a Quality Update release</summary>
        public string ReleaseDateDisplayName { get; set; }
        /// <summary>List of Scope Tags for this Quality Update entity.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsQualityUpdateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsQualityUpdateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as WindowsQualityUpdateProfile).Assignments = n.GetCollectionOfObjectValues<WindowsQualityUpdateProfileAssignment>(WindowsQualityUpdateProfileAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as WindowsQualityUpdateProfile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deployableContentDisplayName", (o,n) => { (o as WindowsQualityUpdateProfile).DeployableContentDisplayName = n.GetStringValue(); } },
                {"description", (o,n) => { (o as WindowsQualityUpdateProfile).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as WindowsQualityUpdateProfile).DisplayName = n.GetStringValue(); } },
                {"expeditedUpdateSettings", (o,n) => { (o as WindowsQualityUpdateProfile).ExpeditedUpdateSettings = n.GetObjectValue<ExpeditedWindowsQualityUpdateSettings>(ExpeditedWindowsQualityUpdateSettings.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as WindowsQualityUpdateProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"releaseDateDisplayName", (o,n) => { (o as WindowsQualityUpdateProfile).ReleaseDateDisplayName = n.GetStringValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as WindowsQualityUpdateProfile).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WindowsQualityUpdateProfileAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deployableContentDisplayName", DeployableContentDisplayName);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ExpeditedWindowsQualityUpdateSettings>("expeditedUpdateSettings", ExpeditedUpdateSettings);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("releaseDateDisplayName", ReleaseDateDisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}

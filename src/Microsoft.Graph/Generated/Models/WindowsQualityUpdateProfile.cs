using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsQualityUpdateProfile : Entity, IParsable {
        /// <summary>The list of group assignments of the profile.</summary>
        public List<WindowsQualityUpdateProfileAssignment> Assignments {
            get { return BackingStore?.Get<List<WindowsQualityUpdateProfileAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>The date time that the profile was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Friendly display name of the quality update profile deployable content</summary>
        public string DeployableContentDisplayName {
            get { return BackingStore?.Get<string>("deployableContentDisplayName"); }
            set { BackingStore?.Set("deployableContentDisplayName", value); }
        }
        /// <summary>The description of the profile which is specified by the user.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display name for the profile.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Expedited update settings.</summary>
        public ExpeditedWindowsQualityUpdateSettings ExpeditedUpdateSettings {
            get { return BackingStore?.Get<ExpeditedWindowsQualityUpdateSettings>("expeditedUpdateSettings"); }
            set { BackingStore?.Set("expeditedUpdateSettings", value); }
        }
        /// <summary>The date time that the profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Friendly release date to display for a Quality Update release</summary>
        public string ReleaseDateDisplayName {
            get { return BackingStore?.Get<string>("releaseDateDisplayName"); }
            set { BackingStore?.Set("releaseDateDisplayName", value); }
        }
        /// <summary>List of Scope Tags for this Quality Update entity.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsQualityUpdateProfile and sets the default values.
        /// </summary>
        public WindowsQualityUpdateProfile() : base() {
            OdataType = "#microsoft.graph.windowsQualityUpdateProfile";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<WindowsQualityUpdateProfileAssignment>(WindowsQualityUpdateProfileAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deployableContentDisplayName", n => { DeployableContentDisplayName = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"expeditedUpdateSettings", n => { ExpeditedUpdateSettings = n.GetObjectValue<ExpeditedWindowsQualityUpdateSettings>(ExpeditedWindowsQualityUpdateSettings.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"releaseDateDisplayName", n => { ReleaseDateDisplayName = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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

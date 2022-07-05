using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Teamwork : Entity, IParsable {
        /// <summary>A collection of deleted teams.</summary>
        public List<DeletedTeam> DeletedTeams {
            get { return BackingStore?.Get<List<DeletedTeam>>(nameof(DeletedTeams)); }
            set { BackingStore?.Set(nameof(DeletedTeams), value); }
        }
        /// <summary>The Teams devices provisioned for the tenant.</summary>
        public List<TeamworkDevice> Devices {
            get { return BackingStore?.Get<List<TeamworkDevice>>(nameof(Devices)); }
            set { BackingStore?.Set(nameof(Devices), value); }
        }
        /// <summary>The teamsAppSettings property</summary>
        public Microsoft.Graph.Beta.Models.TeamsAppSettings TeamsAppSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppSettings>(nameof(TeamsAppSettings)); }
            set { BackingStore?.Set(nameof(TeamsAppSettings), value); }
        }
        /// <summary>A workforce integration with shifts.</summary>
        public List<WorkforceIntegration> WorkforceIntegrations {
            get { return BackingStore?.Get<List<WorkforceIntegration>>(nameof(WorkforceIntegrations)); }
            set { BackingStore?.Set(nameof(WorkforceIntegrations), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Teamwork CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Teamwork();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deletedTeams", n => { DeletedTeams = n.GetCollectionOfObjectValues<DeletedTeam>(DeletedTeam.CreateFromDiscriminatorValue).ToList(); } },
                {"devices", n => { Devices = n.GetCollectionOfObjectValues<TeamworkDevice>(TeamworkDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"teamsAppSettings", n => { TeamsAppSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsAppSettings>(Microsoft.Graph.Beta.Models.TeamsAppSettings.CreateFromDiscriminatorValue); } },
                {"workforceIntegrations", n => { WorkforceIntegrations = n.GetCollectionOfObjectValues<WorkforceIntegration>(WorkforceIntegration.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeletedTeam>("deletedTeams", DeletedTeams);
            writer.WriteCollectionOfObjectValues<TeamworkDevice>("devices", Devices);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsAppSettings>("teamsAppSettings", TeamsAppSettings);
            writer.WriteCollectionOfObjectValues<WorkforceIntegration>("workforceIntegrations", WorkforceIntegrations);
        }
    }
}

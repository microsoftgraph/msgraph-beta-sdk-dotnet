using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity that describes tenant level settings for derived credentials</summary>
    public class DeviceManagementResourceAccessProfileAssignment : Entity, IParsable {
        /// <summary>The administrator intent for the assignment of the profile.</summary>
        public DeviceManagementResourceAccessProfileIntent? Intent {
            get { return BackingStore?.Get<DeviceManagementResourceAccessProfileIntent?>("intent"); }
            set { BackingStore?.Set("intent", value); }
        }
        /// <summary>The identifier of the source of the assignment.</summary>
        public string SourceId {
            get { return BackingStore?.Get<string>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
        /// <summary>Base type for assignment targets.</summary>
        public DeviceAndAppManagementAssignmentTarget Target {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementResourceAccessProfileAssignment and sets the default values.
        /// </summary>
        public DeviceManagementResourceAccessProfileAssignment() : base() {
            OdataType = "#microsoft.graph.deviceManagementResourceAccessProfileAssignment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementResourceAccessProfileAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementResourceAccessProfileAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"intent", n => { Intent = n.GetEnumValue<DeviceManagementResourceAccessProfileIntent>(); } },
                {"sourceId", n => { SourceId = n.GetStringValue(); } },
                {"target", n => { Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceManagementResourceAccessProfileIntent>("intent", Intent);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OfficeConfigurationGroupAssignmentTarget : OfficeConfigurationAssignmentTarget, IParsable {
        /// <summary>The Id of the AAD group we are targeting the device configuration to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId {
            get { return BackingStore?.Get<string?>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#nullable restore
#else
        public string GroupId {
            get { return BackingStore?.Get<string>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new OfficeConfigurationGroupAssignmentTarget and sets the default values.
        /// </summary>
        public OfficeConfigurationGroupAssignmentTarget() : base() {
            OdataType = "#microsoft.graph.officeConfigurationGroupAssignmentTarget";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OfficeConfigurationGroupAssignmentTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeConfigurationGroupAssignmentTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"groupId", n => { GroupId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("groupId", GroupId);
        }
    }
}

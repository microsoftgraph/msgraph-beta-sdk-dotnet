using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PayloadCompatibleAssignmentFilter : DeviceAndAppManagementAssignmentFilter, IParsable {
        /// <summary>PayloadType of the Assignment Filter. Possible values are: notSet, enrollmentRestrictions.</summary>
        public AssignmentFilterPayloadType? PayloadType {
            get { return BackingStore?.Get<AssignmentFilterPayloadType?>(nameof(PayloadType)); }
            set { BackingStore?.Set(nameof(PayloadType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PayloadCompatibleAssignmentFilter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayloadCompatibleAssignmentFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"payloadType", n => { PayloadType = n.GetEnumValue<AssignmentFilterPayloadType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AssignmentFilterPayloadType>("payloadType", PayloadType);
        }
    }
}

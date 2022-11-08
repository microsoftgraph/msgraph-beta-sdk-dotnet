using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains the properties used to assign an App provisioning configuration to a group.</summary>
    public class MobileAppProvisioningConfigGroupAssignment : Entity, IParsable {
        /// <summary>The ID of the AAD group in which the app provisioning configuration is being targeted.</summary>
        public string TargetGroupId {
            get { return BackingStore?.Get<string>("targetGroupId"); }
            set { BackingStore?.Set("targetGroupId", value); }
        }
        /// <summary>
        /// Instantiates a new mobileAppProvisioningConfigGroupAssignment and sets the default values.
        /// </summary>
        public MobileAppProvisioningConfigGroupAssignment() : base() {
            OdataType = "#microsoft.graph.mobileAppProvisioningConfigGroupAssignment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppProvisioningConfigGroupAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppProvisioningConfigGroupAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"targetGroupId", n => { TargetGroupId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("targetGroupId", TargetGroupId);
        }
    }
}

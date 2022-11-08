using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcManagementGroupAssignmentTarget : CloudPcManagementAssignmentTarget, IParsable {
        /// <summary>The id of the assignment&apos;s target group</summary>
        public string GroupId {
            get { return BackingStore?.Get<string>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
        /// <summary>The servicePlanId property</summary>
        public string ServicePlanId {
            get { return BackingStore?.Get<string>("servicePlanId"); }
            set { BackingStore?.Set("servicePlanId", value); }
        }
        /// <summary>
        /// Instantiates a new CloudPcManagementGroupAssignmentTarget and sets the default values.
        /// </summary>
        public CloudPcManagementGroupAssignmentTarget() : base() {
            OdataType = "#microsoft.graph.cloudPcManagementGroupAssignmentTarget";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcManagementGroupAssignmentTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcManagementGroupAssignmentTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"servicePlanId", n => { ServicePlanId = n.GetStringValue(); } },
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
            writer.WriteStringValue("servicePlanId", ServicePlanId);
        }
    }
}

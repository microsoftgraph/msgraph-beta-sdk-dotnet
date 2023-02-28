using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// This entity represents a single payload with requested assignment filter Id
    /// </summary>
    public class PayloadByFilter : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Represents type of the assignment filter.</summary>
        public DeviceAndAppManagementAssignmentFilterType? AssignmentFilterType {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentFilterType?>("assignmentFilterType"); }
            set { BackingStore?.Set("assignmentFilterType", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Azure AD security group ID</summary>
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
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The policy identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayloadId {
            get { return BackingStore?.Get<string?>("payloadId"); }
            set { BackingStore?.Set("payloadId", value); }
        }
#nullable restore
#else
        public string PayloadId {
            get { return BackingStore?.Get<string>("payloadId"); }
            set { BackingStore?.Set("payloadId", value); }
        }
#endif
        /// <summary>This enum represents associated assignment payload type</summary>
        public AssociatedAssignmentPayloadType? PayloadType {
            get { return BackingStore?.Get<AssociatedAssignmentPayloadType?>("payloadType"); }
            set { BackingStore?.Set("payloadType", value); }
        }
        /// <summary>
        /// Instantiates a new payloadByFilter and sets the default values.
        /// </summary>
        public PayloadByFilter() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayloadByFilter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayloadByFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignmentFilterType", n => { AssignmentFilterType = n.GetEnumValue<DeviceAndAppManagementAssignmentFilterType>(); } },
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"payloadId", n => { PayloadId = n.GetStringValue(); } },
                {"payloadType", n => { PayloadType = n.GetEnumValue<AssociatedAssignmentPayloadType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentFilterType>("assignmentFilterType", AssignmentFilterType);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("payloadId", PayloadId);
            writer.WriteEnumValue<AssociatedAssignmentPayloadType>("payloadType", PayloadType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

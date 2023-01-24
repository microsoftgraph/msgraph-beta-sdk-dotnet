using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The entity represents an group policy operation.
    /// </summary>
    public class GroupPolicyOperation : Entity, IParsable {
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Type of Group Policy operation status.</summary>
        public GroupPolicyOperationStatus? OperationStatus {
            get { return BackingStore?.Get<GroupPolicyOperationStatus?>("operationStatus"); }
            set { BackingStore?.Set("operationStatus", value); }
        }
        /// <summary>Type of Group Policy operation.</summary>
        public GroupPolicyOperationType? OperationType {
            get { return BackingStore?.Get<GroupPolicyOperationType?>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
        /// <summary>The group policy operation status detail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusDetails {
            get { return BackingStore?.Get<string?>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#nullable restore
#else
        public string StatusDetails {
            get { return BackingStore?.Get<string>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationStatus", n => { OperationStatus = n.GetEnumValue<GroupPolicyOperationStatus>(); } },
                {"operationType", n => { OperationType = n.GetEnumValue<GroupPolicyOperationType>(); } },
                {"statusDetails", n => { StatusDetails = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<GroupPolicyOperationStatus>("operationStatus", OperationStatus);
            writer.WriteEnumValue<GroupPolicyOperationType>("operationType", OperationType);
            writer.WriteStringValue("statusDetails", StatusDetails);
        }
    }
}

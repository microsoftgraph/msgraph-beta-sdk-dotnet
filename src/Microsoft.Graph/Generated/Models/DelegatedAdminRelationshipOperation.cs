using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class DelegatedAdminRelationshipOperation : Entity, IParsable {
        /// <summary>The time in ISO 8601 format and in UTC time when the long-running operation was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The data (payload) for the operation. Read-only.</summary>
        public string Data {
            get { return BackingStore?.Get<string>(nameof(Data)); }
            set { BackingStore?.Set(nameof(Data), value); }
        }
        /// <summary>The time in ISO 8601 format and in UTC time when the long-running operation was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The type of long-running operation. The possible values are: delegatedAdminAccessAssignmentUpdate, unknownFutureValue. Read-only.</summary>
        public DelegatedAdminRelationshipOperationType? OperationType {
            get { return BackingStore?.Get<DelegatedAdminRelationshipOperationType?>(nameof(OperationType)); }
            set { BackingStore?.Set(nameof(OperationType), value); }
        }
        /// <summary>The status of the operation. Read-only. The possible values are: notStarted, running, complete, failed, unknownFutureValue. Read-only. Supports $orderBy.</summary>
        public DelegatedAdminRelationshipOperationStatus? Status {
            get { return BackingStore?.Get<DelegatedAdminRelationshipOperationStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DelegatedAdminRelationshipOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminRelationshipOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"data", n => { Data = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationType", n => { OperationType = n.GetEnumValue<DelegatedAdminRelationshipOperationType>(); } },
                {"status", n => { Status = n.GetEnumValue<DelegatedAdminRelationshipOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("data", Data);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<DelegatedAdminRelationshipOperationType>("operationType", OperationType);
            writer.WriteEnumValue<DelegatedAdminRelationshipOperationStatus>("status", Status);
        }
    }
}

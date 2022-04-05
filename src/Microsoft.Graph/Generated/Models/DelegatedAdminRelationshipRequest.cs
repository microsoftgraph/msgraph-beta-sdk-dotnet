using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DelegatedAdminRelationshipRequest : Entity, IParsable {
        /// <summary>The action to be performed on the delegated admin relationship.</summary>
        public DelegatedAdminRelationshipRequestAction? Action { get; set; }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the relationship request was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The date and time in ISO 8601 format and UTC time when this relationship request was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The status of the request. Read-only. The possible values are: created, pending, complete, failed, unknownFutureValue.</summary>
        public DelegatedAdminRelationshipRequestStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DelegatedAdminRelationshipRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminRelationshipRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"action", (o,n) => { (o as DelegatedAdminRelationshipRequest).Action = n.GetEnumValue<DelegatedAdminRelationshipRequestAction>(); } },
                {"createdDateTime", (o,n) => { (o as DelegatedAdminRelationshipRequest).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DelegatedAdminRelationshipRequest).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as DelegatedAdminRelationshipRequest).Status = n.GetEnumValue<DelegatedAdminRelationshipRequestStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DelegatedAdminRelationshipRequestAction>("action", Action);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<DelegatedAdminRelationshipRequestStatus>("status", Status);
        }
    }
}

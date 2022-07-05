using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class DelegatedAdminAccessAssignment : Entity, IParsable {
        /// <summary>The accessContainer property</summary>
        public DelegatedAdminAccessContainer AccessContainer {
            get { return BackingStore?.Get<DelegatedAdminAccessContainer>(nameof(AccessContainer)); }
            set { BackingStore?.Set(nameof(AccessContainer), value); }
        }
        /// <summary>The accessDetails property</summary>
        public DelegatedAdminAccessDetails AccessDetails {
            get { return BackingStore?.Get<DelegatedAdminAccessDetails>(nameof(AccessDetails)); }
            set { BackingStore?.Set(nameof(AccessDetails), value); }
        }
        /// <summary>The date and time in ISO 8601 format and in UTC time when the access assignment was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The date and time in ISO 8601 and in UTC time when this access assignment was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The status of the access assignment. Read-only. The possible values are: pending, active, deleting, deleted, error, unknownFutureValue.</summary>
        public DelegatedAdminAccessAssignmentStatus? Status {
            get { return BackingStore?.Get<DelegatedAdminAccessAssignmentStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DelegatedAdminAccessAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminAccessAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessContainer", n => { AccessContainer = n.GetObjectValue<DelegatedAdminAccessContainer>(DelegatedAdminAccessContainer.CreateFromDiscriminatorValue); } },
                {"accessDetails", n => { AccessDetails = n.GetObjectValue<DelegatedAdminAccessDetails>(DelegatedAdminAccessDetails.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<DelegatedAdminAccessAssignmentStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DelegatedAdminAccessContainer>("accessContainer", AccessContainer);
            writer.WriteObjectValue<DelegatedAdminAccessDetails>("accessDetails", AccessDetails);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<DelegatedAdminAccessAssignmentStatus>("status", Status);
        }
    }
}

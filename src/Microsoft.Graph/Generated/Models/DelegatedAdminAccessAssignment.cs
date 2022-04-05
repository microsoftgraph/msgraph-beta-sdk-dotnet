using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DelegatedAdminAccessAssignment : Entity, IParsable {
        /// <summary>The accessContainer property</summary>
        public DelegatedAdminAccessContainer AccessContainer { get; set; }
        /// <summary>The accessDetails property</summary>
        public DelegatedAdminAccessDetails AccessDetails { get; set; }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The status property</summary>
        public DelegatedAdminAccessAssignmentStatus? Status { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessContainer", (o,n) => { (o as DelegatedAdminAccessAssignment).AccessContainer = n.GetObjectValue<DelegatedAdminAccessContainer>(DelegatedAdminAccessContainer.CreateFromDiscriminatorValue); } },
                {"accessDetails", (o,n) => { (o as DelegatedAdminAccessAssignment).AccessDetails = n.GetObjectValue<DelegatedAdminAccessDetails>(DelegatedAdminAccessDetails.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as DelegatedAdminAccessAssignment).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DelegatedAdminAccessAssignment).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as DelegatedAdminAccessAssignment).Status = n.GetEnumValue<DelegatedAdminAccessAssignmentStatus>(); } },
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

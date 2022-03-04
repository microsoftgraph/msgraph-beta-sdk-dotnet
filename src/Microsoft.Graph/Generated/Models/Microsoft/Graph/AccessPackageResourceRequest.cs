using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AccessPackageResourceRequest : Entity, IParsable {
        /// <summary>Nullable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResource AccessPackageResource { get; set; }
        /// <summary>The unique ID of the access package catalog.</summary>
        public string CatalogId { get; set; }
        public bool? ExecuteImmediately { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>If set, does not add the resource.</summary>
        public bool? IsValidationOnly { get; set; }
        /// <summary>The requestor's justification for adding or removing the resource.</summary>
        public string Justification { get; set; }
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public AccessPackageSubject Requestor { get; set; }
        /// <summary>The outcome of whether the service was able to add the resource to the catalog.  The value is Delivered if the resource was added or removed. Read-Only.</summary>
        public string RequestState { get; set; }
        /// <summary>Read-only.</summary>
        public string RequestStatus { get; set; }
        /// <summary>Use AdminAdd to add a resource, if the caller is an administrator or resource owner, or AdminRemove to remove a resource.</summary>
        public string RequestType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageResourceRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageResource", (o,n) => { (o as AccessPackageResourceRequest).AccessPackageResource = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResource>(MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResource.CreateFromDiscriminatorValue); } },
                {"catalogId", (o,n) => { (o as AccessPackageResourceRequest).CatalogId = n.GetStringValue(); } },
                {"executeImmediately", (o,n) => { (o as AccessPackageResourceRequest).ExecuteImmediately = n.GetBoolValue(); } },
                {"expirationDateTime", (o,n) => { (o as AccessPackageResourceRequest).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"isValidationOnly", (o,n) => { (o as AccessPackageResourceRequest).IsValidationOnly = n.GetBoolValue(); } },
                {"justification", (o,n) => { (o as AccessPackageResourceRequest).Justification = n.GetStringValue(); } },
                {"requestor", (o,n) => { (o as AccessPackageResourceRequest).Requestor = n.GetObjectValue<AccessPackageSubject>(AccessPackageSubject.CreateFromDiscriminatorValue); } },
                {"requestState", (o,n) => { (o as AccessPackageResourceRequest).RequestState = n.GetStringValue(); } },
                {"requestStatus", (o,n) => { (o as AccessPackageResourceRequest).RequestStatus = n.GetStringValue(); } },
                {"requestType", (o,n) => { (o as AccessPackageResourceRequest).RequestType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AccessPackageResource>("accessPackageResource", AccessPackageResource);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteBoolValue("executeImmediately", ExecuteImmediately);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<AccessPackageSubject>("requestor", Requestor);
            writer.WriteStringValue("requestState", RequestState);
            writer.WriteStringValue("requestStatus", RequestStatus);
            writer.WriteStringValue("requestType", RequestType);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class AccessPackageResourceRequest : Entity, IParsable {
        /// <summary>The accessPackageResource property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageResource AccessPackageResource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResource>(nameof(AccessPackageResource)); }
            set { BackingStore?.Set(nameof(AccessPackageResource), value); }
        }
        /// <summary>The unique ID of the access package catalog.</summary>
        public string CatalogId {
            get { return BackingStore?.Get<string>(nameof(CatalogId)); }
            set { BackingStore?.Set(nameof(CatalogId), value); }
        }
        /// <summary>The executeImmediately property</summary>
        public bool? ExecuteImmediately {
            get { return BackingStore?.Get<bool?>(nameof(ExecuteImmediately)); }
            set { BackingStore?.Set(nameof(ExecuteImmediately), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ExpirationDateTime), value); }
        }
        /// <summary>If set, does not add the resource.</summary>
        public bool? IsValidationOnly {
            get { return BackingStore?.Get<bool?>(nameof(IsValidationOnly)); }
            set { BackingStore?.Set(nameof(IsValidationOnly), value); }
        }
        /// <summary>The requestor&apos;s justification for adding or removing the resource.</summary>
        public string Justification {
            get { return BackingStore?.Get<string>(nameof(Justification)); }
            set { BackingStore?.Set(nameof(Justification), value); }
        }
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public AccessPackageSubject Requestor {
            get { return BackingStore?.Get<AccessPackageSubject>(nameof(Requestor)); }
            set { BackingStore?.Set(nameof(Requestor), value); }
        }
        /// <summary>The outcome of whether the service was able to add the resource to the catalog.  The value is Delivered if the resource was added or removed. Read-Only.</summary>
        public string RequestState {
            get { return BackingStore?.Get<string>(nameof(RequestState)); }
            set { BackingStore?.Set(nameof(RequestState), value); }
        }
        /// <summary>The requestStatus property</summary>
        public string RequestStatus {
            get { return BackingStore?.Get<string>(nameof(RequestStatus)); }
            set { BackingStore?.Set(nameof(RequestStatus), value); }
        }
        /// <summary>Use AdminAdd to add a resource, if the caller is an administrator or resource owner, or AdminRemove to remove a resource.</summary>
        public string RequestType {
            get { return BackingStore?.Get<string>(nameof(RequestType)); }
            set { BackingStore?.Set(nameof(RequestType), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageResource", n => { AccessPackageResource = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>(Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue); } },
                {"catalogId", n => { CatalogId = n.GetStringValue(); } },
                {"executeImmediately", n => { ExecuteImmediately = n.GetBoolValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"requestor", n => { Requestor = n.GetObjectValue<AccessPackageSubject>(AccessPackageSubject.CreateFromDiscriminatorValue); } },
                {"requestState", n => { RequestState = n.GetStringValue(); } },
                {"requestStatus", n => { RequestStatus = n.GetStringValue(); } },
                {"requestType", n => { RequestType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource", AccessPackageResource);
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

using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageResourceRequest : Entity, IParsable {
        /// <summary>The accessPackageResource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessPackageResource? AccessPackageResource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResource?>("accessPackageResource"); }
            set { BackingStore?.Set("accessPackageResource", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessPackageResource AccessPackageResource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource"); }
            set { BackingStore?.Set("accessPackageResource", value); }
        }
#endif
        /// <summary>The unique ID of the access package catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogId {
            get { return BackingStore?.Get<string?>("catalogId"); }
            set { BackingStore?.Set("catalogId", value); }
        }
#nullable restore
#else
        public string CatalogId {
            get { return BackingStore?.Get<string>("catalogId"); }
            set { BackingStore?.Set("catalogId", value); }
        }
#endif
        /// <summary>The executeImmediately property</summary>
        public bool? ExecuteImmediately {
            get { return BackingStore?.Get<bool?>("executeImmediately"); }
            set { BackingStore?.Set("executeImmediately", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>If set, does not add the resource.</summary>
        public bool? IsValidationOnly {
            get { return BackingStore?.Get<bool?>("isValidationOnly"); }
            set { BackingStore?.Set("isValidationOnly", value); }
        }
        /// <summary>The requestor&apos;s justification for adding or removing the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification {
            get { return BackingStore?.Get<string?>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#nullable restore
#else
        public string Justification {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageSubject? Requestor {
            get { return BackingStore?.Get<AccessPackageSubject?>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#nullable restore
#else
        public AccessPackageSubject Requestor {
            get { return BackingStore?.Get<AccessPackageSubject>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#endif
        /// <summary>The outcome of whether the service was able to add the resource to the catalog.  The value is Delivered if the resource was added or removed. Read-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestState {
            get { return BackingStore?.Get<string?>("requestState"); }
            set { BackingStore?.Set("requestState", value); }
        }
#nullable restore
#else
        public string RequestState {
            get { return BackingStore?.Get<string>("requestState"); }
            set { BackingStore?.Set("requestState", value); }
        }
#endif
        /// <summary>The requestStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestStatus {
            get { return BackingStore?.Get<string?>("requestStatus"); }
            set { BackingStore?.Set("requestStatus", value); }
        }
#nullable restore
#else
        public string RequestStatus {
            get { return BackingStore?.Get<string>("requestStatus"); }
            set { BackingStore?.Set("requestStatus", value); }
        }
#endif
        /// <summary>Use AdminAdd to add a resource, if the caller is an administrator or resource owner, AdminUpdate to update a resource, or AdminRemove to remove a resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestType {
            get { return BackingStore?.Get<string?>("requestType"); }
            set { BackingStore?.Set("requestType", value); }
        }
#nullable restore
#else
        public string RequestType {
            get { return BackingStore?.Get<string>("requestType"); }
            set { BackingStore?.Set("requestType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageAssignmentPolicy : Entity, IParsable {
        /// <summary>The access package with this policy. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessPackage? AccessPackage {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackage?>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessPackage AccessPackage {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackage>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#endif
        /// <summary>The accessPackageCatalog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessPackageCatalog? AccessPackageCatalog {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageCatalog?>("accessPackageCatalog"); }
            set { BackingStore?.Set("accessPackageCatalog", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessPackageCatalog AccessPackageCatalog {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageCatalog>("accessPackageCatalog"); }
            set { BackingStore?.Set("accessPackageCatalog", value); }
        }
#endif
        /// <summary>Identifier of the access package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessPackageId {
            get { return BackingStore?.Get<string?>("accessPackageId"); }
            set { BackingStore?.Set("accessPackageId", value); }
        }
#nullable restore
#else
        public string AccessPackageId {
            get { return BackingStore?.Get<string>("accessPackageId"); }
            set { BackingStore?.Set("accessPackageId", value); }
        }
#endif
        /// <summary>Who must review, and how often, the assignments to the access package from this policy. This property is null if reviews are not required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AssignmentReviewSettings? AccessReviewSettings {
            get { return BackingStore?.Get<AssignmentReviewSettings?>("accessReviewSettings"); }
            set { BackingStore?.Set("accessReviewSettings", value); }
        }
#nullable restore
#else
        public AssignmentReviewSettings AccessReviewSettings {
            get { return BackingStore?.Get<AssignmentReviewSettings>("accessReviewSettings"); }
            set { BackingStore?.Set("accessReviewSettings", value); }
        }
#endif
        /// <summary>Indicates whether a user can extend the access package assignment duration after approval.</summary>
        public bool? CanExtend {
            get { return BackingStore?.Get<bool?>("canExtend"); }
            set { BackingStore?.Set("canExtend", value); }
        }
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy {
            get { return BackingStore?.Get<string?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public string CreatedBy {
            get { return BackingStore?.Get<string>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomExtensionHandler>? CustomExtensionHandlers {
            get { return BackingStore?.Get<List<CustomExtensionHandler>?>("customExtensionHandlers"); }
            set { BackingStore?.Set("customExtensionHandlers", value); }
        }
#nullable restore
#else
        public List<CustomExtensionHandler> CustomExtensionHandlers {
            get { return BackingStore?.Get<List<CustomExtensionHandler>>("customExtensionHandlers"); }
            set { BackingStore?.Set("customExtensionHandlers", value); }
        }
#endif
        /// <summary>The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomExtensionStageSetting>? CustomExtensionStageSettings {
            get { return BackingStore?.Get<List<CustomExtensionStageSetting>?>("customExtensionStageSettings"); }
            set { BackingStore?.Set("customExtensionStageSettings", value); }
        }
#nullable restore
#else
        public List<CustomExtensionStageSetting> CustomExtensionStageSettings {
            get { return BackingStore?.Get<List<CustomExtensionStageSetting>>("customExtensionStageSettings"); }
            set { BackingStore?.Set("customExtensionStageSettings", value); }
        }
#endif
        /// <summary>The description of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the policy. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The number of days in which assignments from this policy last until they are expired.</summary>
        public int? DurationInDays {
            get { return BackingStore?.Get<int?>("durationInDays"); }
            set { BackingStore?.Set("durationInDays", value); }
        }
        /// <summary>The expiration date for assignments created in this policy. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The modifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModifiedBy {
            get { return BackingStore?.Get<string?>("modifiedBy"); }
            set { BackingStore?.Set("modifiedBy", value); }
        }
#nullable restore
#else
        public string ModifiedBy {
            get { return BackingStore?.Get<string>("modifiedBy"); }
            set { BackingStore?.Set("modifiedBy", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>Questions that are posed to the  requestor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageQuestion>? Questions {
            get { return BackingStore?.Get<List<AccessPackageQuestion>?>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#nullable restore
#else
        public List<AccessPackageQuestion> Questions {
            get { return BackingStore?.Get<List<AccessPackageQuestion>>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#endif
        /// <summary>Who must approve requests for access package in this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApprovalSettings? RequestApprovalSettings {
            get { return BackingStore?.Get<ApprovalSettings?>("requestApprovalSettings"); }
            set { BackingStore?.Set("requestApprovalSettings", value); }
        }
#nullable restore
#else
        public ApprovalSettings RequestApprovalSettings {
            get { return BackingStore?.Get<ApprovalSettings>("requestApprovalSettings"); }
            set { BackingStore?.Set("requestApprovalSettings", value); }
        }
#endif
        /// <summary>Who can request this access package from this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.RequestorSettings? RequestorSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RequestorSettings?>("requestorSettings"); }
            set { BackingStore?.Set("requestorSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.RequestorSettings RequestorSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RequestorSettings>("requestorSettings"); }
            set { BackingStore?.Set("requestorSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageAssignmentPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackage", n => { AccessPackage = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackage>(Microsoft.Graph.Beta.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                {"accessPackageCatalog", n => { AccessPackageCatalog = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageCatalog>(Microsoft.Graph.Beta.Models.AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                {"accessPackageId", n => { AccessPackageId = n.GetStringValue(); } },
                {"accessReviewSettings", n => { AccessReviewSettings = n.GetObjectValue<AssignmentReviewSettings>(AssignmentReviewSettings.CreateFromDiscriminatorValue); } },
                {"canExtend", n => { CanExtend = n.GetBoolValue(); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customExtensionHandlers", n => { CustomExtensionHandlers = n.GetCollectionOfObjectValues<CustomExtensionHandler>(CustomExtensionHandler.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customExtensionStageSettings", n => { CustomExtensionStageSettings = n.GetCollectionOfObjectValues<CustomExtensionStageSetting>(CustomExtensionStageSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"durationInDays", n => { DurationInDays = n.GetIntValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"questions", n => { Questions = n.GetCollectionOfObjectValues<AccessPackageQuestion>(AccessPackageQuestion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"requestApprovalSettings", n => { RequestApprovalSettings = n.GetObjectValue<ApprovalSettings>(ApprovalSettings.CreateFromDiscriminatorValue); } },
                {"requestorSettings", n => { RequestorSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.RequestorSettings>(Microsoft.Graph.Beta.Models.RequestorSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageCatalog>("accessPackageCatalog", AccessPackageCatalog);
            writer.WriteStringValue("accessPackageId", AccessPackageId);
            writer.WriteObjectValue<AssignmentReviewSettings>("accessReviewSettings", AccessReviewSettings);
            writer.WriteBoolValue("canExtend", CanExtend);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<CustomExtensionHandler>("customExtensionHandlers", CustomExtensionHandlers);
            writer.WriteCollectionOfObjectValues<CustomExtensionStageSetting>("customExtensionStageSettings", CustomExtensionStageSettings);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteCollectionOfObjectValues<AccessPackageQuestion>("questions", Questions);
            writer.WriteObjectValue<ApprovalSettings>("requestApprovalSettings", RequestApprovalSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RequestorSettings>("requestorSettings", RequestorSettings);
        }
    }
}

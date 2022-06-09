using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class AccessPackageAssignmentPolicy : Entity, IParsable {
        /// <summary>The access package with this policy. Read-only. Nullable. Supports $expand.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackage AccessPackage {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackage>(nameof(AccessPackage)); }
            set { BackingStore?.Set(nameof(AccessPackage), value); }
        }
        /// <summary>The accessPackageCatalog property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageCatalog AccessPackageCatalog {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageCatalog>(nameof(AccessPackageCatalog)); }
            set { BackingStore?.Set(nameof(AccessPackageCatalog), value); }
        }
        /// <summary>Identifier of the access package.</summary>
        public string AccessPackageId {
            get { return BackingStore?.Get<string>(nameof(AccessPackageId)); }
            set { BackingStore?.Set(nameof(AccessPackageId), value); }
        }
        /// <summary>Who must review, and how often, the assignments to the access package from this policy. This property is null if reviews are not required.</summary>
        public AssignmentReviewSettings AccessReviewSettings {
            get { return BackingStore?.Get<AssignmentReviewSettings>(nameof(AccessReviewSettings)); }
            set { BackingStore?.Set(nameof(AccessReviewSettings), value); }
        }
        /// <summary>Indicates whether a user can extend the access package assignment duration after approval.</summary>
        public bool? CanExtend {
            get { return BackingStore?.Get<bool?>(nameof(CanExtend)); }
            set { BackingStore?.Set(nameof(CanExtend), value); }
        }
        /// <summary>The createdBy property</summary>
        public string CreatedBy {
            get { return BackingStore?.Get<string>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.</summary>
        public List<CustomExtensionHandler> CustomExtensionHandlers {
            get { return BackingStore?.Get<List<CustomExtensionHandler>>(nameof(CustomExtensionHandlers)); }
            set { BackingStore?.Set(nameof(CustomExtensionHandlers), value); }
        }
        /// <summary>The description of the policy.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name of the policy. Supports $filter (eq).</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The number of days in which assignments from this policy last until they are expired.</summary>
        public int? DurationInDays {
            get { return BackingStore?.Get<int?>(nameof(DurationInDays)); }
            set { BackingStore?.Set(nameof(DurationInDays), value); }
        }
        /// <summary>The expiration date for assignments created in this policy. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ExpirationDateTime), value); }
        }
        /// <summary>The modifiedBy property</summary>
        public string ModifiedBy {
            get { return BackingStore?.Get<string>(nameof(ModifiedBy)); }
            set { BackingStore?.Set(nameof(ModifiedBy), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ModifiedDateTime)); }
            set { BackingStore?.Set(nameof(ModifiedDateTime), value); }
        }
        /// <summary>Questions that are posed to the  requestor.</summary>
        public List<AccessPackageQuestion> Questions {
            get { return BackingStore?.Get<List<AccessPackageQuestion>>(nameof(Questions)); }
            set { BackingStore?.Set(nameof(Questions), value); }
        }
        /// <summary>Who must approve requests for access package in this policy.</summary>
        public ApprovalSettings RequestApprovalSettings {
            get { return BackingStore?.Get<ApprovalSettings>(nameof(RequestApprovalSettings)); }
            set { BackingStore?.Set(nameof(RequestApprovalSettings), value); }
        }
        /// <summary>Who can request this access package from this policy.</summary>
        public Microsoft.Graph.Beta.Models.RequestorSettings RequestorSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RequestorSettings>(nameof(RequestorSettings)); }
            set { BackingStore?.Set(nameof(RequestorSettings), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"customExtensionHandlers", n => { CustomExtensionHandlers = n.GetCollectionOfObjectValues<CustomExtensionHandler>(CustomExtensionHandler.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"durationInDays", n => { DurationInDays = n.GetIntValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"questions", n => { Questions = n.GetCollectionOfObjectValues<AccessPackageQuestion>(AccessPackageQuestion.CreateFromDiscriminatorValue).ToList(); } },
                {"requestApprovalSettings", n => { RequestApprovalSettings = n.GetObjectValue<ApprovalSettings>(ApprovalSettings.CreateFromDiscriminatorValue); } },
                {"requestorSettings", n => { RequestorSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.RequestorSettings>(Microsoft.Graph.Beta.Models.RequestorSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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

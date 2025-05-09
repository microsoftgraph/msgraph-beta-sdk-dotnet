// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AccessPackageAssignment : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property and $expand query parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AccessPackage? AccessPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackage?>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AccessPackage AccessPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackage>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy? AccessPackageAssignmentPolicy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy?>("accessPackageAssignmentPolicy"); }
            set { BackingStore?.Set("accessPackageAssignmentPolicy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy AccessPackageAssignmentPolicy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicy"); }
            set { BackingStore?.Set("accessPackageAssignmentPolicy", value); }
        }
#endif
        /// <summary>The accessPackageAssignmentRequests property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>? AccessPackageAssignmentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>?>("accessPackageAssignmentRequests"); }
            set { BackingStore?.Set("accessPackageAssignmentRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest> AccessPackageAssignmentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>>("accessPackageAssignmentRequests"); }
            set { BackingStore?.Set("accessPackageAssignmentRequests", value); }
        }
#endif
        /// <summary>The resource roles delivered to the target user for this assignment. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>? AccessPackageAssignmentResourceRoles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>?>("accessPackageAssignmentResourceRoles"); }
            set { BackingStore?.Set("accessPackageAssignmentResourceRoles", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole> AccessPackageAssignmentResourceRoles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>>("accessPackageAssignmentResourceRoles"); }
            set { BackingStore?.Set("accessPackageAssignmentResourceRoles", value); }
        }
#endif
        /// <summary>The identifier of the access package. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessPackageId
        {
            get { return BackingStore?.Get<string?>("accessPackageId"); }
            set { BackingStore?.Set("accessPackageId", value); }
        }
#nullable restore
#else
        public string AccessPackageId
        {
            get { return BackingStore?.Get<string>("accessPackageId"); }
            set { BackingStore?.Set("accessPackageId", value); }
        }
#endif
        /// <summary>The identifier of the access package assignment policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentPolicyId
        {
            get { return BackingStore?.Get<string?>("assignmentPolicyId"); }
            set { BackingStore?.Set("assignmentPolicyId", value); }
        }
#nullable restore
#else
        public string AssignmentPolicyId
        {
            get { return BackingStore?.Get<string>("assignmentPolicyId"); }
            set { BackingStore?.Set("assignmentPolicyId", value); }
        }
#endif
        /// <summary>The state of the access package assignment. Possible values are Delivering, Delivered, or Expired. Read-only. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentState
        {
            get { return BackingStore?.Get<string?>("assignmentState"); }
            set { BackingStore?.Set("assignmentState", value); }
        }
#nullable restore
#else
        public string AssignmentState
        {
            get { return BackingStore?.Get<string>("assignmentState"); }
            set { BackingStore?.Set("assignmentState", value); }
        }
#endif
        /// <summary>More information about the assignment lifecycle. Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentStatus
        {
            get { return BackingStore?.Get<string?>("assignmentStatus"); }
            set { BackingStore?.Set("assignmentStatus", value); }
        }
#nullable restore
#else
        public string AssignmentStatus
        {
            get { return BackingStore?.Get<string>("assignmentStatus"); }
            set { BackingStore?.Set("assignmentStatus", value); }
        }
#endif
        /// <summary>The identifier of the catalog containing the access package. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogId
        {
            get { return BackingStore?.Get<string?>("catalogId"); }
            set { BackingStore?.Set("catalogId", value); }
        }
#nullable restore
#else
        public string CatalogId
        {
            get { return BackingStore?.Get<string>("catalogId"); }
            set { BackingStore?.Set("catalogId", value); }
        }
#endif
        /// <summary>Information about all the custom extension calls that were made during the access package assignment workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CustomExtensionCalloutInstance>? CustomExtensionCalloutInstances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomExtensionCalloutInstance>?>("customExtensionCalloutInstances"); }
            set { BackingStore?.Set("customExtensionCalloutInstances", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CustomExtensionCalloutInstance> CustomExtensionCalloutInstances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomExtensionCalloutInstance>>("customExtensionCalloutInstances"); }
            set { BackingStore?.Set("customExtensionCalloutInstances", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpiredDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expiredDateTime"); }
            set { BackingStore?.Set("expiredDateTime", value); }
        }
        /// <summary>Indicates whether the access package assignment is extended. Read-only.</summary>
        public bool? IsExtended
        {
            get { return BackingStore?.Get<bool?>("isExtended"); }
            set { BackingStore?.Set("isExtended", value); }
        }
        /// <summary>When the access assignment is to be in place. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.RequestSchedule? Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.RequestSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.RequestSchedule Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.RequestSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>The subject of the access package assignment. Read-only. Nullable. Supports $expand. Supports $filter (eq) on objectId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AccessPackageSubject? Target
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageSubject?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AccessPackageSubject Target
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageSubject>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>This property should not be used as a dependency, as it may change without notice. Instead, expand the target relationship and use the objectId property. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetId
        {
            get { return BackingStore?.Get<string?>("targetId"); }
            set { BackingStore?.Set("targetId", value); }
        }
#nullable restore
#else
        public string TargetId
        {
            get { return BackingStore?.Get<string>("targetId"); }
            set { BackingStore?.Set("targetId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AccessPackageAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AccessPackageAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackage", n => { AccessPackage = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackage>(global::Microsoft.Graph.Beta.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                { "accessPackageAssignmentPolicy", n => { AccessPackageAssignmentPolicy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>(global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue); } },
                { "accessPackageAssignmentRequests", n => { AccessPackageAssignmentRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>(global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "accessPackageAssignmentResourceRoles", n => { AccessPackageAssignmentResourceRoles = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>(global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole.CreateFromDiscriminatorValue)?.AsList(); } },
                { "accessPackageId", n => { AccessPackageId = n.GetStringValue(); } },
                { "assignmentPolicyId", n => { AssignmentPolicyId = n.GetStringValue(); } },
                { "assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                { "assignmentStatus", n => { AssignmentStatus = n.GetStringValue(); } },
                { "catalogId", n => { CatalogId = n.GetStringValue(); } },
                { "customExtensionCalloutInstances", n => { CustomExtensionCalloutInstances = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomExtensionCalloutInstance>(global::Microsoft.Graph.Beta.Models.CustomExtensionCalloutInstance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "expiredDateTime", n => { ExpiredDateTime = n.GetDateTimeOffsetValue(); } },
                { "isExtended", n => { IsExtended = n.GetBoolValue(); } },
                { "schedule", n => { Schedule = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.RequestSchedule>(global::Microsoft.Graph.Beta.Models.RequestSchedule.CreateFromDiscriminatorValue); } },
                { "target", n => { Target = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackageSubject>(global::Microsoft.Graph.Beta.Models.AccessPackageSubject.CreateFromDiscriminatorValue); } },
                { "targetId", n => { TargetId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicy", AccessPackageAssignmentPolicy);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>("accessPackageAssignmentRequests", AccessPackageAssignmentRequests);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>("accessPackageAssignmentResourceRoles", AccessPackageAssignmentResourceRoles);
            writer.WriteStringValue("accessPackageId", AccessPackageId);
            writer.WriteStringValue("assignmentPolicyId", AssignmentPolicyId);
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteStringValue("assignmentStatus", AssignmentStatus);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomExtensionCalloutInstance>("customExtensionCalloutInstances", CustomExtensionCalloutInstances);
            writer.WriteDateTimeOffsetValue("expiredDateTime", ExpiredDateTime);
            writer.WriteBoolValue("isExtended", IsExtended);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.RequestSchedule>("schedule", Schedule);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackageSubject>("target", Target);
            writer.WriteStringValue("targetId", TargetId);
        }
    }
}
#pragma warning restore CS0618

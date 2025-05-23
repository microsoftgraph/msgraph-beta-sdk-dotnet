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
    public partial class GovernanceRoleAssignment : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The state of the assignment. The value can be Eligible for eligible assignment or Active if it&apos;s directly assigned Active by administrators, or activated on an eligible assignment by the users.</summary>
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
        /// <summary>For a non-permanent role assignment, this is the time when the role assignment is expired. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The external ID the resource that is used to identify the role assignment in the provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId
        {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId
        {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>Read-only. If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment? LinkedEligibleRoleAssignment
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment?>("linkedEligibleRoleAssignment"); }
            set { BackingStore?.Set("linkedEligibleRoleAssignment", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment LinkedEligibleRoleAssignment
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment>("linkedEligibleRoleAssignment"); }
            set { BackingStore?.Set("linkedEligibleRoleAssignment", value); }
        }
#endif
        /// <summary>If this is an active assignment and created due to activation on an eligible assignment, it represents the ID of that eligible assignment; Otherwise, the value is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkedEligibleRoleAssignmentId
        {
            get { return BackingStore?.Get<string?>("linkedEligibleRoleAssignmentId"); }
            set { BackingStore?.Set("linkedEligibleRoleAssignmentId", value); }
        }
#nullable restore
#else
        public string LinkedEligibleRoleAssignmentId
        {
            get { return BackingStore?.Get<string>("linkedEligibleRoleAssignmentId"); }
            set { BackingStore?.Set("linkedEligibleRoleAssignmentId", value); }
        }
#endif
        /// <summary>The type of member. The value can be: Inherited (if the role assignment is inherited from a parent resource scope), Group (if the role assignment isn&apos;t inherited, but comes from the membership of a group assignment), or User (if the role assignment isn&apos;t inherited or from a group assignment).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberType
        {
            get { return BackingStore?.Get<string?>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
#nullable restore
#else
        public string MemberType
        {
            get { return BackingStore?.Get<string>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
#endif
        /// <summary>Read-only. The resource associated with the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.GovernanceResource? Resource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceResource?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.GovernanceResource Resource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceResource>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>Required. The ID of the resource that the role assignment is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId
        {
            get { return BackingStore?.Get<string?>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#nullable restore
#else
        public string ResourceId
        {
            get { return BackingStore?.Get<string>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#endif
        /// <summary>Read-only. The role definition associated with the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition? RoleDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition?>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition RoleDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#endif
        /// <summary>Required. The ID of the role definition that the role assignment is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId
        {
            get { return BackingStore?.Get<string?>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#nullable restore
#else
        public string RoleDefinitionId
        {
            get { return BackingStore?.Get<string>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#endif
        /// <summary>The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status
        {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status
        {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>Read-only. The subject associated with the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.GovernanceSubject? Subject
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceSubject?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.GovernanceSubject Subject
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceSubject>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>Required. The ID of the subject that the role assignment is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectId
        {
            get { return BackingStore?.Get<string?>("subjectId"); }
            set { BackingStore?.Set("subjectId", value); }
        }
#nullable restore
#else
        public string SubjectId
        {
            get { return BackingStore?.Get<string>("subjectId"); }
            set { BackingStore?.Set("subjectId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "linkedEligibleRoleAssignment", n => { LinkedEligibleRoleAssignment = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment>(global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment.CreateFromDiscriminatorValue); } },
                { "linkedEligibleRoleAssignmentId", n => { LinkedEligibleRoleAssignmentId = n.GetStringValue(); } },
                { "memberType", n => { MemberType = n.GetStringValue(); } },
                { "resource", n => { Resource = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceResource>(global::Microsoft.Graph.Beta.Models.GovernanceResource.CreateFromDiscriminatorValue); } },
                { "resourceId", n => { ResourceId = n.GetStringValue(); } },
                { "roleDefinition", n => { RoleDefinition = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>(global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition.CreateFromDiscriminatorValue); } },
                { "roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceSubject>(global::Microsoft.Graph.Beta.Models.GovernanceSubject.CreateFromDiscriminatorValue); } },
                { "subjectId", n => { SubjectId = n.GetStringValue(); } },
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
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment>("linkedEligibleRoleAssignment", LinkedEligibleRoleAssignment);
            writer.WriteStringValue("linkedEligibleRoleAssignmentId", LinkedEligibleRoleAssignmentId);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceSubject>("subject", Subject);
            writer.WriteStringValue("subjectId", SubjectId);
        }
    }
}
#pragma warning restore CS0618

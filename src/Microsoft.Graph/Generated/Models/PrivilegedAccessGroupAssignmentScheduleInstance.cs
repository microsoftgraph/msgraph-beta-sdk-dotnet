using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedAccessGroupAssignmentScheduleInstance : PrivilegedAccessScheduleInstance, IParsable {
        /// <summary>The accessId property</summary>
        public PrivilegedAccessGroupRelationships? AccessId {
            get { return BackingStore?.Get<PrivilegedAccessGroupRelationships?>("accessId"); }
            set { BackingStore?.Set("accessId", value); }
        }
        /// <summary>The activatedUsing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrivilegedAccessGroupEligibilityScheduleInstance? ActivatedUsing {
            get { return BackingStore?.Get<PrivilegedAccessGroupEligibilityScheduleInstance?>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#nullable restore
#else
        public PrivilegedAccessGroupEligibilityScheduleInstance ActivatedUsing {
            get { return BackingStore?.Get<PrivilegedAccessGroupEligibilityScheduleInstance>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#endif
        /// <summary>The assignmentScheduleId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentScheduleId {
            get { return BackingStore?.Get<string?>("assignmentScheduleId"); }
            set { BackingStore?.Set("assignmentScheduleId", value); }
        }
#nullable restore
#else
        public string AssignmentScheduleId {
            get { return BackingStore?.Get<string>("assignmentScheduleId"); }
            set { BackingStore?.Set("assignmentScheduleId", value); }
        }
#endif
        /// <summary>The assignmentType property</summary>
        public PrivilegedAccessGroupAssignmentType? AssignmentType {
            get { return BackingStore?.Get<PrivilegedAccessGroupAssignmentType?>("assignmentType"); }
            set { BackingStore?.Set("assignmentType", value); }
        }
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Group? Group {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Group Group {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>The groupId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId {
            get { return BackingStore?.Get<string?>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#nullable restore
#else
        public string GroupId {
            get { return BackingStore?.Get<string>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#endif
        /// <summary>The memberType property</summary>
        public PrivilegedAccessGroupMemberType? MemberType {
            get { return BackingStore?.Get<PrivilegedAccessGroupMemberType?>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
        /// <summary>The principal property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Principal {
            get { return BackingStore?.Get<DirectoryObject?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#nullable restore
#else
        public DirectoryObject Principal {
            get { return BackingStore?.Get<DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>The principalId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId {
            get { return BackingStore?.Get<string?>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#nullable restore
#else
        public string PrincipalId {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new PrivilegedAccessGroupAssignmentScheduleInstance and sets the default values.
        /// </summary>
        public PrivilegedAccessGroupAssignmentScheduleInstance() : base() {
            OdataType = "#microsoft.graph.privilegedAccessGroupAssignmentScheduleInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedAccessGroupAssignmentScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccessGroupAssignmentScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessId", n => { AccessId = n.GetEnumValue<PrivilegedAccessGroupRelationships>(); } },
                {"activatedUsing", n => { ActivatedUsing = n.GetObjectValue<PrivilegedAccessGroupEligibilityScheduleInstance>(PrivilegedAccessGroupEligibilityScheduleInstance.CreateFromDiscriminatorValue); } },
                {"assignmentScheduleId", n => { AssignmentScheduleId = n.GetStringValue(); } },
                {"assignmentType", n => { AssignmentType = n.GetEnumValue<PrivilegedAccessGroupAssignmentType>(); } },
                {"group", n => { Group = n.GetObjectValue<Microsoft.Graph.Beta.Models.Group>(Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue); } },
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"memberType", n => { MemberType = n.GetEnumValue<PrivilegedAccessGroupMemberType>(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PrivilegedAccessGroupRelationships>("accessId", AccessId);
            writer.WriteObjectValue<PrivilegedAccessGroupEligibilityScheduleInstance>("activatedUsing", ActivatedUsing);
            writer.WriteStringValue("assignmentScheduleId", AssignmentScheduleId);
            writer.WriteEnumValue<PrivilegedAccessGroupAssignmentType>("assignmentType", AssignmentType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Group>("group", Group);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteEnumValue<PrivilegedAccessGroupMemberType>("memberType", MemberType);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
        }
    }
}

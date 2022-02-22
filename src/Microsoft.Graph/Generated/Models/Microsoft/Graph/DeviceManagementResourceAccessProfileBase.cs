using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementResourceAccessProfileBase : Entity, IParsable {
        /// <summary>The list of assignments for the device configuration profile.</summary>
        public List<DeviceManagementResourceAccessProfileAssignment> Assignments { get; set; }
        /// <summary>DateTime profile was created</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>Profile description</summary>
        public string Description { get; set; }
        /// <summary>Profile display name</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime profile was last modified</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Scope Tags</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Version of the profile</summary>
        public int? Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceManagementResourceAccessProfileBase).Assignments = n.GetCollectionOfObjectValues<DeviceManagementResourceAccessProfileAssignment>().ToList(); } },
                {"creationDateTime", (o,n) => { (o as DeviceManagementResourceAccessProfileBase).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceManagementResourceAccessProfileBase).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DeviceManagementResourceAccessProfileBase).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceManagementResourceAccessProfileBase).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceManagementResourceAccessProfileBase).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"version", (o,n) => { (o as DeviceManagementResourceAccessProfileBase).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementResourceAccessProfileAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteIntValue("version", Version);
        }
    }
}

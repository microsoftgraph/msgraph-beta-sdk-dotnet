using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PrivilegedRoleAssignment : Entity, IParsable {
        /// <summary>The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>true if the role assignment is activated. false if the role assignment is deactivated.</summary>
        public bool? IsElevated { get; set; }
        /// <summary>Result message set by the service.</summary>
        public string ResultMessage { get; set; }
        /// <summary>Role identifier. In GUID string format.</summary>
        public string RoleId { get; set; }
        /// <summary>Read-only. Nullable. The associated role information.</summary>
        public PrivilegedRole RoleInfo { get; set; }
        /// <summary>User identifier. In GUID string format.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"expirationDateTime", (o,n) => { (o as PrivilegedRoleAssignment).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"isElevated", (o,n) => { (o as PrivilegedRoleAssignment).IsElevated = n.GetBoolValue(); } },
                {"resultMessage", (o,n) => { (o as PrivilegedRoleAssignment).ResultMessage = n.GetStringValue(); } },
                {"roleId", (o,n) => { (o as PrivilegedRoleAssignment).RoleId = n.GetStringValue(); } },
                {"roleInfo", (o,n) => { (o as PrivilegedRoleAssignment).RoleInfo = n.GetObjectValue<PrivilegedRole>(); } },
                {"userId", (o,n) => { (o as PrivilegedRoleAssignment).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("isElevated", IsElevated);
            writer.WriteStringValue("resultMessage", ResultMessage);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteObjectValue<PrivilegedRole>("roleInfo", RoleInfo);
            writer.WriteStringValue("userId", UserId);
        }
    }
}

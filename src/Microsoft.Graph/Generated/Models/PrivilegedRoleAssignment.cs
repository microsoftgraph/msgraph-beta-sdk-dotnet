using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedRoleAssignment : Entity, IParsable {
        /// <summary>The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>true if the role assignment is activated. false if the role assignment is deactivated.</summary>
        public bool? IsElevated {
            get { return BackingStore?.Get<bool?>("isElevated"); }
            set { BackingStore?.Set("isElevated", value); }
        }
        /// <summary>Result message set by the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResultMessage {
            get { return BackingStore?.Get<string?>("resultMessage"); }
            set { BackingStore?.Set("resultMessage", value); }
        }
#nullable restore
#else
        public string ResultMessage {
            get { return BackingStore?.Get<string>("resultMessage"); }
            set { BackingStore?.Set("resultMessage", value); }
        }
#endif
        /// <summary>Role identifier. In GUID string format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleId {
            get { return BackingStore?.Get<string?>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#nullable restore
#else
        public string RoleId {
            get { return BackingStore?.Get<string>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#endif
        /// <summary>Read-only. Nullable. The associated role information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrivilegedRole? RoleInfo {
            get { return BackingStore?.Get<PrivilegedRole?>("roleInfo"); }
            set { BackingStore?.Set("roleInfo", value); }
        }
#nullable restore
#else
        public PrivilegedRole RoleInfo {
            get { return BackingStore?.Get<PrivilegedRole>("roleInfo"); }
            set { BackingStore?.Set("roleInfo", value); }
        }
#endif
        /// <summary>User identifier. In GUID string format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"isElevated", n => { IsElevated = n.GetBoolValue(); } },
                {"resultMessage", n => { ResultMessage = n.GetStringValue(); } },
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleInfo", n => { RoleInfo = n.GetObjectValue<PrivilegedRole>(PrivilegedRole.CreateFromDiscriminatorValue); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

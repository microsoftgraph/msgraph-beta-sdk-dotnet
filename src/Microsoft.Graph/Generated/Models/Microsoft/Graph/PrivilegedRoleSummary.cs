using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PrivilegedRoleSummary : Entity, IParsable {
        /// <summary>The number of users that have the role assigned and the role is activated.</summary>
        public int? ElevatedCount { get; set; }
        /// <summary>The number of users that have the role assigned but the role is deactivated.</summary>
        public int? ManagedCount { get; set; }
        /// <summary>true if the role activation requires MFA. false if the role activation doesn't require MFA.</summary>
        public bool? MfaEnabled { get; set; }
        /// <summary>Possible values are: ok, bad. The value depends on the ratio of (managedCount / usersCount). If the ratio is less than a predefined threshold, ok is returned. Otherwise, bad is returned.</summary>
        public RoleSummaryStatus? Status { get; set; }
        /// <summary>The number of users that are assigned with the role.</summary>
        public int? UsersCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrivilegedRoleSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedRoleSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"elevatedCount", (o,n) => { (o as PrivilegedRoleSummary).ElevatedCount = n.GetIntValue(); } },
                {"managedCount", (o,n) => { (o as PrivilegedRoleSummary).ManagedCount = n.GetIntValue(); } },
                {"mfaEnabled", (o,n) => { (o as PrivilegedRoleSummary).MfaEnabled = n.GetBoolValue(); } },
                {"status", (o,n) => { (o as PrivilegedRoleSummary).Status = n.GetEnumValue<RoleSummaryStatus>(); } },
                {"usersCount", (o,n) => { (o as PrivilegedRoleSummary).UsersCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("elevatedCount", ElevatedCount);
            writer.WriteIntValue("managedCount", ManagedCount);
            writer.WriteBoolValue("mfaEnabled", MfaEnabled);
            writer.WriteEnumValue<RoleSummaryStatus>("status", Status);
            writer.WriteIntValue("usersCount", UsersCount);
        }
    }
}

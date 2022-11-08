using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedRoleSummary : Entity, IParsable {
        /// <summary>The number of users that have the role assigned and the role is activated.</summary>
        public int? ElevatedCount {
            get { return BackingStore?.Get<int?>("elevatedCount"); }
            set { BackingStore?.Set("elevatedCount", value); }
        }
        /// <summary>The number of users that have the role assigned but the role is deactivated.</summary>
        public int? ManagedCount {
            get { return BackingStore?.Get<int?>("managedCount"); }
            set { BackingStore?.Set("managedCount", value); }
        }
        /// <summary>true if the role activation requires MFA. false if the role activation doesn&apos;t require MFA.</summary>
        public bool? MfaEnabled {
            get { return BackingStore?.Get<bool?>("mfaEnabled"); }
            set { BackingStore?.Set("mfaEnabled", value); }
        }
        /// <summary>Possible values are: ok, bad. The value depends on the ratio of (managedCount / usersCount). If the ratio is less than a predefined threshold, ok is returned. Otherwise, bad is returned.</summary>
        public RoleSummaryStatus? Status {
            get { return BackingStore?.Get<RoleSummaryStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The number of users that are assigned with the role.</summary>
        public int? UsersCount {
            get { return BackingStore?.Get<int?>("usersCount"); }
            set { BackingStore?.Set("usersCount", value); }
        }
        /// <summary>
        /// Instantiates a new privilegedRoleSummary and sets the default values.
        /// </summary>
        public PrivilegedRoleSummary() : base() {
            OdataType = "#microsoft.graph.privilegedRoleSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedRoleSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedRoleSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"elevatedCount", n => { ElevatedCount = n.GetIntValue(); } },
                {"managedCount", n => { ManagedCount = n.GetIntValue(); } },
                {"mfaEnabled", n => { MfaEnabled = n.GetBoolValue(); } },
                {"status", n => { Status = n.GetEnumValue<RoleSummaryStatus>(); } },
                {"usersCount", n => { UsersCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

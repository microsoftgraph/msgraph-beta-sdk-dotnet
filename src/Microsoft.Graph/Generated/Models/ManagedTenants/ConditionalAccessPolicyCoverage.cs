using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ConditionalAccessPolicyCoverage : Entity, IParsable {
        /// <summary>The state for the conditional access policy. Possible values are: enabled, disabled, enabledForReportingButNotEnforced. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConditionalAccessPolicyState {
            get { return BackingStore?.Get<string?>("conditionalAccessPolicyState"); }
            set { BackingStore?.Set("conditionalAccessPolicyState", value); }
        }
#nullable restore
#else
        public string ConditionalAccessPolicyState {
            get { return BackingStore?.Get<string>("conditionalAccessPolicyState"); }
            set { BackingStore?.Set("conditionalAccessPolicyState", value); }
        }
#endif
        /// <summary>The date and time the conditional access policy was last modified. Required. Read-only.</summary>
        public DateTimeOffset? LatestPolicyModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("latestPolicyModifiedDateTime"); }
            set { BackingStore?.Set("latestPolicyModifiedDateTime", value); }
        }
        /// <summary>A flag indicating whether the conditional access policy requires device compliance. Required. Read-only.</summary>
        public bool? RequiresDeviceCompliance {
            get { return BackingStore?.Get<bool?>("requiresDeviceCompliance"); }
            set { BackingStore?.Set("requiresDeviceCompliance", value); }
        }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName {
            get { return BackingStore?.Get<string?>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#nullable restore
#else
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConditionalAccessPolicyCoverage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessPolicyCoverage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conditionalAccessPolicyState", n => { ConditionalAccessPolicyState = n.GetStringValue(); } },
                {"latestPolicyModifiedDateTime", n => { LatestPolicyModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"requiresDeviceCompliance", n => { RequiresDeviceCompliance = n.GetBoolValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("conditionalAccessPolicyState", ConditionalAccessPolicyState);
            writer.WriteDateTimeOffsetValue("latestPolicyModifiedDateTime", LatestPolicyModifiedDateTime);
            writer.WriteBoolValue("requiresDeviceCompliance", RequiresDeviceCompliance);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
        }
    }
}

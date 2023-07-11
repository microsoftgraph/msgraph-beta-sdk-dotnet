using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CrossTenantAccessPolicyTenantRestrictions : CrossTenantAccessPolicyB2BSetting, IParsable {
        /// <summary>Defines the rule for filtering devices and whether devices satisfying the rule should be allowed or blocked. Not implemented.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DevicesFilter? Devices {
            get { return BackingStore?.Get<DevicesFilter?>("devices"); }
            set { BackingStore?.Set("devices", value); }
        }
#nullable restore
#else
        public DevicesFilter Devices {
            get { return BackingStore?.Get<DevicesFilter>("devices"); }
            set { BackingStore?.Set("devices", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new crossTenantAccessPolicyTenantRestrictions and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyTenantRestrictions() : base() {
            OdataType = "#microsoft.graph.crossTenantAccessPolicyTenantRestrictions";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CrossTenantAccessPolicyTenantRestrictions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyTenantRestrictions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"devices", n => { Devices = n.GetObjectValue<DevicesFilter>(DevicesFilter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DevicesFilter>("devices", Devices);
        }
    }
}

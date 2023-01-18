using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ManagedAppProtectionPolicySetItem : PolicySetItem, IParsable {
        /// <summary>TargetedAppManagementLevels of the ManagedAppPolicySetItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TargetedAppManagementLevels {
            get { return BackingStore?.Get<string?>("targetedAppManagementLevels"); }
            set { BackingStore?.Set("targetedAppManagementLevels", value); }
        }
#else
        public string TargetedAppManagementLevels {
            get { return BackingStore?.Get<string>("targetedAppManagementLevels"); }
            set { BackingStore?.Set("targetedAppManagementLevels", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ManagedAppProtectionPolicySetItem and sets the default values.
        /// </summary>
        public ManagedAppProtectionPolicySetItem() : base() {
            OdataType = "#microsoft.graph.managedAppProtectionPolicySetItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedAppProtectionPolicySetItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppProtectionPolicySetItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"targetedAppManagementLevels", n => { TargetedAppManagementLevels = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("targetedAppManagementLevels", TargetedAppManagementLevels);
        }
    }
}

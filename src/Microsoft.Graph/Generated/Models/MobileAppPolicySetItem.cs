using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MobileAppPolicySetItem : PolicySetItem, IParsable {
        /// <summary>Possible values for the install intent chosen by the admin.</summary>
        public InstallIntent? Intent {
            get { return BackingStore?.Get<InstallIntent?>("intent"); }
            set { BackingStore?.Set("intent", value); }
        }
        /// <summary>Settings of the MobileAppPolicySetItem.</summary>
        public MobileAppAssignmentSettings Settings {
            get { return BackingStore?.Get<MobileAppAssignmentSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
        /// <summary>
        /// Instantiates a new MobileAppPolicySetItem and sets the default values.
        /// </summary>
        public MobileAppPolicySetItem() : base() {
            OdataType = "#microsoft.graph.mobileAppPolicySetItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppPolicySetItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppPolicySetItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"intent", n => { Intent = n.GetEnumValue<InstallIntent>(); } },
                {"settings", n => { Settings = n.GetObjectValue<MobileAppAssignmentSettings>(MobileAppAssignmentSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<InstallIntent>("intent", Intent);
            writer.WriteObjectValue<MobileAppAssignmentSettings>("settings", Settings);
        }
    }
}

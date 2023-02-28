using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TooManyGlobalAdminsAssignedToTenantAlertConfiguration : UnifiedRoleManagementAlertConfiguration, IParsable {
        /// <summary>The globalAdminCountThreshold property</summary>
        public int? GlobalAdminCountThreshold {
            get { return BackingStore?.Get<int?>("globalAdminCountThreshold"); }
            set { BackingStore?.Set("globalAdminCountThreshold", value); }
        }
        /// <summary>The percentageOfGlobalAdminsOutOfRolesThreshold property</summary>
        public int? PercentageOfGlobalAdminsOutOfRolesThreshold {
            get { return BackingStore?.Get<int?>("percentageOfGlobalAdminsOutOfRolesThreshold"); }
            set { BackingStore?.Set("percentageOfGlobalAdminsOutOfRolesThreshold", value); }
        }
        /// <summary>
        /// Instantiates a new TooManyGlobalAdminsAssignedToTenantAlertConfiguration and sets the default values.
        /// </summary>
        public TooManyGlobalAdminsAssignedToTenantAlertConfiguration() : base() {
            OdataType = "#microsoft.graph.tooManyGlobalAdminsAssignedToTenantAlertConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TooManyGlobalAdminsAssignedToTenantAlertConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TooManyGlobalAdminsAssignedToTenantAlertConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"globalAdminCountThreshold", n => { GlobalAdminCountThreshold = n.GetIntValue(); } },
                {"percentageOfGlobalAdminsOutOfRolesThreshold", n => { PercentageOfGlobalAdminsOutOfRolesThreshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("globalAdminCountThreshold", GlobalAdminCountThreshold);
            writer.WriteIntValue("percentageOfGlobalAdminsOutOfRolesThreshold", PercentageOfGlobalAdminsOutOfRolesThreshold);
        }
    }
}

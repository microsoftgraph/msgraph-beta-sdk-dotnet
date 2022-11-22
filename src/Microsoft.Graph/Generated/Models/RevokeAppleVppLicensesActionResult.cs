using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RevokeAppleVppLicensesActionResult : DeviceActionResult, IParsable {
        /// <summary>Total number of Apple Vpp licenses that failed to revoke</summary>
        public int? FailedLicensesCount {
            get { return BackingStore?.Get<int?>("failedLicensesCount"); }
            set { BackingStore?.Set("failedLicensesCount", value); }
        }
        /// <summary>Total number of Apple Vpp licenses associated</summary>
        public int? TotalLicensesCount {
            get { return BackingStore?.Get<int?>("totalLicensesCount"); }
            set { BackingStore?.Set("totalLicensesCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RevokeAppleVppLicensesActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RevokeAppleVppLicensesActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"failedLicensesCount", n => { FailedLicensesCount = n.GetIntValue(); } },
                {"totalLicensesCount", n => { TotalLicensesCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("failedLicensesCount", FailedLicensesCount);
            writer.WriteIntValue("totalLicensesCount", TotalLicensesCount);
        }
    }
}

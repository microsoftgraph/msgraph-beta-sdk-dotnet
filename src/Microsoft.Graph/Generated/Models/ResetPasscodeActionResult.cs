using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ResetPasscodeActionResult : DeviceActionResult, IParsable {
        /// <summary>RotateBitLockerKeys action error code. Valid values 0 to 2147483647</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>Newly generated passcode for the device</summary>
        public string Passcode {
            get { return BackingStore?.Get<string>("passcode"); }
            set { BackingStore?.Set("passcode", value); }
        }
        /// <summary>
        /// Instantiates a new ResetPasscodeActionResult and sets the default values.
        /// </summary>
        public ResetPasscodeActionResult() : base() {
            OdataType = "#microsoft.graph.resetPasscodeActionResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ResetPasscodeActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResetPasscodeActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"passcode", n => { Passcode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteStringValue("passcode", Passcode);
        }
    }
}

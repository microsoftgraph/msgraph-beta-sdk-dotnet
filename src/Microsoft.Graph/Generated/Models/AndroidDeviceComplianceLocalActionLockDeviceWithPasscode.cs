using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceComplianceLocalActionLockDeviceWithPasscode : AndroidDeviceComplianceLocalActionBase, IParsable {
        /// <summary>Passcode to reset to Android device. This property is read-only.</summary>
        public string Passcode {
            get { return BackingStore?.Get<string>("passcode"); }
            set { BackingStore?.Set("passcode", value); }
        }
        /// <summary>Number of sign in failures before wiping device, the value can be 4-11. Valid values 4 to 11</summary>
        public int? PasscodeSignInFailureCountBeforeWipe {
            get { return BackingStore?.Get<int?>("passcodeSignInFailureCountBeforeWipe"); }
            set { BackingStore?.Set("passcodeSignInFailureCountBeforeWipe", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidDeviceComplianceLocalActionLockDeviceWithPasscode and sets the default values.
        /// </summary>
        public AndroidDeviceComplianceLocalActionLockDeviceWithPasscode() : base() {
            OdataType = "#microsoft.graph.androidDeviceComplianceLocalActionLockDeviceWithPasscode";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceComplianceLocalActionLockDeviceWithPasscode CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceComplianceLocalActionLockDeviceWithPasscode();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"passcode", n => { Passcode = n.GetStringValue(); } },
                {"passcodeSignInFailureCountBeforeWipe", n => { PasscodeSignInFailureCountBeforeWipe = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("passcodeSignInFailureCountBeforeWipe", PasscodeSignInFailureCountBeforeWipe);
        }
    }
}

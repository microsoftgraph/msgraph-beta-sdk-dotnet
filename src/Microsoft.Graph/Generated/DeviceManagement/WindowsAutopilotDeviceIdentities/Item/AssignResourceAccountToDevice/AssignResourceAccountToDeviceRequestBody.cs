using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AssignResourceAccountToDevice {
    public class AssignResourceAccountToDeviceRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string AddressableUserName { get; set; }
        public string ResourceAccountName { get; set; }
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new assignResourceAccountToDeviceRequestBody and sets the default values.
        /// </summary>
        public AssignResourceAccountToDeviceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addressableUserName", (o,n) => { (o as AssignResourceAccountToDeviceRequestBody).AddressableUserName = n.GetStringValue(); } },
                {"resourceAccountName", (o,n) => { (o as AssignResourceAccountToDeviceRequestBody).ResourceAccountName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as AssignResourceAccountToDeviceRequestBody).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("resourceAccountName", ResourceAccountName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

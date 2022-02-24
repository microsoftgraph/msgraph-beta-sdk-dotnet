using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceAppManagement.VppTokens.Item.RevokeLicenses {
    public class RevokeLicensesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? NotifyManagedDevices { get; set; }
        public bool? RevokeUntrackedLicenses { get; set; }
        /// <summary>
        /// Instantiates a new revokeLicensesRequestBody and sets the default values.
        /// </summary>
        public RevokeLicensesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"notifyManagedDevices", (o,n) => { (o as RevokeLicensesRequestBody).NotifyManagedDevices = n.GetBoolValue(); } },
                {"revokeUntrackedLicenses", (o,n) => { (o as RevokeLicensesRequestBody).RevokeUntrackedLicenses = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("notifyManagedDevices", NotifyManagedDevices);
            writer.WriteBoolValue("revokeUntrackedLicenses", RevokeUntrackedLicenses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

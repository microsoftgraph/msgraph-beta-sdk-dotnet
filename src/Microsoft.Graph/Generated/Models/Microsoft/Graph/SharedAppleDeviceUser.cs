using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SharedAppleDeviceUser : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Data quota</summary>
        public long? DataQuota { get; set; }
        /// <summary>Data to sync</summary>
        public bool? DataToSync { get; set; }
        /// <summary>Data quota</summary>
        public long? DataUsed { get; set; }
        /// <summary>User name</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new sharedAppleDeviceUser and sets the default values.
        /// </summary>
        public SharedAppleDeviceUser() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dataQuota", (o,n) => { (o as SharedAppleDeviceUser).DataQuota = n.GetLongValue(); } },
                {"dataToSync", (o,n) => { (o as SharedAppleDeviceUser).DataToSync = n.GetBoolValue(); } },
                {"dataUsed", (o,n) => { (o as SharedAppleDeviceUser).DataUsed = n.GetLongValue(); } },
                {"userPrincipalName", (o,n) => { (o as SharedAppleDeviceUser).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("dataQuota", DataQuota);
            writer.WriteBoolValue("dataToSync", DataToSync);
            writer.WriteLongValue("dataUsed", DataUsed);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

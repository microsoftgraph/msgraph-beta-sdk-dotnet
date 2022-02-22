using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.VirtualEndpoint.CloudPCs.Item.ChangeUserAccountType {
    public class ChangeUserAccountTypeRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public CloudPcUserAccountType? UserAccountType { get; set; }
        /// <summary>
        /// Instantiates a new changeUserAccountTypeRequestBody and sets the default values.
        /// </summary>
        public ChangeUserAccountTypeRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"userAccountType", (o,n) => { (o as ChangeUserAccountTypeRequestBody).UserAccountType = n.GetEnumValue<CloudPcUserAccountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CloudPcUserAccountType>("userAccountType", UserAccountType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

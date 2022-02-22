using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.PrivilegedSignupStatus.CompleteSetup {
    public class CompleteSetupRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public TenantSetupInfo TenantSetupInfo { get; set; }
        /// <summary>
        /// Instantiates a new completeSetupRequestBody and sets the default values.
        /// </summary>
        public CompleteSetupRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"tenantSetupInfo", (o,n) => { (o as CompleteSetupRequestBody).TenantSetupInfo = n.GetObjectValue<TenantSetupInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TenantSetupInfo>("tenantSetupInfo", TenantSetupInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

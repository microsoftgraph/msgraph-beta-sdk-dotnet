using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.PrivilegedSignupStatus.CompleteSetup {
    /// <summary>Provides operations to call the completeSetup method.</summary>
    public class CompleteSetupRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.TenantSetupInfo TenantSetupInfo { get; set; }
        /// <summary>
        /// Instantiates a new completeSetupRequestBody and sets the default values.
        /// </summary>
        public CompleteSetupRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CompleteSetupRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CompleteSetupRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"tenantSetupInfo", (o,n) => { (o as CompleteSetupRequestBody).TenantSetupInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.TenantSetupInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.TenantSetupInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.TenantSetupInfo>("tenantSetupInfo", TenantSetupInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

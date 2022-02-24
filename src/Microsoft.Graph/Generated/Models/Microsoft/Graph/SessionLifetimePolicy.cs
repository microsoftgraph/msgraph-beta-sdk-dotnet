using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SessionLifetimePolicy : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The human-readable details of the conditional access session management policy applied to the sign-in.</summary>
        public string Detail { get; set; }
        /// <summary>If a conditional access session management policy required the user to authenticate in this sign-in event, this field describes the policy type that required authentication. The possible values are: rememberMultifactorAuthenticationOnTrustedDevices, tenantTokenLifetimePolicy, audienceTokenLifetimePolicy, signInFrequencyPeriodicReauthentication, ngcMfa, signInFrequencyEveryTime, unknownFutureValue.</summary>
        public ExpirationRequirement? ExpirationRequirement { get; set; }
        /// <summary>
        /// Instantiates a new sessionLifetimePolicy and sets the default values.
        /// </summary>
        public SessionLifetimePolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"detail", (o,n) => { (o as SessionLifetimePolicy).Detail = n.GetStringValue(); } },
                {"expirationRequirement", (o,n) => { (o as SessionLifetimePolicy).ExpirationRequirement = n.GetEnumValue<ExpirationRequirement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detail", Detail);
            writer.WriteEnumValue<ExpirationRequirement>("expirationRequirement", ExpirationRequirement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

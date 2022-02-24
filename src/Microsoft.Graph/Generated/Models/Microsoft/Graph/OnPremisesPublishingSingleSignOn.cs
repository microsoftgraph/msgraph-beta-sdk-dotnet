using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OnPremisesPublishingSingleSignOn : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Kerberos Constrained Delegation settings for applications that use Integrated Window Authentication.</summary>
        public KerberosSignOnSettings KerberosSignOnSettings { get; set; }
        /// <summary>The preferred single-sign on mode for the application. Possible values are: none, onPremisesKerberos, aadHeaderBased,pingHeaderBased.</summary>
        public SingleSignOnMode? SingleSignOnMode { get; set; }
        /// <summary>
        /// Instantiates a new onPremisesPublishingSingleSignOn and sets the default values.
        /// </summary>
        public OnPremisesPublishingSingleSignOn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"kerberosSignOnSettings", (o,n) => { (o as OnPremisesPublishingSingleSignOn).KerberosSignOnSettings = n.GetObjectValue<KerberosSignOnSettings>(); } },
                {"singleSignOnMode", (o,n) => { (o as OnPremisesPublishingSingleSignOn).SingleSignOnMode = n.GetEnumValue<SingleSignOnMode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<KerberosSignOnSettings>("kerberosSignOnSettings", KerberosSignOnSettings);
            writer.WriteEnumValue<SingleSignOnMode>("singleSignOnMode", SingleSignOnMode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

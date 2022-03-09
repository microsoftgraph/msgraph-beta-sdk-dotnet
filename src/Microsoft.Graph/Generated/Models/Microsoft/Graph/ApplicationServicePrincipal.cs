using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the instantiate method.</summary>
    public class ApplicationServicePrincipal : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Application Application { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ServicePrincipal ServicePrincipal { get; set; }
        /// <summary>
        /// Instantiates a new applicationServicePrincipal and sets the default values.
        /// </summary>
        public ApplicationServicePrincipal() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApplicationServicePrincipal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationServicePrincipal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"application", (o,n) => { (o as ApplicationServicePrincipal).Application = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Application>(MicrosoftGraphSdk.Models.Microsoft.Graph.Application.CreateFromDiscriminatorValue); } },
                {"servicePrincipal", (o,n) => { (o as ApplicationServicePrincipal).ServicePrincipal = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ServicePrincipal>(MicrosoftGraphSdk.Models.Microsoft.Graph.ServicePrincipal.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Application>("application", Application);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

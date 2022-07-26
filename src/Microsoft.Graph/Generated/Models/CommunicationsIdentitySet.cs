using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CommunicationsIdentitySet : IdentitySet, IParsable {
        /// <summary>An identity the participant would like to present itself as to the other participants in the call.</summary>
        public Identity AssertedIdentity {
            get { return BackingStore?.Get<Identity>("assertedIdentity"); }
            set { BackingStore?.Set("assertedIdentity", value); }
        }
        /// <summary>The Azure Communication Services user associated with this action.</summary>
        public Identity AzureCommunicationServicesUser {
            get { return BackingStore?.Get<Identity>("azureCommunicationServicesUser"); }
            set { BackingStore?.Set("azureCommunicationServicesUser", value); }
        }
        /// <summary>Type of endpoint the participant is using. Possible values are: default, voicemail, skypeForBusiness, skypeForBusinessVoipPhone and unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.EndpointType? EndpointType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EndpointType?>("endpointType"); }
            set { BackingStore?.Set("endpointType", value); }
        }
        /// <summary>
        /// Instantiates a new CommunicationsIdentitySet and sets the default values.
        /// </summary>
        public CommunicationsIdentitySet() : base() {
            OdataType = "#microsoft.graph.communicationsIdentitySet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CommunicationsIdentitySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommunicationsIdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assertedIdentity", n => { AssertedIdentity = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"azureCommunicationServicesUser", n => { AzureCommunicationServicesUser = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"endpointType", n => { EndpointType = n.GetEnumValue<EndpointType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Identity>("assertedIdentity", AssertedIdentity);
            writer.WriteObjectValue<Identity>("azureCommunicationServicesUser", AzureCommunicationServicesUser);
            writer.WriteEnumValue<EndpointType>("endpointType", EndpointType);
        }
    }
}

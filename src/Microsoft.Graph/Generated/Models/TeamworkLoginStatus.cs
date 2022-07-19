using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkLoginStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Information about the Exchange connection.</summary>
        public TeamworkConnection ExchangeConnection {
            get { return BackingStore?.Get<TeamworkConnection>("exchangeConnection"); }
            set { BackingStore?.Set("exchangeConnection", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Information about the Skype for Business connection.</summary>
        public TeamworkConnection SkypeConnection {
            get { return BackingStore?.Get<TeamworkConnection>("skypeConnection"); }
            set { BackingStore?.Set("skypeConnection", value); }
        }
        /// <summary>Information about the Teams connection.</summary>
        public TeamworkConnection TeamsConnection {
            get { return BackingStore?.Get<TeamworkConnection>("teamsConnection"); }
            set { BackingStore?.Set("teamsConnection", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkLoginStatus and sets the default values.
        /// </summary>
        public TeamworkLoginStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teamworkLoginStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkLoginStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkLoginStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"exchangeConnection", n => { ExchangeConnection = n.GetObjectValue<TeamworkConnection>(TeamworkConnection.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"skypeConnection", n => { SkypeConnection = n.GetObjectValue<TeamworkConnection>(TeamworkConnection.CreateFromDiscriminatorValue); } },
                {"teamsConnection", n => { TeamsConnection = n.GetObjectValue<TeamworkConnection>(TeamworkConnection.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkConnection>("exchangeConnection", ExchangeConnection);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TeamworkConnection>("skypeConnection", SkypeConnection);
            writer.WriteObjectValue<TeamworkConnection>("teamsConnection", TeamsConnection);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

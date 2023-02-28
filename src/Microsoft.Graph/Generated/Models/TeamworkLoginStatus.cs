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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkConnection? ExchangeConnection {
            get { return BackingStore?.Get<TeamworkConnection?>("exchangeConnection"); }
            set { BackingStore?.Set("exchangeConnection", value); }
        }
#nullable restore
#else
        public TeamworkConnection ExchangeConnection {
            get { return BackingStore?.Get<TeamworkConnection>("exchangeConnection"); }
            set { BackingStore?.Set("exchangeConnection", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Information about the Skype for Business connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkConnection? SkypeConnection {
            get { return BackingStore?.Get<TeamworkConnection?>("skypeConnection"); }
            set { BackingStore?.Set("skypeConnection", value); }
        }
#nullable restore
#else
        public TeamworkConnection SkypeConnection {
            get { return BackingStore?.Get<TeamworkConnection>("skypeConnection"); }
            set { BackingStore?.Set("skypeConnection", value); }
        }
#endif
        /// <summary>Information about the Teams connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkConnection? TeamsConnection {
            get { return BackingStore?.Get<TeamworkConnection?>("teamsConnection"); }
            set { BackingStore?.Set("teamsConnection", value); }
        }
#nullable restore
#else
        public TeamworkConnection TeamsConnection {
            get { return BackingStore?.Get<TeamworkConnection>("teamsConnection"); }
            set { BackingStore?.Set("teamsConnection", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new teamworkLoginStatus and sets the default values.
        /// </summary>
        public TeamworkLoginStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

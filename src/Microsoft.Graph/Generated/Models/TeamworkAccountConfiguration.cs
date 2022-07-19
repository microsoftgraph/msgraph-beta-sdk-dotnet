using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkAccountConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The account used to sync the calendar.</summary>
        public TeamworkOnPremisesCalendarSyncConfiguration OnPremisesCalendarSyncConfiguration {
            get { return BackingStore?.Get<TeamworkOnPremisesCalendarSyncConfiguration>("onPremisesCalendarSyncConfiguration"); }
            set { BackingStore?.Set("onPremisesCalendarSyncConfiguration", value); }
        }
        /// <summary>The supported client for Teams Rooms devices. The possible values are: unknown, skypeDefaultAndTeams, teamsDefaultAndSkype, skypeOnly, teamsOnly, unknownFutureValue.</summary>
        public TeamworkSupportedClient? SupportedClient {
            get { return BackingStore?.Get<TeamworkSupportedClient?>("supportedClient"); }
            set { BackingStore?.Set("supportedClient", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkAccountConfiguration and sets the default values.
        /// </summary>
        public TeamworkAccountConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teamworkAccountConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkAccountConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkAccountConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onPremisesCalendarSyncConfiguration", n => { OnPremisesCalendarSyncConfiguration = n.GetObjectValue<TeamworkOnPremisesCalendarSyncConfiguration>(TeamworkOnPremisesCalendarSyncConfiguration.CreateFromDiscriminatorValue); } },
                {"supportedClient", n => { SupportedClient = n.GetEnumValue<TeamworkSupportedClient>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TeamworkOnPremisesCalendarSyncConfiguration>("onPremisesCalendarSyncConfiguration", OnPremisesCalendarSyncConfiguration);
            writer.WriteEnumValue<TeamworkSupportedClient>("supportedClient", SupportedClient);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Graph.Beta.Models.ExternalConnectors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.External.Connections.Item.Items.Item.AddActivities {
    /// <summary>Provides operations to call the addActivities method.</summary>
    public class AddActivitiesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The activities property</summary>
        public List<ExternalActivity> Activities {
            get { return BackingStore?.Get<List<ExternalActivity>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>
        /// Instantiates a new addActivitiesPostRequestBody and sets the default values.
        /// </summary>
        public AddActivitiesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AddActivitiesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddActivitiesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<ExternalActivity>(ExternalActivity.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ExternalActivity>("activities", Activities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

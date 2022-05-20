using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics insight is the recomendation to improve the user experience analytics score.</summary>
    public class UserExperienceAnalyticsSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>True if Tenant attach is configured. If configured then SCCM tenant attached devices will show up in UXA reporting.</summary>
        public bool? ConfigurationManagerDataConnectorConfigured {
            get { return BackingStore?.Get<bool?>(nameof(ConfigurationManagerDataConnectorConfigured)); }
            set { BackingStore?.Set(nameof(ConfigurationManagerDataConnectorConfigured), value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsSettings and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserExperienceAnalyticsSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"configurationManagerDataConnectorConfigured", n => { ConfigurationManagerDataConnectorConfigured = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("configurationManagerDataConnectorConfigured", ConfigurationManagerDataConnectorConfigured);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

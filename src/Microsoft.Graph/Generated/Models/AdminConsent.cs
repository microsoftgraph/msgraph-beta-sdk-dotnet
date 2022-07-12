using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Admin consent information.</summary>
    public class AdminConsent : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Admin consent state.</summary>
        public AdminConsentState? ShareAPNSData {
            get { return BackingStore?.Get<AdminConsentState?>("shareAPNSData"); }
            set { BackingStore?.Set("shareAPNSData", value); }
        }
        /// <summary>Admin consent state.</summary>
        public AdminConsentState? ShareUserExperienceAnalyticsData {
            get { return BackingStore?.Get<AdminConsentState?>("shareUserExperienceAnalyticsData"); }
            set { BackingStore?.Set("shareUserExperienceAnalyticsData", value); }
        }
        /// <summary>
        /// Instantiates a new adminConsent and sets the default values.
        /// </summary>
        public AdminConsent() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AdminConsent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AdminConsent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"shareAPNSData", n => { ShareAPNSData = n.GetEnumValue<AdminConsentState>(); } },
                {"shareUserExperienceAnalyticsData", n => { ShareUserExperienceAnalyticsData = n.GetEnumValue<AdminConsentState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AdminConsentState>("shareAPNSData", ShareAPNSData);
            writer.WriteEnumValue<AdminConsentState>("shareUserExperienceAnalyticsData", ShareUserExperienceAnalyticsData);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

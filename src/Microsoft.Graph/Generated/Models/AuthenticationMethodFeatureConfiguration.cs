using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationMethodFeatureConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A single entity that&apos;s excluded from using this feature.</summary>
        public FeatureTarget ExcludeTarget {
            get { return BackingStore?.Get<FeatureTarget>("excludeTarget"); }
            set { BackingStore?.Set("excludeTarget", value); }
        }
        /// <summary>A single entity that&apos;s allowed to use this feature.</summary>
        public FeatureTarget IncludeTarget {
            get { return BackingStore?.Get<FeatureTarget>("includeTarget"); }
            set { BackingStore?.Set("includeTarget", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Enable or disable the feature. Possible values are: default, enabled, disabled, unknownFutureValue. The default value is used when the configuration hasn&apos;t been explicitly set and uses the default behavior of Azure AD for the setting. The default value is disabled.</summary>
        public AdvancedConfigState? State {
            get { return BackingStore?.Get<AdvancedConfigState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new authenticationMethodFeatureConfiguration and sets the default values.
        /// </summary>
        public AuthenticationMethodFeatureConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationMethodFeatureConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationMethodFeatureConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeTarget", n => { ExcludeTarget = n.GetObjectValue<FeatureTarget>(FeatureTarget.CreateFromDiscriminatorValue); } },
                {"includeTarget", n => { IncludeTarget = n.GetObjectValue<FeatureTarget>(FeatureTarget.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<AdvancedConfigState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<FeatureTarget>("excludeTarget", ExcludeTarget);
            writer.WriteObjectValue<FeatureTarget>("includeTarget", IncludeTarget);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<AdvancedConfigState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

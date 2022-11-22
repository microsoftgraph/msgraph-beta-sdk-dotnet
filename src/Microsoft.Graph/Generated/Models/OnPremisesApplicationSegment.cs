using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesApplicationSegment : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>If you&apos;re configuring a traffic manager in front of multiple App Proxy application segments, contains the user-friendly URL that will point to the traffic manager.</summary>
        public string AlternateUrl {
            get { return BackingStore?.Get<string>("alternateUrl"); }
            set { BackingStore?.Set("alternateUrl", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>CORS Rule definition for a particular application segment.</summary>
        public List<CorsConfiguration> CorsConfigurations {
            get { return BackingStore?.Get<List<CorsConfiguration>>("corsConfigurations"); }
            set { BackingStore?.Set("corsConfigurations", value); }
        }
        /// <summary>The published external URL for the application segment; for example, https://intranet.contoso.com./</summary>
        public string ExternalUrl {
            get { return BackingStore?.Get<string>("externalUrl"); }
            set { BackingStore?.Set("externalUrl", value); }
        }
        /// <summary>The internal URL of the application segment; for example, https://intranet/.</summary>
        public string InternalUrl {
            get { return BackingStore?.Get<string>("internalUrl"); }
            set { BackingStore?.Set("internalUrl", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new onPremisesApplicationSegment and sets the default values.
        /// </summary>
        public OnPremisesApplicationSegment() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesApplicationSegment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesApplicationSegment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alternateUrl", n => { AlternateUrl = n.GetStringValue(); } },
                {"corsConfigurations", n => { CorsConfigurations = n.GetCollectionOfObjectValues<CorsConfiguration>(CorsConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalUrl", n => { ExternalUrl = n.GetStringValue(); } },
                {"internalUrl", n => { InternalUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alternateUrl", AlternateUrl);
            writer.WriteCollectionOfObjectValues<CorsConfiguration>("corsConfigurations", CorsConfigurations);
            writer.WriteStringValue("externalUrl", ExternalUrl);
            writer.WriteStringValue("internalUrl", InternalUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

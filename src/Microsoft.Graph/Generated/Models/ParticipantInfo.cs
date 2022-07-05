using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ParticipantInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The ISO 3166-1 Alpha-2 country code of the participant&apos;s best estimated physical location at the start of the call. Read-only.</summary>
        public string CountryCode {
            get { return BackingStore?.Get<string>(nameof(CountryCode)); }
            set { BackingStore?.Set(nameof(CountryCode), value); }
        }
        /// <summary>The type of endpoint the participant is using. Possible values are: default, skypeForBusiness, or skypeForBusinessVoipPhone. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.EndpointType? EndpointType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EndpointType?>(nameof(EndpointType)); }
            set { BackingStore?.Set(nameof(EndpointType), value); }
        }
        /// <summary>The identity property</summary>
        public IdentitySet Identity {
            get { return BackingStore?.Get<IdentitySet>(nameof(Identity)); }
            set { BackingStore?.Set(nameof(Identity), value); }
        }
        /// <summary>The language culture string. Read-only.</summary>
        public string LanguageId {
            get { return BackingStore?.Get<string>(nameof(LanguageId)); }
            set { BackingStore?.Set(nameof(LanguageId), value); }
        }
        /// <summary>The nonAnonymizedIdentity property</summary>
        public IdentitySet NonAnonymizedIdentity {
            get { return BackingStore?.Get<IdentitySet>(nameof(NonAnonymizedIdentity)); }
            set { BackingStore?.Set(nameof(NonAnonymizedIdentity), value); }
        }
        /// <summary>The participant ID of the participant. Read-only.</summary>
        public string ParticipantId {
            get { return BackingStore?.Get<string>(nameof(ParticipantId)); }
            set { BackingStore?.Set(nameof(ParticipantId), value); }
        }
        /// <summary>The client platform ID of the participant. Read-only.</summary>
        public string PlatformId {
            get { return BackingStore?.Get<string>(nameof(PlatformId)); }
            set { BackingStore?.Set(nameof(PlatformId), value); }
        }
        /// <summary>The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant&apos;s current physical location, unlike countryCode. Read-only.</summary>
        public string Region {
            get { return BackingStore?.Get<string>(nameof(Region)); }
            set { BackingStore?.Set(nameof(Region), value); }
        }
        /// <summary>
        /// Instantiates a new participantInfo and sets the default values.
        /// </summary>
        public ParticipantInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ParticipantInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParticipantInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"countryCode", n => { CountryCode = n.GetStringValue(); } },
                {"endpointType", n => { EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"identity", n => { Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"languageId", n => { LanguageId = n.GetStringValue(); } },
                {"nonAnonymizedIdentity", n => { NonAnonymizedIdentity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"participantId", n => { ParticipantId = n.GetStringValue(); } },
                {"platformId", n => { PlatformId = n.GetStringValue(); } },
                {"region", n => { Region = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteEnumValue<EndpointType>("endpointType", EndpointType);
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteStringValue("languageId", LanguageId);
            writer.WriteObjectValue<IdentitySet>("nonAnonymizedIdentity", NonAnonymizedIdentity);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteStringValue("platformId", PlatformId);
            writer.WriteStringValue("region", Region);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

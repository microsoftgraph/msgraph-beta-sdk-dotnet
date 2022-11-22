using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ConditionalAccessGuestsOrExternalUsers : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The tenant ids of the selected types of external users. It could be either all b2b tenant, or a collection of tenant ids. External tenants can be specified only when guestOrExternalUserTypes is not null or an empty string.</summary>
        public ConditionalAccessExternalTenants ExternalTenants {
            get { return BackingStore?.Get<ConditionalAccessExternalTenants>("externalTenants"); }
            set { BackingStore?.Set("externalTenants", value); }
        }
        /// <summary>The guestOrExternalUserTypes property</summary>
        public ConditionalAccessGuestOrExternalUserTypes? GuestOrExternalUserTypes {
            get { return BackingStore?.Get<ConditionalAccessGuestOrExternalUserTypes?>("guestOrExternalUserTypes"); }
            set { BackingStore?.Set("guestOrExternalUserTypes", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new conditionalAccessGuestsOrExternalUsers and sets the default values.
        /// </summary>
        public ConditionalAccessGuestsOrExternalUsers() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessGuestsOrExternalUsers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessGuestsOrExternalUsers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"externalTenants", n => { ExternalTenants = n.GetObjectValue<ConditionalAccessExternalTenants>(ConditionalAccessExternalTenants.CreateFromDiscriminatorValue); } },
                {"guestOrExternalUserTypes", n => { GuestOrExternalUserTypes = n.GetEnumValue<ConditionalAccessGuestOrExternalUserTypes>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConditionalAccessExternalTenants>("externalTenants", ExternalTenants);
            writer.WriteEnumValue<ConditionalAccessGuestOrExternalUserTypes>("guestOrExternalUserTypes", GuestOrExternalUserTypes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

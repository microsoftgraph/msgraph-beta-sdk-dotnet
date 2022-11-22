using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkOnPremisesCalendarSyncConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The fully qualified domain name (FQDN) of the Skype for Business Server. Use the Exchange domain if the Skype for Business SIP domain is different from the Exchange domain of the user.</summary>
        public string Domain {
            get { return BackingStore?.Get<string>("domain"); }
            set { BackingStore?.Set("domain", value); }
        }
        /// <summary>The domain and username of the console device, for example, Seattle/RanierConf.</summary>
        public string DomainUserName {
            get { return BackingStore?.Get<string>("domainUserName"); }
            set { BackingStore?.Set("domainUserName", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The Simple Mail Transfer Protocol (SMTP) address of the user account. This is only required if a different user principal name (UPN) is used to sign in to Exchange other than Microsoft Teams and Skype for Business. This is a common scenario in a hybrid environment where an on-premises Exchange server is used.</summary>
        public string SmtpAddress {
            get { return BackingStore?.Get<string>("smtpAddress"); }
            set { BackingStore?.Set("smtpAddress", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkOnPremisesCalendarSyncConfiguration and sets the default values.
        /// </summary>
        public TeamworkOnPremisesCalendarSyncConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkOnPremisesCalendarSyncConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkOnPremisesCalendarSyncConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"domain", n => { Domain = n.GetStringValue(); } },
                {"domainUserName", n => { DomainUserName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"smtpAddress", n => { SmtpAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("domain", Domain);
            writer.WriteStringValue("domainUserName", DomainUserName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("smtpAddress", SmtpAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

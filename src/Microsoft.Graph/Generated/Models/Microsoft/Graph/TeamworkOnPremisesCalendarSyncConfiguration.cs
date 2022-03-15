using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class TeamworkOnPremisesCalendarSyncConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fully qualified domain name (FQDN) of the Skype for Business Server. Use the Exchange domain if the Skype for Business SIP domain is different from the Exchange domain of the user.</summary>
        public string Domain { get; set; }
        /// <summary>The domain and username of the console device, for example, Seattle/RanierConf.</summary>
        public string DomainUserName { get; set; }
        /// <summary>The Simple Mail Transfer Protocol (SMTP) address of the user account. This is only required if a different user principal name (UPN) is used to sign in to Exchange other than Microsoft Teams and Skype for Business. This is a common scenario in a hybrid environment where an on-premises Exchange server is used.</summary>
        public string SmtpAddress { get; set; }
        /// <summary>
        /// Instantiates a new teamworkOnPremisesCalendarSyncConfiguration and sets the default values.
        /// </summary>
        public TeamworkOnPremisesCalendarSyncConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkOnPremisesCalendarSyncConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkOnPremisesCalendarSyncConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"domain", (o,n) => { (o as TeamworkOnPremisesCalendarSyncConfiguration).Domain = n.GetStringValue(); } },
                {"domainUserName", (o,n) => { (o as TeamworkOnPremisesCalendarSyncConfiguration).DomainUserName = n.GetStringValue(); } },
                {"smtpAddress", (o,n) => { (o as TeamworkOnPremisesCalendarSyncConfiguration).SmtpAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("domain", Domain);
            writer.WriteStringValue("domainUserName", DomainUserName);
            writer.WriteStringValue("smtpAddress", SmtpAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

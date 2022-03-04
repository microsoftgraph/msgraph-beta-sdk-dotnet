using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AdminConsent : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The admin consent state of sharing user and device data to Apple. Possible values are: notConfigured, granted, notGranted.</summary>
        public AdminConsentState? ShareAPNSData { get; set; }
        /// <summary>Gets or sets the admin consent for sharing User experience analytics data. Possible values are: notConfigured, granted, notGranted.</summary>
        public AdminConsentState? ShareUserExperienceAnalyticsData { get; set; }
        /// <summary>
        /// Instantiates a new adminConsent and sets the default values.
        /// </summary>
        public AdminConsent() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"shareAPNSData", (o,n) => { (o as AdminConsent).ShareAPNSData = n.GetEnumValue<AdminConsentState>(); } },
                {"shareUserExperienceAnalyticsData", (o,n) => { (o as AdminConsent).ShareUserExperienceAnalyticsData = n.GetEnumValue<AdminConsentState>(); } },
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

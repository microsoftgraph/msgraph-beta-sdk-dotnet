using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class KeyCredentialConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public TimeSpan? MaxLifetime { get; set; }
        /// <summary>Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.</summary>
        public DateTimeOffset? RestrictForAppsCreatedAfterDateTime { get; set; }
        /// <summary>The type of restriction being applied. Possible values are asymmetricKeyLifetime, unknownFutureValue. Each value of restrictionType can be used only once per policy.</summary>
        public AppKeyCredentialRestrictionType? RestrictionType { get; set; }
        /// <summary>
        /// Instantiates a new keyCredentialConfiguration and sets the default values.
        /// </summary>
        public KeyCredentialConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static KeyCredentialConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KeyCredentialConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"maxLifetime", (o,n) => { (o as KeyCredentialConfiguration).MaxLifetime = n.GetTimeSpanValue(); } },
                {"restrictForAppsCreatedAfterDateTime", (o,n) => { (o as KeyCredentialConfiguration).RestrictForAppsCreatedAfterDateTime = n.GetDateTimeOffsetValue(); } },
                {"restrictionType", (o,n) => { (o as KeyCredentialConfiguration).RestrictionType = n.GetEnumValue<AppKeyCredentialRestrictionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("maxLifetime", MaxLifetime);
            writer.WriteDateTimeOffsetValue("restrictForAppsCreatedAfterDateTime", RestrictForAppsCreatedAfterDateTime);
            writer.WriteEnumValue<AppKeyCredentialRestrictionType>("restrictionType", RestrictionType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class PasswordCredentialConfiguration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public TimeSpan? MaxLifetime { get; set; }
        /// <summary>Enforces the policy for an app created on or after the enforcement date. For existing applications, the enforcement date would be back dated. To apply to all applications, enforcement datetime would be null.</summary>
        public DateTimeOffset? RestrictForAppsCreatedAfterDateTime { get; set; }
        /// <summary>The type of restriction being applied. The possible values are: passwordAddition, passwordLifetime, symmetricKeyAddition, symmetricKeyLifetime, unknownFutureValue. Each value of restrictionType can be used only once per policy.</summary>
        public AppCredentialRestrictionType? RestrictionType { get; set; }
        /// <summary>
        /// Instantiates a new passwordCredentialConfiguration and sets the default values.
        /// </summary>
        public PasswordCredentialConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"maxLifetime", (o,n) => { (o as PasswordCredentialConfiguration).MaxLifetime = n.GetTimeSpanValue(); } },
                {"restrictForAppsCreatedAfterDateTime", (o,n) => { (o as PasswordCredentialConfiguration).RestrictForAppsCreatedAfterDateTime = n.GetDateTimeOffsetValue(); } },
                {"restrictionType", (o,n) => { (o as PasswordCredentialConfiguration).RestrictionType = n.GetEnumValue<AppCredentialRestrictionType>(); } },
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
            writer.WriteEnumValue<AppCredentialRestrictionType>("restrictionType", RestrictionType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

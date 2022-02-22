using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SynchronizationSecretKeyStringValuePair : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Possible values are: None, UserName, Password, SecretToken, AppKey, BaseAddress, ClientIdentifier, ClientSecret, SingleSignOnType, Sandbox, Url, Domain, ConsumerKey, ConsumerSecret, TokenKey, TokenExpiration, Oauth2AccessToken, Oauth2AccessTokenCreationTime, Oauth2RefreshToken, SyncAll, InstanceName, Oauth2ClientId, Oauth2ClientSecret, CompanyId, UpdateKeyOnSoftDelete, SynchronizationSchedule, SystemOfRecord, SandboxName, EnforceDomain, SyncNotificationSettings, Server, PerformInboundEntitlementGrants, HardDeletesEnabled, SyncAgentCompatibilityKey, SyncAgentADContainer, ValidateDomain, Oauth2TokenExchangeUri, Oauth2AuthorizationUri, AuthenticationType, TestReferences, ConnectionString.</summary>
        public SynchronizationSecret? Key { get; set; }
        /// <summary>The value of the secret.</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationSecretKeyStringValuePair and sets the default values.
        /// </summary>
        public SynchronizationSecretKeyStringValuePair() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"key", (o,n) => { (o as SynchronizationSecretKeyStringValuePair).Key = n.GetEnumValue<SynchronizationSecret>(); } },
                {"value", (o,n) => { (o as SynchronizationSecretKeyStringValuePair).Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SynchronizationSecret>("key", Key);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

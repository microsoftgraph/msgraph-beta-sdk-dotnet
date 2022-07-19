using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ConditionalAccessRuleSatisfied : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Refers to the conditional access policy conditions that are satisfied. The possible values are: none, application, users, devicePlatform, location, clientType, signInRisk, userRisk, time, deviceState, client, ipAddressSeenByAzureAD, ipAddressSeenByResourceProvider, unknownFutureValue, servicePrincipals, servicePrincipalRisk. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: servicePrincipals, servicePrincipalRisk.</summary>
        public ConditionalAccessConditions? ConditionalAccessCondition {
            get { return BackingStore?.Get<ConditionalAccessConditions?>("conditionalAccessCondition"); }
            set { BackingStore?.Set("conditionalAccessCondition", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Refers to the conditional access policy conditions that were satisfied. The possible values are: allApps, firstPartyApps, office365, appId, acr, appFilter, allUsers, guest, groupId, roleId, userId, allDevicePlatforms, devicePlatform, allLocations, insideCorpnet, allTrustedLocations, locationId, allDevices, deviceFilter, deviceState, unknownFutureValue, deviceFilterIncludeRuleNotMatched, allDeviceStates, anonymizedIPAddress, unfamiliarFeatures, nationStateIPAddress, realTimeThreatIntelligence, internalGuest, b2bCollaborationGuest, b2bCollaborationMember, b2bDirectConnectUser, otherExternalUser, serviceProvider. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: deviceFilterIncludeRuleNotMatched, allDeviceStates.</summary>
        public ConditionalAccessRule? RuleSatisfied {
            get { return BackingStore?.Get<ConditionalAccessRule?>("ruleSatisfied"); }
            set { BackingStore?.Set("ruleSatisfied", value); }
        }
        /// <summary>
        /// Instantiates a new conditionalAccessRuleSatisfied and sets the default values.
        /// </summary>
        public ConditionalAccessRuleSatisfied() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.conditionalAccessRuleSatisfied";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConditionalAccessRuleSatisfied CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessRuleSatisfied();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"conditionalAccessCondition", n => { ConditionalAccessCondition = n.GetEnumValue<ConditionalAccessConditions>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"ruleSatisfied", n => { RuleSatisfied = n.GetEnumValue<ConditionalAccessRule>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ConditionalAccessConditions>("conditionalAccessCondition", ConditionalAccessCondition);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ConditionalAccessRule>("ruleSatisfied", RuleSatisfied);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

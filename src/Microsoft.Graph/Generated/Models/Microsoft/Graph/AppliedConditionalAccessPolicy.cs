using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class AppliedConditionalAccessPolicy : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The custom authentication strength enforced in a Conditional Access policy.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AuthenticationStrength AuthenticationStrength { get; set; }
        /// <summary>Refers to the conditional access policy conditions that are not satisfied. The possible values are: none, application, users, devicePlatform, location, clientType, signInRisk, userRisk, time, deviceState, client,ipAddressSeenByAzureAD,ipAddressSeenByResourceProvider,unknownFutureValue,servicePrincipals,servicePrincipalRisk. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: servicePrincipals,servicePrincipalRisk.</summary>
        public ConditionalAccessConditions? ConditionsNotSatisfied { get; set; }
        /// <summary>Refers to the conditional access policy conditions that are satisfied. The possible values are: none, application, users, devicePlatform, location, clientType, signInRisk, userRisk, time, deviceState, client,ipAddressSeenByAzureAD,ipAddressSeenByResourceProvider,unknownFutureValue,servicePrincipals,servicePrincipalRisk. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: servicePrincipals,servicePrincipalRisk.</summary>
        public ConditionalAccessConditions? ConditionsSatisfied { get; set; }
        /// <summary>Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').</summary>
        public string DisplayName { get; set; }
        /// <summary>Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').</summary>
        public List<string> EnforcedGrantControls { get; set; }
        /// <summary>Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').</summary>
        public List<string> EnforcedSessionControls { get; set; }
        /// <summary>List of key-value pairs containing each matched exclude condition in the conditional access policy. Example: [{'devicePlatform' : 'DevicePlatform'}] means the policy didn’t apply, because the DevicePlatform condition was a match.</summary>
        public List<ConditionalAccessRuleSatisfied> ExcludeRulesSatisfied { get; set; }
        /// <summary>An identifier of the conditional access policy.</summary>
        public string Id { get; set; }
        /// <summary>List of key-value pairs containing each matched include condition in the conditional access policy. Example: [{ 'application' : 'AllApps'}, {'users': 'Group'}], meaning Application condition was a match because AllApps are included and Users condition was a match because the user was part of the included Group rule.</summary>
        public List<ConditionalAccessRuleSatisfied> IncludeRulesSatisfied { get; set; }
        /// <summary>Indicates the result of the CA policy that was triggered. Possible values are: success, failure, notApplied (Policy isn't applied because policy conditions were not met),notEnabled (This is due to the policy in disabled state), unknown, unknownFutureValue.</summary>
        public AppliedConditionalAccessPolicyResult? Result { get; set; }
        /// <summary>
        /// Instantiates a new appliedConditionalAccessPolicy and sets the default values.
        /// </summary>
        public AppliedConditionalAccessPolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AppliedConditionalAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppliedConditionalAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"authenticationStrength", (o,n) => { (o as AppliedConditionalAccessPolicy).AuthenticationStrength = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AuthenticationStrength>(MicrosoftGraphSdk.Models.Microsoft.Graph.AuthenticationStrength.CreateFromDiscriminatorValue); } },
                {"conditionsNotSatisfied", (o,n) => { (o as AppliedConditionalAccessPolicy).ConditionsNotSatisfied = n.GetEnumValue<ConditionalAccessConditions>(); } },
                {"conditionsSatisfied", (o,n) => { (o as AppliedConditionalAccessPolicy).ConditionsSatisfied = n.GetEnumValue<ConditionalAccessConditions>(); } },
                {"displayName", (o,n) => { (o as AppliedConditionalAccessPolicy).DisplayName = n.GetStringValue(); } },
                {"enforcedGrantControls", (o,n) => { (o as AppliedConditionalAccessPolicy).EnforcedGrantControls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"enforcedSessionControls", (o,n) => { (o as AppliedConditionalAccessPolicy).EnforcedSessionControls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"excludeRulesSatisfied", (o,n) => { (o as AppliedConditionalAccessPolicy).ExcludeRulesSatisfied = n.GetCollectionOfObjectValues<ConditionalAccessRuleSatisfied>(ConditionalAccessRuleSatisfied.CreateFromDiscriminatorValue).ToList(); } },
                {"id", (o,n) => { (o as AppliedConditionalAccessPolicy).Id = n.GetStringValue(); } },
                {"includeRulesSatisfied", (o,n) => { (o as AppliedConditionalAccessPolicy).IncludeRulesSatisfied = n.GetCollectionOfObjectValues<ConditionalAccessRuleSatisfied>(ConditionalAccessRuleSatisfied.CreateFromDiscriminatorValue).ToList(); } },
                {"result", (o,n) => { (o as AppliedConditionalAccessPolicy).Result = n.GetEnumValue<AppliedConditionalAccessPolicyResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AuthenticationStrength>("authenticationStrength", AuthenticationStrength);
            writer.WriteEnumValue<ConditionalAccessConditions>("conditionsNotSatisfied", ConditionsNotSatisfied);
            writer.WriteEnumValue<ConditionalAccessConditions>("conditionsSatisfied", ConditionsSatisfied);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedGrantControls", EnforcedGrantControls);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedSessionControls", EnforcedSessionControls);
            writer.WriteCollectionOfObjectValues<ConditionalAccessRuleSatisfied>("excludeRulesSatisfied", ExcludeRulesSatisfied);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<ConditionalAccessRuleSatisfied>("includeRulesSatisfied", IncludeRulesSatisfied);
            writer.WriteEnumValue<AppliedConditionalAccessPolicyResult>("result", Result);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

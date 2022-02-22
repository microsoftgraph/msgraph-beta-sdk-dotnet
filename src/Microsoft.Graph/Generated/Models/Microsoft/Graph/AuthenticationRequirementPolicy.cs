using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AuthenticationRequirementPolicy : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Provides additional detail on the feature identified in requirementProvider.</summary>
        public string Detail { get; set; }
        /// <summary>Identifies what Azure AD feature requires MFA in this policy. Possible values are: user, request, servicePrincipal, v1ConditionalAccess, multiConditionalAccess, tenantSessionRiskPolicy, accountCompromisePolicies, v1ConditionalAccessDependency, v1ConditionalAccessPolicyIdRequested, mfaRegistrationRequiredByIdentityProtectionPolicy, baselineProtection, mfaRegistrationRequiredByBaselineProtection, mfaRegistrationRequiredByMultiConditionalAccess, enforcedForCspAdmins, securityDefaults, mfaRegistrationRequiredBySecurityDefaults, proofUpCodeRequest, crossTenantOutboundRule, gpsLocationCondition, riskBasedPolicy, unknownFutureValue.</summary>
        public RequirementProvider? RequirementProvider { get; set; }
        /// <summary>
        /// Instantiates a new authenticationRequirementPolicy and sets the default values.
        /// </summary>
        public AuthenticationRequirementPolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"detail", (o,n) => { (o as AuthenticationRequirementPolicy).Detail = n.GetStringValue(); } },
                {"requirementProvider", (o,n) => { (o as AuthenticationRequirementPolicy).RequirementProvider = n.GetEnumValue<RequirementProvider>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detail", Detail);
            writer.WriteEnumValue<RequirementProvider>("requirementProvider", RequirementProvider);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

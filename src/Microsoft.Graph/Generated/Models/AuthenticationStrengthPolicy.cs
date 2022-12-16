using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class AuthenticationStrengthPolicy : Entity, IParsable {
        /// <summary>A collection of authentication method modes that are required be used to satify this authentication strength.</summary>
        public List<AuthenticationMethodModes?> AllowedCombinations {
            get { return BackingStore?.Get<List<AuthenticationMethodModes?>>("allowedCombinations"); }
            set { BackingStore?.Set("allowedCombinations", value); }
        }
        /// <summary>Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.</summary>
        public List<AuthenticationCombinationConfiguration> CombinationConfigurations {
            get { return BackingStore?.Get<List<AuthenticationCombinationConfiguration>>("combinationConfigurations"); }
            set { BackingStore?.Set("combinationConfigurations", value); }
        }
        /// <summary>The datetime when this policy was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The human-readable description of this policy.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The human-readable display name of this policy. Supports $filter (eq, ne, not , and in).</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The datetime when this policy was last modified.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>The policyType property</summary>
        public AuthenticationStrengthPolicyType? PolicyType {
            get { return BackingStore?.Get<AuthenticationStrengthPolicyType?>("policyType"); }
            set { BackingStore?.Set("policyType", value); }
        }
        /// <summary>The requirementsSatisfied property</summary>
        public AuthenticationStrengthRequirements? RequirementsSatisfied {
            get { return BackingStore?.Get<AuthenticationStrengthRequirements?>("requirementsSatisfied"); }
            set { BackingStore?.Set("requirementsSatisfied", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuthenticationStrengthPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationStrengthPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedCombinations", n => { AllowedCombinations = n.GetCollectionOfEnumValues<AuthenticationMethodModes>()?.ToList(); } },
                {"combinationConfigurations", n => { CombinationConfigurations = n.GetCollectionOfObjectValues<AuthenticationCombinationConfiguration>(AuthenticationCombinationConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"policyType", n => { PolicyType = n.GetEnumValue<AuthenticationStrengthPolicyType>(); } },
                {"requirementsSatisfied", n => { RequirementsSatisfied = n.GetEnumValue<AuthenticationStrengthRequirements>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<AuthenticationMethodModes>("allowedCombinations", AllowedCombinations);
            writer.WriteCollectionOfObjectValues<AuthenticationCombinationConfiguration>("combinationConfigurations", CombinationConfigurations);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteEnumValue<AuthenticationStrengthPolicyType>("policyType", PolicyType);
            writer.WriteEnumValue<AuthenticationStrengthRequirements>("requirementsSatisfied", RequirementsSatisfied);
        }
    }
}

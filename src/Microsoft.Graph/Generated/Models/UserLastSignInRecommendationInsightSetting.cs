using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserLastSignInRecommendationInsightSetting : AccessReviewRecommendationInsightSetting, IParsable {
        /// <summary>Optional. Indicates the time period of inactivity (with respect to the start date of the review instance) that recommendations will be configured from. The recommendation will be to deny if the user is inactive during the look-back duration. For reviews of groups and Azure AD roles, any duration is accepted. For reviews of applications, 30 days is the maximum duration. If not specified, the duration is 30 days.</summary>
        public TimeSpan? RecommendationLookBackDuration {
            get { return BackingStore?.Get<TimeSpan?>("recommendationLookBackDuration"); }
            set { BackingStore?.Set("recommendationLookBackDuration", value); }
        }
        /// <summary>Indicates whether inactivity is calculated based on the user&apos;s inactivity in the tenant or in the application. The possible values are tenant, application, unknownFutureValue. application is only relevant when the access review is a review of an assignment to an application.</summary>
        public UserSignInRecommendationScope? SignInScope {
            get { return BackingStore?.Get<UserSignInRecommendationScope?>("signInScope"); }
            set { BackingStore?.Set("signInScope", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserLastSignInRecommendationInsightSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserLastSignInRecommendationInsightSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"recommendationLookBackDuration", n => { RecommendationLookBackDuration = n.GetTimeSpanValue(); } },
                {"signInScope", n => { SignInScope = n.GetEnumValue<UserSignInRecommendationScope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("recommendationLookBackDuration", RecommendationLookBackDuration);
            writer.WriteEnumValue<UserSignInRecommendationScope>("signInScope", SignInScope);
        }
    }
}

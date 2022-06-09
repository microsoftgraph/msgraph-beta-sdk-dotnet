using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.JoinedGroups.EvaluateDynamicMembership {
    /// <summary>Provides operations to call the evaluateDynamicMembership method.</summary>
    public class EvaluateDynamicMembershipPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The memberId property</summary>
        public string MemberId {
            get { return BackingStore?.Get<string>(nameof(MemberId)); }
            set { BackingStore?.Set(nameof(MemberId), value); }
        }
        /// <summary>The membershipRule property</summary>
        public string MembershipRule {
            get { return BackingStore?.Get<string>(nameof(MembershipRule)); }
            set { BackingStore?.Set(nameof(MembershipRule), value); }
        }
        /// <summary>
        /// Instantiates a new evaluateDynamicMembershipPostRequestBody and sets the default values.
        /// </summary>
        public EvaluateDynamicMembershipPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateDynamicMembershipPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateDynamicMembershipPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"memberId", n => { MemberId = n.GetStringValue(); } },
                {"membershipRule", n => { MembershipRule = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("memberId", MemberId);
            writer.WriteStringValue("membershipRule", MembershipRule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

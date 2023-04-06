using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Users.Item.JoinedGroups.EvaluateDynamicMembership {
    public class EvaluateDynamicMembershipPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The memberId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberId {
            get { return BackingStore?.Get<string?>("memberId"); }
            set { BackingStore?.Set("memberId", value); }
        }
#nullable restore
#else
        public string MemberId {
            get { return BackingStore?.Get<string>("memberId"); }
            set { BackingStore?.Set("memberId", value); }
        }
#endif
        /// <summary>The membershipRule property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipRule {
            get { return BackingStore?.Get<string?>("membershipRule"); }
            set { BackingStore?.Set("membershipRule", value); }
        }
#nullable restore
#else
        public string MembershipRule {
            get { return BackingStore?.Get<string>("membershipRule"); }
            set { BackingStore?.Set("membershipRule", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new evaluateDynamicMembershipPostRequestBody and sets the default values.
        /// </summary>
        public EvaluateDynamicMembershipPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("memberId", MemberId);
            writer.WriteStringValue("membershipRule", MembershipRule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

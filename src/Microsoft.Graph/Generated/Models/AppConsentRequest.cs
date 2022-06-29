using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class AppConsentRequest : Entity, IParsable {
        /// <summary>The display name of the app for which consent is requested. Required. Supports $filter (eq only) and $orderby.</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>(nameof(AppDisplayName)); }
            set { BackingStore?.Set(nameof(AppDisplayName), value); }
        }
        /// <summary>The identifier of the application. Required. Supports $filter (eq only) and $orderby.</summary>
        public string AppId {
            get { return BackingStore?.Get<string>(nameof(AppId)); }
            set { BackingStore?.Set(nameof(AppId), value); }
        }
        /// <summary>The consent type of the request. Possible values are: Static and Dynamic. These represent static and dynamic permissions, respectively, requested in the consent workflow. Supports $filter (eq only) and $orderby. Required.</summary>
        public string ConsentType {
            get { return BackingStore?.Get<string>(nameof(ConsentType)); }
            set { BackingStore?.Set(nameof(ConsentType), value); }
        }
        /// <summary>A list of pending scopes waiting for approval. This is empty if the consentType is Static. Required.</summary>
        public List<AppConsentRequestScope> PendingScopes {
            get { return BackingStore?.Get<List<AppConsentRequestScope>>(nameof(PendingScopes)); }
            set { BackingStore?.Set(nameof(PendingScopes), value); }
        }
        /// <summary>A list of pending user consent requests.</summary>
        public List<UserConsentRequest> UserConsentRequests {
            get { return BackingStore?.Get<List<UserConsentRequest>>(nameof(UserConsentRequests)); }
            set { BackingStore?.Set(nameof(UserConsentRequests), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AppConsentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppConsentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"consentType", n => { ConsentType = n.GetStringValue(); } },
                {"pendingScopes", n => { PendingScopes = n.GetCollectionOfObjectValues<AppConsentRequestScope>(AppConsentRequestScope.CreateFromDiscriminatorValue).ToList(); } },
                {"userConsentRequests", n => { UserConsentRequests = n.GetCollectionOfObjectValues<UserConsentRequest>(UserConsentRequest.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("consentType", ConsentType);
            writer.WriteCollectionOfObjectValues<AppConsentRequestScope>("pendingScopes", PendingScopes);
            writer.WriteCollectionOfObjectValues<UserConsentRequest>("userConsentRequests", UserConsentRequests);
        }
    }
}

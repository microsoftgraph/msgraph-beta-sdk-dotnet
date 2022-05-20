using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RequestorSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Indicates whether new requests are accepted on this policy.</summary>
        public bool? AcceptRequests {
            get { return BackingStore?.Get<bool?>(nameof(AcceptRequests)); }
            set { BackingStore?.Set(nameof(AcceptRequests), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The users who are allowed to request on this policy, which can be singleUser, groupMembers, and connectedOrganizationMembers.</summary>
        public List<UserSet> AllowedRequestors {
            get { return BackingStore?.Get<List<UserSet>>(nameof(AllowedRequestors)); }
            set { BackingStore?.Set(nameof(AllowedRequestors), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Who can request. One of NoSubjects, SpecificDirectorySubjects, SpecificConnectedOrganizationSubjects, AllConfiguredConnectedOrganizationSubjects, AllExistingConnectedOrganizationSubjects, AllExistingDirectoryMemberUsers, AllExistingDirectorySubjects or AllExternalSubjects.</summary>
        public string ScopeType {
            get { return BackingStore?.Get<string>(nameof(ScopeType)); }
            set { BackingStore?.Set(nameof(ScopeType), value); }
        }
        /// <summary>
        /// Instantiates a new requestorSettings and sets the default values.
        /// </summary>
        public RequestorSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RequestorSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RequestorSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acceptRequests", n => { AcceptRequests = n.GetBoolValue(); } },
                {"allowedRequestors", n => { AllowedRequestors = n.GetCollectionOfObjectValues<UserSet>(UserSet.CreateFromDiscriminatorValue).ToList(); } },
                {"scopeType", n => { ScopeType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("acceptRequests", AcceptRequests);
            writer.WriteCollectionOfObjectValues<UserSet>("allowedRequestors", AllowedRequestors);
            writer.WriteStringValue("scopeType", ScopeType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

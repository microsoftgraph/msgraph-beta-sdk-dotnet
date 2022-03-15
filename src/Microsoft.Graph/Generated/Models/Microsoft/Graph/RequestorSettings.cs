using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class RequestorSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Indicates whether new requests are accepted on this policy.</summary>
        public bool? AcceptRequests { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The users who are allowed to request on this policy, which can be singleUser, groupMembers, and connectedOrganizationMembers.</summary>
        public List<UserSet> AllowedRequestors { get; set; }
        /// <summary>Who can request. One of NoSubjects, SpecificDirectorySubjects, SpecificConnectedOrganizationSubjects, AllConfiguredConnectedOrganizationSubjects, AllExistingConnectedOrganizationSubjects, AllExistingDirectoryMemberUsers, AllExistingDirectorySubjects or AllExternalSubjects.</summary>
        public string ScopeType { get; set; }
        /// <summary>
        /// Instantiates a new requestorSettings and sets the default values.
        /// </summary>
        public RequestorSettings() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"acceptRequests", (o,n) => { (o as RequestorSettings).AcceptRequests = n.GetBoolValue(); } },
                {"allowedRequestors", (o,n) => { (o as RequestorSettings).AllowedRequestors = n.GetCollectionOfObjectValues<UserSet>(UserSet.CreateFromDiscriminatorValue).ToList(); } },
                {"scopeType", (o,n) => { (o as RequestorSettings).ScopeType = n.GetStringValue(); } },
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

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AzureAdJoinPolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The identifiers of the groups that are in the scope of the policy. Required when the appliesTo property is set to selected.</summary>
        public List<string> AllowedGroups {
            get { return BackingStore?.Get<List<string>>("allowedGroups"); }
            set { BackingStore?.Set("allowedGroups", value); }
        }
        /// <summary>The identifiers of users that are in the scope of the policy. Required when the appliesTo property is set to selected.</summary>
        public List<string> AllowedUsers {
            get { return BackingStore?.Get<List<string>>("allowedUsers"); }
            set { BackingStore?.Set("allowedUsers", value); }
        }
        /// <summary>Specifies whether to block or allow fine-grained control of the policy scope. The possible values are: 0 (meaning none), 1 (meaning all), 2 (meaning selected), 3 (meaning unknownFutureValue). The default value is 1. When set to 2, at least one user or group identifier must be specified in either allowedUsers or allowedGroups.  Setting this property to 0 or 1 removes all identifiers in both allowedUsers and allowedGroups.</summary>
        public PolicyScope? AppliesTo {
            get { return BackingStore?.Get<PolicyScope?>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies whether this policy scope is configurable by the admin. The default value is false. When an admin has enabled Intune (MEM) to manage devices, this property is set to false and appliesTo defaults to 1 (meaning all).</summary>
        public bool? IsAdminConfigurable {
            get { return BackingStore?.Get<bool?>("isAdminConfigurable"); }
            set { BackingStore?.Set("isAdminConfigurable", value); }
        }
        /// <summary>
        /// Instantiates a new azureAdJoinPolicy and sets the default values.
        /// </summary>
        public AzureAdJoinPolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AzureAdJoinPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AzureAdJoinPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedGroups", n => { AllowedGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"allowedUsers", n => { AllowedUsers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"appliesTo", n => { AppliesTo = n.GetEnumValue<PolicyScope>(); } },
                {"isAdminConfigurable", n => { IsAdminConfigurable = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedGroups", AllowedGroups);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedUsers", AllowedUsers);
            writer.WriteEnumValue<PolicyScope>("appliesTo", AppliesTo);
            writer.WriteBoolValue("isAdminConfigurable", IsAdminConfigurable);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ConditionalAccessUsers : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Group IDs excluded from scope of policy.</summary>
        public List<string> ExcludeGroups {
            get { return BackingStore?.Get<List<string>>("excludeGroups"); }
            set { BackingStore?.Set("excludeGroups", value); }
        }
        /// <summary>Internal guests or external users excluded in the policy scope. Optionally populated.</summary>
        public ConditionalAccessGuestsOrExternalUsers ExcludeGuestsOrExternalUsers {
            get { return BackingStore?.Get<ConditionalAccessGuestsOrExternalUsers>("excludeGuestsOrExternalUsers"); }
            set { BackingStore?.Set("excludeGuestsOrExternalUsers", value); }
        }
        /// <summary>Role IDs excluded from scope of policy.</summary>
        public List<string> ExcludeRoles {
            get { return BackingStore?.Get<List<string>>("excludeRoles"); }
            set { BackingStore?.Set("excludeRoles", value); }
        }
        /// <summary>User IDs excluded from scope of policy and/or GuestsOrExternalUsers.</summary>
        public List<string> ExcludeUsers {
            get { return BackingStore?.Get<List<string>>("excludeUsers"); }
            set { BackingStore?.Set("excludeUsers", value); }
        }
        /// <summary>Group IDs in scope of policy unless explicitly excluded, or All.</summary>
        public List<string> IncludeGroups {
            get { return BackingStore?.Get<List<string>>("includeGroups"); }
            set { BackingStore?.Set("includeGroups", value); }
        }
        /// <summary>Internal guests or external users included in the policy scope. Optionally populated.</summary>
        public ConditionalAccessGuestsOrExternalUsers IncludeGuestsOrExternalUsers {
            get { return BackingStore?.Get<ConditionalAccessGuestsOrExternalUsers>("includeGuestsOrExternalUsers"); }
            set { BackingStore?.Set("includeGuestsOrExternalUsers", value); }
        }
        /// <summary>Role IDs in scope of policy unless explicitly excluded, or All.</summary>
        public List<string> IncludeRoles {
            get { return BackingStore?.Get<List<string>>("includeRoles"); }
            set { BackingStore?.Set("includeRoles", value); }
        }
        /// <summary>User IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.</summary>
        public List<string> IncludeUsers {
            get { return BackingStore?.Get<List<string>>("includeUsers"); }
            set { BackingStore?.Set("includeUsers", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new conditionalAccessUsers and sets the default values.
        /// </summary>
        public ConditionalAccessUsers() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessUsers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessUsers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeGroups", n => { ExcludeGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"excludeGuestsOrExternalUsers", n => { ExcludeGuestsOrExternalUsers = n.GetObjectValue<ConditionalAccessGuestsOrExternalUsers>(ConditionalAccessGuestsOrExternalUsers.CreateFromDiscriminatorValue); } },
                {"excludeRoles", n => { ExcludeRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"excludeUsers", n => { ExcludeUsers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeGroups", n => { IncludeGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeGuestsOrExternalUsers", n => { IncludeGuestsOrExternalUsers = n.GetObjectValue<ConditionalAccessGuestsOrExternalUsers>(ConditionalAccessGuestsOrExternalUsers.CreateFromDiscriminatorValue); } },
                {"includeRoles", n => { IncludeRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeUsers", n => { IncludeUsers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeGroups", ExcludeGroups);
            writer.WriteObjectValue<ConditionalAccessGuestsOrExternalUsers>("excludeGuestsOrExternalUsers", ExcludeGuestsOrExternalUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeRoles", ExcludeRoles);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeUsers", ExcludeUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeGroups", IncludeGroups);
            writer.WriteObjectValue<ConditionalAccessGuestsOrExternalUsers>("includeGuestsOrExternalUsers", IncludeGuestsOrExternalUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeRoles", IncludeRoles);
            writer.WriteCollectionOfPrimitiveValues<string>("includeUsers", IncludeUsers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

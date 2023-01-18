using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Mapping between an Android app permission and the action Android should take when that permission is requested.
    /// </summary>
    public class AndroidPermissionAction : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Android action taken when an app requests a dangerous permission.</summary>
        public AndroidPermissionActionType? Action {
            get { return BackingStore?.Get<AndroidPermissionActionType?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Android permission string, defined in the official Android documentation.  Example &apos;android.permission.READ_CONTACTS&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Permission {
            get { return BackingStore?.Get<string?>("permission"); }
            set { BackingStore?.Set("permission", value); }
        }
#else
        public string Permission {
            get { return BackingStore?.Get<string>("permission"); }
            set { BackingStore?.Set("permission", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new androidPermissionAction and sets the default values.
        /// </summary>
        public AndroidPermissionAction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidPermissionAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidPermissionAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetEnumValue<AndroidPermissionActionType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"permission", n => { Permission = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AndroidPermissionActionType>("action", Action);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("permission", Permission);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

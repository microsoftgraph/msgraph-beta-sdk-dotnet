using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>iOS Kerberos authentication settings for single sign-on</summary>
    public class IosSingleSignOnSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>List of app identifiers that are allowed to use this login. If this field is omitted, the login applies to all applications on the device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AllowedAppsList {
            get { return BackingStore?.Get<List<AppListItem>>("allowedAppsList"); }
            set { BackingStore?.Set("allowedAppsList", value); }
        }
        /// <summary>List of HTTP URLs that must be matched in order to use this login. With iOS 9.0 or later, a wildcard characters may be used.</summary>
        public List<string> AllowedUrls {
            get { return BackingStore?.Get<List<string>>("allowedUrls"); }
            set { BackingStore?.Set("allowedUrls", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The display name of login settings shown on the receiving device.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>A Kerberos principal name. If not provided, the user is prompted for one during profile installation.</summary>
        public string KerberosPrincipalName {
            get { return BackingStore?.Get<string>("kerberosPrincipalName"); }
            set { BackingStore?.Set("kerberosPrincipalName", value); }
        }
        /// <summary>A Kerberos realm name. Case sensitive.</summary>
        public string KerberosRealm {
            get { return BackingStore?.Get<string>("kerberosRealm"); }
            set { BackingStore?.Set("kerberosRealm", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new iosSingleSignOnSettings and sets the default values.
        /// </summary>
        public IosSingleSignOnSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.iosSingleSignOnSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IosSingleSignOnSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosSingleSignOnSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedAppsList", n => { AllowedAppsList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"allowedUrls", n => { AllowedUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"kerberosPrincipalName", n => { KerberosPrincipalName = n.GetStringValue(); } },
                {"kerberosRealm", n => { KerberosRealm = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AppListItem>("allowedAppsList", AllowedAppsList);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedUrls", AllowedUrls);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("kerberosPrincipalName", KerberosPrincipalName);
            writer.WriteStringValue("kerberosRealm", KerberosRealm);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

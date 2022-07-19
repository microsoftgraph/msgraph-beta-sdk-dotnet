using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidForWorkMobileAppConfiguration : ManagedDeviceMobileAppConfiguration, IParsable {
        /// <summary>Setting to specify whether to allow ConnectedApps experience for this app.</summary>
        public bool? ConnectedAppsEnabled {
            get { return BackingStore?.Get<bool?>("connectedAppsEnabled"); }
            set { BackingStore?.Set("connectedAppsEnabled", value); }
        }
        /// <summary>Android For Work app configuration package id.</summary>
        public string PackageId {
            get { return BackingStore?.Get<string>("packageId"); }
            set { BackingStore?.Set("packageId", value); }
        }
        /// <summary>Android For Work app configuration JSON payload.</summary>
        public string PayloadJson {
            get { return BackingStore?.Get<string>("payloadJson"); }
            set { BackingStore?.Set("payloadJson", value); }
        }
        /// <summary>List of Android app permissions and corresponding permission actions.</summary>
        public List<AndroidPermissionAction> PermissionActions {
            get { return BackingStore?.Get<List<AndroidPermissionAction>>("permissionActions"); }
            set { BackingStore?.Set("permissionActions", value); }
        }
        /// <summary>Android profile applicability</summary>
        public AndroidProfileApplicability? ProfileApplicability {
            get { return BackingStore?.Get<AndroidProfileApplicability?>("profileApplicability"); }
            set { BackingStore?.Set("profileApplicability", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidForWorkMobileAppConfiguration and sets the default values.
        /// </summary>
        public AndroidForWorkMobileAppConfiguration() : base() {
            OdataType = "#microsoft.graph.androidForWorkMobileAppConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidForWorkMobileAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidForWorkMobileAppConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectedAppsEnabled", n => { ConnectedAppsEnabled = n.GetBoolValue(); } },
                {"packageId", n => { PackageId = n.GetStringValue(); } },
                {"payloadJson", n => { PayloadJson = n.GetStringValue(); } },
                {"permissionActions", n => { PermissionActions = n.GetCollectionOfObjectValues<AndroidPermissionAction>(AndroidPermissionAction.CreateFromDiscriminatorValue).ToList(); } },
                {"profileApplicability", n => { ProfileApplicability = n.GetEnumValue<AndroidProfileApplicability>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("connectedAppsEnabled", ConnectedAppsEnabled);
            writer.WriteStringValue("packageId", PackageId);
            writer.WriteStringValue("payloadJson", PayloadJson);
            writer.WriteCollectionOfObjectValues<AndroidPermissionAction>("permissionActions", PermissionActions);
            writer.WriteEnumValue<AndroidProfileApplicability>("profileApplicability", ProfileApplicability);
        }
    }
}

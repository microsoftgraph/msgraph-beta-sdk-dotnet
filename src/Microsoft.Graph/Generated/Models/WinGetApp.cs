using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WinGetApp : MobileApp, IParsable {
        /// <summary>The install experience settings associated with this application, which are used to ensure the desired install experiences on the target device are taken into account. This includes the account type (System or User) that actions should be run as on target devices. Required at creation time.</summary>
        public WinGetAppInstallExperience InstallExperience {
            get { return BackingStore?.Get<WinGetAppInstallExperience>("installExperience"); }
            set { BackingStore?.Set("installExperience", value); }
        }
        /// <summary>The PackageIdentifier from the WinGet source repository REST API. This also maps to the Id when using the WinGet client command line application. Required at creation time, cannot be modified on existing objects.</summary>
        public string PackageIdentifier {
            get { return BackingStore?.Get<string>("packageIdentifier"); }
            set { BackingStore?.Set("packageIdentifier", value); }
        }
        /// <summary>
        /// Instantiates a new WinGetApp and sets the default values.
        /// </summary>
        public WinGetApp() : base() {
            OdataType = "#microsoft.graph.winGetApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WinGetApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WinGetApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"installExperience", n => { InstallExperience = n.GetObjectValue<WinGetAppInstallExperience>(WinGetAppInstallExperience.CreateFromDiscriminatorValue); } },
                {"packageIdentifier", n => { PackageIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WinGetAppInstallExperience>("installExperience", InstallExperience);
            writer.WriteStringValue("packageIdentifier", PackageIdentifier);
        }
    }
}

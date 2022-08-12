using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>This will allow the admin to see the different templated organizational messages that can be created</summary>
    public class OrganizationalMessageGuidedContent : Entity, IParsable {
        /// <summary>Example of the logo that will be displayed to customers and its size requirements</summary>
        public OrganizationalMessageLogoGuide Logo {
            get { return BackingStore?.Get<OrganizationalMessageLogoGuide>("logo"); }
            set { BackingStore?.Set("logo", value); }
        }
        /// <summary>Contains the different types of text content that can be displayed to customers along with their localized values</summary>
        public List<OrganizationalMessagePlacementDetail> PlacementDetails {
            get { return BackingStore?.Get<List<OrganizationalMessagePlacementDetail>>("placementDetails"); }
            set { BackingStore?.Set("placementDetails", value); }
        }
        /// <summary>Indicates the scenario for the message</summary>
        public OrganizationalMessageScenario? Scenario {
            get { return BackingStore?.Get<OrganizationalMessageScenario?>("scenario"); }
            set { BackingStore?.Set("scenario", value); }
        }
        /// <summary>Indicates the area where content will be displayed to customers</summary>
        public OrganizationalMessageSurface? Surface {
            get { return BackingStore?.Get<OrganizationalMessageSurface?>("surface"); }
            set { BackingStore?.Set("surface", value); }
        }
        /// <summary>Indicates the theme for the guided content</summary>
        public OrganizationalMessageTheme? Theme {
            get { return BackingStore?.Get<OrganizationalMessageTheme?>("theme"); }
            set { BackingStore?.Set("theme", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessageGuidedContent and sets the default values.
        /// </summary>
        public OrganizationalMessageGuidedContent() : base() {
            OdataType = "#microsoft.graph.organizationalMessageGuidedContent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OrganizationalMessageGuidedContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageGuidedContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"logo", n => { Logo = n.GetObjectValue<OrganizationalMessageLogoGuide>(OrganizationalMessageLogoGuide.CreateFromDiscriminatorValue); } },
                {"placementDetails", n => { PlacementDetails = n.GetCollectionOfObjectValues<OrganizationalMessagePlacementDetail>(OrganizationalMessagePlacementDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"scenario", n => { Scenario = n.GetEnumValue<OrganizationalMessageScenario>(); } },
                {"surface", n => { Surface = n.GetEnumValue<OrganizationalMessageSurface>(); } },
                {"theme", n => { Theme = n.GetEnumValue<OrganizationalMessageTheme>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OrganizationalMessageLogoGuide>("logo", Logo);
            writer.WriteCollectionOfObjectValues<OrganizationalMessagePlacementDetail>("placementDetails", PlacementDetails);
            writer.WriteEnumValue<OrganizationalMessageScenario>("scenario", Scenario);
            writer.WriteEnumValue<OrganizationalMessageSurface>("surface", Surface);
            writer.WriteEnumValue<OrganizationalMessageTheme>("theme", Theme);
        }
    }
}

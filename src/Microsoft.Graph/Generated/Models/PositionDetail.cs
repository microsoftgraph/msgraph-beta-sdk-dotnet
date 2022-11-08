using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PositionDetail : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Detail about the company or employer.</summary>
        public CompanyDetail Company {
            get { return BackingStore?.Get<CompanyDetail>("company"); }
            set { BackingStore?.Set("company", value); }
        }
        /// <summary>Description of the position in question.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>When the position ended.</summary>
        public Date? EndMonthYear {
            get { return BackingStore?.Get<Date?>("endMonthYear"); }
            set { BackingStore?.Set("endMonthYear", value); }
        }
        /// <summary>The title held when in that position.</summary>
        public string JobTitle {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The role the position entailed.</summary>
        public string Role {
            get { return BackingStore?.Get<string>("role"); }
            set { BackingStore?.Set("role", value); }
        }
        /// <summary>The start month and year of the position.</summary>
        public Date? StartMonthYear {
            get { return BackingStore?.Get<Date?>("startMonthYear"); }
            set { BackingStore?.Set("startMonthYear", value); }
        }
        /// <summary>Short summary of the position.</summary>
        public string Summary {
            get { return BackingStore?.Get<string>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
        /// <summary>
        /// Instantiates a new positionDetail and sets the default values.
        /// </summary>
        public PositionDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.positionDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PositionDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PositionDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"company", n => { Company = n.GetObjectValue<CompanyDetail>(CompanyDetail.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"endMonthYear", n => { EndMonthYear = n.GetDateValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"startMonthYear", n => { StartMonthYear = n.GetDateValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CompanyDetail>("company", Company);
            writer.WriteStringValue("description", Description);
            writer.WriteDateValue("endMonthYear", EndMonthYear);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("role", Role);
            writer.WriteDateValue("startMonthYear", StartMonthYear);
            writer.WriteStringValue("summary", Summary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

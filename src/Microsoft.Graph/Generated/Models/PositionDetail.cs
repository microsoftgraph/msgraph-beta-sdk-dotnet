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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Detail about the company or employer.</summary>
        public CompanyDetail Company {
            get { return BackingStore?.Get<CompanyDetail>(nameof(Company)); }
            set { BackingStore?.Set(nameof(Company), value); }
        }
        /// <summary>Description of the position in question.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>When the position ended.</summary>
        public Date? EndMonthYear {
            get { return BackingStore?.Get<Date?>(nameof(EndMonthYear)); }
            set { BackingStore?.Set(nameof(EndMonthYear), value); }
        }
        /// <summary>The title held when in that position.</summary>
        public string JobTitle {
            get { return BackingStore?.Get<string>(nameof(JobTitle)); }
            set { BackingStore?.Set(nameof(JobTitle), value); }
        }
        /// <summary>The role the position entailed.</summary>
        public string Role {
            get { return BackingStore?.Get<string>(nameof(Role)); }
            set { BackingStore?.Set(nameof(Role), value); }
        }
        /// <summary>The start month and year of the position.</summary>
        public Date? StartMonthYear {
            get { return BackingStore?.Get<Date?>(nameof(StartMonthYear)); }
            set { BackingStore?.Set(nameof(StartMonthYear), value); }
        }
        /// <summary>Short summary of the position.</summary>
        public string Summary {
            get { return BackingStore?.Get<string>(nameof(Summary)); }
            set { BackingStore?.Set(nameof(Summary), value); }
        }
        /// <summary>
        /// Instantiates a new positionDetail and sets the default values.
        /// </summary>
        public PositionDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"role", n => { Role = n.GetStringValue(); } },
                {"startMonthYear", n => { StartMonthYear = n.GetDateValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CompanyDetail>("company", Company);
            writer.WriteStringValue("description", Description);
            writer.WriteDateValue("endMonthYear", EndMonthYear);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("role", Role);
            writer.WriteDateValue("startMonthYear", StartMonthYear);
            writer.WriteStringValue("summary", Summary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

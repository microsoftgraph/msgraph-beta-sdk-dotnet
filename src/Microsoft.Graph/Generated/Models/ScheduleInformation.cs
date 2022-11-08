using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ScheduleInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Represents a merged view of availability of all the items in scheduleItems. The view consists of time slots. Availability during each time slot is indicated with: 0= free, 1= tentative, 2= busy, 3= out of office, 4= working elsewhere.</summary>
        public string AvailabilityView {
            get { return BackingStore?.Get<string>("availabilityView"); }
            set { BackingStore?.Set("availabilityView", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Error information from attempting to get the availability of the user, distribution list, or resource.</summary>
        public FreeBusyError Error {
            get { return BackingStore?.Get<FreeBusyError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>An SMTP address of the user, distribution list, or resource, identifying an instance of scheduleInformation.</summary>
        public string ScheduleId {
            get { return BackingStore?.Get<string>("scheduleId"); }
            set { BackingStore?.Set("scheduleId", value); }
        }
        /// <summary>Contains the items that describe the availability of the user or resource.</summary>
        public List<ScheduleItem> ScheduleItems {
            get { return BackingStore?.Get<List<ScheduleItem>>("scheduleItems"); }
            set { BackingStore?.Set("scheduleItems", value); }
        }
        /// <summary>The days of the week and hours in a specific time zone that the user works. These are set as part of the user&apos;s mailboxSettings.</summary>
        public Microsoft.Graph.Beta.Models.WorkingHours WorkingHours {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkingHours>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
        /// <summary>
        /// Instantiates a new scheduleInformation and sets the default values.
        /// </summary>
        public ScheduleInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.scheduleInformation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ScheduleInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScheduleInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"availabilityView", n => { AvailabilityView = n.GetStringValue(); } },
                {"error", n => { Error = n.GetObjectValue<FreeBusyError>(FreeBusyError.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"scheduleId", n => { ScheduleId = n.GetStringValue(); } },
                {"scheduleItems", n => { ScheduleItems = n.GetCollectionOfObjectValues<ScheduleItem>(ScheduleItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"workingHours", n => { WorkingHours = n.GetObjectValue<Microsoft.Graph.Beta.Models.WorkingHours>(Microsoft.Graph.Beta.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("availabilityView", AvailabilityView);
            writer.WriteObjectValue<FreeBusyError>("error", Error);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("scheduleId", ScheduleId);
            writer.WriteCollectionOfObjectValues<ScheduleItem>("scheduleItems", ScheduleItems);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

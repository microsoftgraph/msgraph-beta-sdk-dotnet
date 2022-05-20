using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents a booked appointment of a service by a customer in a business.</summary>
    public class BookingAppointment : Entity, IParsable {
        /// <summary>Additional information that is sent to the customer when an appointment is confirmed.</summary>
        public string AdditionalInformation {
            get { return BackingStore?.Get<string>(nameof(AdditionalInformation)); }
            set { BackingStore?.Set(nameof(AdditionalInformation), value); }
        }
        /// <summary>The SMTP address of the bookingCustomer who is booking the appointment.</summary>
        public string CustomerEmailAddress {
            get { return BackingStore?.Get<string>(nameof(CustomerEmailAddress)); }
            set { BackingStore?.Set(nameof(CustomerEmailAddress), value); }
        }
        /// <summary>The ID of the bookingCustomer for this appointment. If no ID is specified when an appointment is created, then a new bookingCustomer object is created. Once set, you should consider the customerId immutable.</summary>
        public string CustomerId {
            get { return BackingStore?.Get<string>(nameof(CustomerId)); }
            set { BackingStore?.Set(nameof(CustomerId), value); }
        }
        /// <summary>Represents location information for the bookingCustomer who is booking the appointment.</summary>
        public Location CustomerLocation {
            get { return BackingStore?.Get<Location>(nameof(CustomerLocation)); }
            set { BackingStore?.Set(nameof(CustomerLocation), value); }
        }
        /// <summary>The customer&apos;s name.</summary>
        public string CustomerName {
            get { return BackingStore?.Get<string>(nameof(CustomerName)); }
            set { BackingStore?.Set(nameof(CustomerName), value); }
        }
        /// <summary>Notes from the customer associated with this appointment. You can get the value only when reading this bookingAppointment by its ID.  You can set this property only when initially creating an appointment with a new customer. After that point, the value is computed from the customer represented by customerId.</summary>
        public string CustomerNotes {
            get { return BackingStore?.Get<string>(nameof(CustomerNotes)); }
            set { BackingStore?.Set(nameof(CustomerNotes), value); }
        }
        /// <summary>The customer&apos;s phone number.</summary>
        public string CustomerPhone {
            get { return BackingStore?.Get<string>(nameof(CustomerPhone)); }
            set { BackingStore?.Set(nameof(CustomerPhone), value); }
        }
        /// <summary>It lists down the customer properties for an appointment. An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment. Optional.</summary>
        public List<BookingCustomerInformationBase> Customers {
            get { return BackingStore?.Get<List<BookingCustomerInformationBase>>(nameof(Customers)); }
            set { BackingStore?.Set(nameof(Customers), value); }
        }
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
        public string CustomerTimeZone {
            get { return BackingStore?.Get<string>(nameof(CustomerTimeZone)); }
            set { BackingStore?.Set(nameof(CustomerTimeZone), value); }
        }
        /// <summary>The length of the appointment, denoted in ISO8601 format.</summary>
        public TimeSpan? Duration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(Duration)); }
            set { BackingStore?.Set(nameof(Duration), value); }
        }
        /// <summary>The end property</summary>
        public DateTimeTimeZone End {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(End)); }
            set { BackingStore?.Set(nameof(End), value); }
        }
        /// <summary>The current number of customers in the appointment.</summary>
        public int? FilledAttendeesCount {
            get { return BackingStore?.Get<int?>(nameof(FilledAttendeesCount)); }
            set { BackingStore?.Set(nameof(FilledAttendeesCount), value); }
        }
        /// <summary>The billed amount on the invoice.</summary>
        public double? InvoiceAmount {
            get { return BackingStore?.Get<double?>(nameof(InvoiceAmount)); }
            set { BackingStore?.Set(nameof(InvoiceAmount), value); }
        }
        /// <summary>The date, time, and time zone of the invoice for this appointment.</summary>
        public DateTimeTimeZone InvoiceDate {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(InvoiceDate)); }
            set { BackingStore?.Set(nameof(InvoiceDate), value); }
        }
        /// <summary>The ID of the invoice.</summary>
        public string InvoiceId {
            get { return BackingStore?.Get<string>(nameof(InvoiceId)); }
            set { BackingStore?.Set(nameof(InvoiceId), value); }
        }
        /// <summary>The status of the invoice. Possible values are: draft, reviewing, open, canceled, paid, corrective.</summary>
        public BookingInvoiceStatus? InvoiceStatus {
            get { return BackingStore?.Get<BookingInvoiceStatus?>(nameof(InvoiceStatus)); }
            set { BackingStore?.Set(nameof(InvoiceStatus), value); }
        }
        /// <summary>The URL of the invoice in Microsoft Bookings.</summary>
        public string InvoiceUrl {
            get { return BackingStore?.Get<string>(nameof(InvoiceUrl)); }
            set { BackingStore?.Set(nameof(InvoiceUrl), value); }
        }
        /// <summary>True indicates that the appointment will be held online. Default value is false.</summary>
        public bool? IsLocationOnline {
            get { return BackingStore?.Get<bool?>(nameof(IsLocationOnline)); }
            set { BackingStore?.Set(nameof(IsLocationOnline), value); }
        }
        /// <summary>The URL of the online meeting for the appointment.</summary>
        public string JoinWebUrl {
            get { return BackingStore?.Get<string>(nameof(JoinWebUrl)); }
            set { BackingStore?.Set(nameof(JoinWebUrl), value); }
        }
        /// <summary>The maximum number of customers allowed in an appointment. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment. To create a customer, use the Create bookingCustomer operation.</summary>
        public int? MaximumAttendeesCount {
            get { return BackingStore?.Get<int?>(nameof(MaximumAttendeesCount)); }
            set { BackingStore?.Set(nameof(MaximumAttendeesCount), value); }
        }
        /// <summary>The onlineMeetingUrl property</summary>
        public string OnlineMeetingUrl {
            get { return BackingStore?.Get<string>(nameof(OnlineMeetingUrl)); }
            set { BackingStore?.Set(nameof(OnlineMeetingUrl), value); }
        }
        /// <summary>True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.</summary>
        public bool? OptOutOfCustomerEmail {
            get { return BackingStore?.Get<bool?>(nameof(OptOutOfCustomerEmail)); }
            set { BackingStore?.Set(nameof(OptOutOfCustomerEmail), value); }
        }
        /// <summary>The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PostBuffer {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PostBuffer)); }
            set { BackingStore?.Set(nameof(PostBuffer), value); }
        }
        /// <summary>The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PreBuffer {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PreBuffer)); }
            set { BackingStore?.Set(nameof(PreBuffer), value); }
        }
        /// <summary>The regular price for an appointment for the specified bookingService.</summary>
        public double? Price {
            get { return BackingStore?.Get<double?>(nameof(Price)); }
            set { BackingStore?.Set(nameof(Price), value); }
        }
        /// <summary>A setting to provide flexibility for the pricing structure of services. Possible values are: undefined, fixedPrice, startingAt, hourly, free, priceVaries, callUs, notSet, unknownFutureValue.</summary>
        public BookingPriceType? PriceType {
            get { return BackingStore?.Get<BookingPriceType?>(nameof(PriceType)); }
            set { BackingStore?.Set(nameof(PriceType), value); }
        }
        /// <summary>The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
        public List<BookingReminder> Reminders {
            get { return BackingStore?.Get<List<BookingReminder>>(nameof(Reminders)); }
            set { BackingStore?.Set(nameof(Reminders), value); }
        }
        /// <summary>An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.</summary>
        public string SelfServiceAppointmentId {
            get { return BackingStore?.Get<string>(nameof(SelfServiceAppointmentId)); }
            set { BackingStore?.Set(nameof(SelfServiceAppointmentId), value); }
        }
        /// <summary>The ID of the bookingService associated with this appointment.</summary>
        public string ServiceId {
            get { return BackingStore?.Get<string>(nameof(ServiceId)); }
            set { BackingStore?.Set(nameof(ServiceId), value); }
        }
        /// <summary>The location where the service is delivered.</summary>
        public Location ServiceLocation {
            get { return BackingStore?.Get<Location>(nameof(ServiceLocation)); }
            set { BackingStore?.Set(nameof(ServiceLocation), value); }
        }
        /// <summary>The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.</summary>
        public string ServiceName {
            get { return BackingStore?.Get<string>(nameof(ServiceName)); }
            set { BackingStore?.Set(nameof(ServiceName), value); }
        }
        /// <summary>Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
        public string ServiceNotes {
            get { return BackingStore?.Get<string>(nameof(ServiceNotes)); }
            set { BackingStore?.Set(nameof(ServiceNotes), value); }
        }
        /// <summary>True indicates SMS notifications will be sent to the customers for the appointment. Default value is false.</summary>
        public bool? SmsNotificationsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SmsNotificationsEnabled)); }
            set { BackingStore?.Set(nameof(SmsNotificationsEnabled), value); }
        }
        /// <summary>The ID of each bookingStaffMember who is scheduled in this appointment.</summary>
        public List<string> StaffMemberIds {
            get { return BackingStore?.Get<List<string>>(nameof(StaffMemberIds)); }
            set { BackingStore?.Set(nameof(StaffMemberIds), value); }
        }
        /// <summary>The start property</summary>
        public DateTimeTimeZone Start {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(Start)); }
            set { BackingStore?.Set(nameof(Start), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BookingAppointment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingAppointment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"customerEmailAddress", n => { CustomerEmailAddress = n.GetStringValue(); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customerLocation", n => { CustomerLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"customerName", n => { CustomerName = n.GetStringValue(); } },
                {"customerNotes", n => { CustomerNotes = n.GetStringValue(); } },
                {"customerPhone", n => { CustomerPhone = n.GetStringValue(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<BookingCustomerInformationBase>(BookingCustomerInformationBase.CreateFromDiscriminatorValue).ToList(); } },
                {"customerTimeZone", n => { CustomerTimeZone = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"end", n => { End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"filledAttendeesCount", n => { FilledAttendeesCount = n.GetIntValue(); } },
                {"invoiceAmount", n => { InvoiceAmount = n.GetDoubleValue(); } },
                {"invoiceDate", n => { InvoiceDate = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"invoiceId", n => { InvoiceId = n.GetStringValue(); } },
                {"invoiceStatus", n => { InvoiceStatus = n.GetEnumValue<BookingInvoiceStatus>(); } },
                {"invoiceUrl", n => { InvoiceUrl = n.GetStringValue(); } },
                {"isLocationOnline", n => { IsLocationOnline = n.GetBoolValue(); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"maximumAttendeesCount", n => { MaximumAttendeesCount = n.GetIntValue(); } },
                {"onlineMeetingUrl", n => { OnlineMeetingUrl = n.GetStringValue(); } },
                {"optOutOfCustomerEmail", n => { OptOutOfCustomerEmail = n.GetBoolValue(); } },
                {"postBuffer", n => { PostBuffer = n.GetTimeSpanValue(); } },
                {"preBuffer", n => { PreBuffer = n.GetTimeSpanValue(); } },
                {"price", n => { Price = n.GetDoubleValue(); } },
                {"priceType", n => { PriceType = n.GetEnumValue<BookingPriceType>(); } },
                {"reminders", n => { Reminders = n.GetCollectionOfObjectValues<BookingReminder>(BookingReminder.CreateFromDiscriminatorValue).ToList(); } },
                {"selfServiceAppointmentId", n => { SelfServiceAppointmentId = n.GetStringValue(); } },
                {"serviceId", n => { ServiceId = n.GetStringValue(); } },
                {"serviceLocation", n => { ServiceLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"serviceName", n => { ServiceName = n.GetStringValue(); } },
                {"serviceNotes", n => { ServiceNotes = n.GetStringValue(); } },
                {"smsNotificationsEnabled", n => { SmsNotificationsEnabled = n.GetBoolValue(); } },
                {"staffMemberIds", n => { StaffMemberIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"start", n => { Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("customerEmailAddress", CustomerEmailAddress);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteObjectValue<Location>("customerLocation", CustomerLocation);
            writer.WriteStringValue("customerName", CustomerName);
            writer.WriteStringValue("customerNotes", CustomerNotes);
            writer.WriteStringValue("customerPhone", CustomerPhone);
            writer.WriteCollectionOfObjectValues<BookingCustomerInformationBase>("customers", Customers);
            writer.WriteStringValue("customerTimeZone", CustomerTimeZone);
            writer.WriteTimeSpanValue("duration", Duration);
            writer.WriteObjectValue<DateTimeTimeZone>("end", End);
            writer.WriteIntValue("filledAttendeesCount", FilledAttendeesCount);
            writer.WriteDoubleValue("invoiceAmount", InvoiceAmount);
            writer.WriteObjectValue<DateTimeTimeZone>("invoiceDate", InvoiceDate);
            writer.WriteStringValue("invoiceId", InvoiceId);
            writer.WriteEnumValue<BookingInvoiceStatus>("invoiceStatus", InvoiceStatus);
            writer.WriteStringValue("invoiceUrl", InvoiceUrl);
            writer.WriteBoolValue("isLocationOnline", IsLocationOnline);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteIntValue("maximumAttendeesCount", MaximumAttendeesCount);
            writer.WriteStringValue("onlineMeetingUrl", OnlineMeetingUrl);
            writer.WriteBoolValue("optOutOfCustomerEmail", OptOutOfCustomerEmail);
            writer.WriteTimeSpanValue("postBuffer", PostBuffer);
            writer.WriteTimeSpanValue("preBuffer", PreBuffer);
            writer.WriteDoubleValue("price", Price);
            writer.WriteEnumValue<BookingPriceType>("priceType", PriceType);
            writer.WriteCollectionOfObjectValues<BookingReminder>("reminders", Reminders);
            writer.WriteStringValue("selfServiceAppointmentId", SelfServiceAppointmentId);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteObjectValue<Location>("serviceLocation", ServiceLocation);
            writer.WriteStringValue("serviceName", ServiceName);
            writer.WriteStringValue("serviceNotes", ServiceNotes);
            writer.WriteBoolValue("smsNotificationsEnabled", SmsNotificationsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("staffMemberIds", StaffMemberIds);
            writer.WriteObjectValue<DateTimeTimeZone>("start", Start);
        }
    }
}

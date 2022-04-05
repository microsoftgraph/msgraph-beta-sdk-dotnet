using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BookingAppointment : Entity, IParsable {
        /// <summary>Additional information that is sent to the customer when an appointment is confirmed.</summary>
        public string AdditionalInformation { get; set; }
        /// <summary>The SMTP address of the bookingCustomer who is booking the appointment.</summary>
        public string CustomerEmailAddress { get; set; }
        /// <summary>The ID of the bookingCustomer for this appointment. If no ID is specified when an appointment is created, then a new bookingCustomer object is created. Once set, you should consider the customerId immutable.</summary>
        public string CustomerId { get; set; }
        /// <summary>Represents location information for the bookingCustomer who is booking the appointment.</summary>
        public Location CustomerLocation { get; set; }
        /// <summary>The customer&apos;s name.</summary>
        public string CustomerName { get; set; }
        /// <summary>Notes from the customer associated with this appointment. You can get the value only when reading this bookingAppointment by its ID.  You can set this property only when initially creating an appointment with a new customer. After that point, the value is computed from the customer represented by customerId.</summary>
        public string CustomerNotes { get; set; }
        /// <summary>The customer&apos;s phone number.</summary>
        public string CustomerPhone { get; set; }
        /// <summary>It lists down the customer properties for an appointment. An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment. Optional.</summary>
        public List<BookingCustomerInformationBase> Customers { get; set; }
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
        public string CustomerTimeZone { get; set; }
        /// <summary>The length of the appointment, denoted in ISO8601 format.</summary>
        public TimeSpan? Duration { get; set; }
        /// <summary>The end property</summary>
        public DateTimeTimeZone End { get; set; }
        /// <summary>The current number of customers in the appointment</summary>
        public int? FilledAttendeesCount { get; set; }
        /// <summary>The billed amount on the invoice.</summary>
        public double? InvoiceAmount { get; set; }
        /// <summary>The date, time, and time zone of the invoice for this appointment.</summary>
        public DateTimeTimeZone InvoiceDate { get; set; }
        /// <summary>The ID of the invoice.</summary>
        public string InvoiceId { get; set; }
        /// <summary>The status of the invoice. Possible values are: draft, reviewing, open, canceled, paid, corrective.</summary>
        public BookingInvoiceStatus? InvoiceStatus { get; set; }
        /// <summary>The URL of the invoice in Microsoft Bookings.</summary>
        public string InvoiceUrl { get; set; }
        /// <summary>If true, indicates that the appointment will be held online. Default value is false.</summary>
        public bool? IsLocationOnline { get; set; }
        /// <summary>The URL of the online meeting for the appointment.</summary>
        public string JoinWebUrl { get; set; }
        /// <summary>The maximum number of customers allowed in an appointment. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment. To create a customer, use the Create bookingCustomer operation.</summary>
        public int? MaximumAttendeesCount { get; set; }
        /// <summary>The onlineMeetingUrl property</summary>
        public string OnlineMeetingUrl { get; set; }
        /// <summary>If true indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.</summary>
        public bool? OptOutOfCustomerEmail { get; set; }
        /// <summary>The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PostBuffer { get; set; }
        /// <summary>The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PreBuffer { get; set; }
        /// <summary>The regular price for an appointment for the specified bookingService.</summary>
        public double? Price { get; set; }
        /// <summary>A setting to provide flexibility for the pricing structure of services. Possible values are: undefined, fixedPrice, startingAt, hourly, free, priceVaries, callUs, notSet, unknownFutureValue.</summary>
        public BookingPriceType? PriceType { get; set; }
        /// <summary>The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
        public List<BookingReminder> Reminders { get; set; }
        /// <summary>An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer. Only supported for appointment if maxAttendeeCount is 1.</summary>
        public string SelfServiceAppointmentId { get; set; }
        /// <summary>The ID of the bookingService associated with this appointment.</summary>
        public string ServiceId { get; set; }
        /// <summary>The location where the service is delivered.</summary>
        public Location ServiceLocation { get; set; }
        /// <summary>The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.</summary>
        public string ServiceName { get; set; }
        /// <summary>Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
        public string ServiceNotes { get; set; }
        /// <summary>If true, indicates SMS notifications will be sent to the customers for the appointment. Default value is false.</summary>
        public bool? SmsNotificationsEnabled { get; set; }
        /// <summary>The ID of each bookingStaffMember who is scheduled in this appointment.</summary>
        public List<string> StaffMemberIds { get; set; }
        /// <summary>The start property</summary>
        public DateTimeTimeZone Start { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"additionalInformation", (o,n) => { (o as BookingAppointment).AdditionalInformation = n.GetStringValue(); } },
                {"customerEmailAddress", (o,n) => { (o as BookingAppointment).CustomerEmailAddress = n.GetStringValue(); } },
                {"customerId", (o,n) => { (o as BookingAppointment).CustomerId = n.GetStringValue(); } },
                {"customerLocation", (o,n) => { (o as BookingAppointment).CustomerLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"customerName", (o,n) => { (o as BookingAppointment).CustomerName = n.GetStringValue(); } },
                {"customerNotes", (o,n) => { (o as BookingAppointment).CustomerNotes = n.GetStringValue(); } },
                {"customerPhone", (o,n) => { (o as BookingAppointment).CustomerPhone = n.GetStringValue(); } },
                {"customers", (o,n) => { (o as BookingAppointment).Customers = n.GetCollectionOfObjectValues<BookingCustomerInformationBase>(BookingCustomerInformationBase.CreateFromDiscriminatorValue).ToList(); } },
                {"customerTimeZone", (o,n) => { (o as BookingAppointment).CustomerTimeZone = n.GetStringValue(); } },
                {"duration", (o,n) => { (o as BookingAppointment).Duration = n.GetTimeSpanValue(); } },
                {"end", (o,n) => { (o as BookingAppointment).End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"filledAttendeesCount", (o,n) => { (o as BookingAppointment).FilledAttendeesCount = n.GetIntValue(); } },
                {"invoiceAmount", (o,n) => { (o as BookingAppointment).InvoiceAmount = n.GetDoubleValue(); } },
                {"invoiceDate", (o,n) => { (o as BookingAppointment).InvoiceDate = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"invoiceId", (o,n) => { (o as BookingAppointment).InvoiceId = n.GetStringValue(); } },
                {"invoiceStatus", (o,n) => { (o as BookingAppointment).InvoiceStatus = n.GetEnumValue<BookingInvoiceStatus>(); } },
                {"invoiceUrl", (o,n) => { (o as BookingAppointment).InvoiceUrl = n.GetStringValue(); } },
                {"isLocationOnline", (o,n) => { (o as BookingAppointment).IsLocationOnline = n.GetBoolValue(); } },
                {"joinWebUrl", (o,n) => { (o as BookingAppointment).JoinWebUrl = n.GetStringValue(); } },
                {"maximumAttendeesCount", (o,n) => { (o as BookingAppointment).MaximumAttendeesCount = n.GetIntValue(); } },
                {"onlineMeetingUrl", (o,n) => { (o as BookingAppointment).OnlineMeetingUrl = n.GetStringValue(); } },
                {"optOutOfCustomerEmail", (o,n) => { (o as BookingAppointment).OptOutOfCustomerEmail = n.GetBoolValue(); } },
                {"postBuffer", (o,n) => { (o as BookingAppointment).PostBuffer = n.GetTimeSpanValue(); } },
                {"preBuffer", (o,n) => { (o as BookingAppointment).PreBuffer = n.GetTimeSpanValue(); } },
                {"price", (o,n) => { (o as BookingAppointment).Price = n.GetDoubleValue(); } },
                {"priceType", (o,n) => { (o as BookingAppointment).PriceType = n.GetEnumValue<BookingPriceType>(); } },
                {"reminders", (o,n) => { (o as BookingAppointment).Reminders = n.GetCollectionOfObjectValues<BookingReminder>(BookingReminder.CreateFromDiscriminatorValue).ToList(); } },
                {"selfServiceAppointmentId", (o,n) => { (o as BookingAppointment).SelfServiceAppointmentId = n.GetStringValue(); } },
                {"serviceId", (o,n) => { (o as BookingAppointment).ServiceId = n.GetStringValue(); } },
                {"serviceLocation", (o,n) => { (o as BookingAppointment).ServiceLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"serviceName", (o,n) => { (o as BookingAppointment).ServiceName = n.GetStringValue(); } },
                {"serviceNotes", (o,n) => { (o as BookingAppointment).ServiceNotes = n.GetStringValue(); } },
                {"smsNotificationsEnabled", (o,n) => { (o as BookingAppointment).SmsNotificationsEnabled = n.GetBoolValue(); } },
                {"staffMemberIds", (o,n) => { (o as BookingAppointment).StaffMemberIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"start", (o,n) => { (o as BookingAppointment).Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
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

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Globalization;

namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Implements DateTimeTimeZone Extensions
    /// </summary>

    public static class DateTimeTimeZoneExtensions
    {
        internal const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffffffK";

        /// <summary>
        /// Converts DateTimeTimeZone which is a Complex Type to DateTime
        /// </summary>
        /// <param name="dateTimeTimeZone"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this DateTimeTimeZone dateTimeTimeZone)
        {
            DateTime parsedDateTime = DateTime.ParseExact(dateTimeTimeZone.DateTime, DateTimeFormat, CultureInfo.InvariantCulture);

            // Now we need to determine which DateTimeKind to set based on the time zone specified in the input object.
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(dateTimeTimeZone.TimeZone);

            DateTimeKind kind;
            if(timeZoneInfo.StandardName == TimeZoneInfo.Utc.StandardName)
            {
                kind = DateTimeKind.Utc;
                // however, if the parsedDateTime.Kind is Local, we need to align to be utc too
                if (parsedDateTime.Kind == DateTimeKind.Local)
                {
                    parsedDateTime = parsedDateTime.ToUniversalTime();
                }
            }
            else if (timeZoneInfo.StandardName == TimeZoneInfo.Local.StandardName)
            {
                kind = DateTimeKind.Local;
                // however, if the parsedDateTime.Kind is UTC, we need to align it to be local too
                if (parsedDateTime.Kind == DateTimeKind.Utc)
                {
                    parsedDateTime = parsedDateTime.ToLocalTime();
                }
            }
            else
            {
                //if timeZoneInfo passed is not UTC or Local, then it is Unspecified
                //Infer from parsedDateTime.Kind rather than blindly set it to Unspecified
                kind = parsedDateTime.Kind;
            }
            return DateTime.SpecifyKind(parsedDateTime, kind);
        }

        /// <summary>
        /// Converts DateTimeTimeZone which is a Complex Type to DateTimeOffset
        /// </summary>
        /// <param name="dateTimeTimeZone"></param>
        /// <returns></returns>
        public static DateTimeOffset ToDateTimeOffset(this DateTimeTimeZone dateTimeTimeZone)
        {
            // The resulting DateTimeOffset will have the correct offset for the time zone specified in the input object.

            DateTime dateTime = DateTime.ParseExact(dateTimeTimeZone.DateTime, DateTimeFormat, CultureInfo.InvariantCulture);
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(dateTimeTimeZone.TimeZone);
            return dateTime.ToDateTimeOffset(timeZoneInfo);
        }

        internal static DateTimeOffset ToDateTimeOffset(this DateTime dateTime, TimeZoneInfo timeZoneInfo)
        {
            TimeSpan offset;
            if (timeZoneInfo.IsAmbiguousTime(dateTime))
            {
                // Ambiguous times happen when during backward transitions, such as the end of daylight saving time.
                // Since we were just told this time is ambiguous, there will always be exactly two offsets in the following array:
                TimeSpan[] offsets = timeZoneInfo.GetAmbiguousTimeOffsets(dateTime);

                // A reasonable common practice is to pick the first occurrence, which is always the largest offset in the array.
                // Ex: 2019-11-03T01:30:00 in the Pacific time zone occurs twice.  First at 1:30 PDT (-07:00), then an hour later
                //     at 1:30 PST (-08:00).  We choose PDT (-07:00) because it comes first sequentially.
                offset = TimeSpan.FromMinutes(Math.Max(offsets[0].TotalMinutes, offsets[1].TotalMinutes));
            }
            else if (timeZoneInfo.IsInvalidTime(dateTime))
            {
                // Invalid times happen during the gap created by a forward transition, such as the start of daylight saving time.
                // While they are not values that actually occur in correct local time, they are sometimes encountered
                // in scenarios such as a scheduled daily task.  In such cases, a reasonable common practice is to advance
                // to a valid local time by the amount of the transition gap (usually 1 hour).
                // Ex: 2019-03-10T02:30:00 does not exist in Pacific time.
                //     The local time went from 01:59:59 PST (-08:00) directly to 03:00:00 PDT (-07:00).
                //     We will advance by 1 hour to 03:30:00 which is in PDT (-07:00).

                // The gap is usually 1 hour, but not always - so it must be calculated
                TimeSpan earlierOffset = timeZoneInfo.GetUtcOffset(dateTime.AddDays(-1));
                TimeSpan laterOffset = timeZoneInfo.GetUtcOffset(dateTime.AddDays(1));
                TimeSpan gap = laterOffset - earlierOffset;

                dateTime = dateTime.Add(gap);
                offset = laterOffset;
            }
            else
            {
                dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
                offset = timeZoneInfo.GetUtcOffset(dateTime);
            }

            return new DateTimeOffset(dateTime, offset);
        }
        /// <summary>
        /// Converts the dateTime to a DateTimeTimeZone object
        /// <para>This method assumes the value is expressed on the same timezone as the target mailbox and the local machine</para>
        /// </summary>
        /// <param name="dateTime">>A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).</param>
        /// <returns></returns>
        public static DateTimeTimeZone ToDateTimeTimeZone(this DateTime dateTime)
        {
            return new DateTimeTimeZone
            {
                DateTime = dateTime.ToString(DateTimeFormat, CultureInfo.InvariantCulture),
                TimeZone = string.Empty
            };
        }
        /// <summary>
        /// Converts the dateTime to a DateTimeTimeZone object
        /// </summary>
        /// <param name="dateTime">>A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).</param>
        /// <param name="timeZoneInfo">The expected values for timeZone are specified here: https://docs.microsoft.com/en-us/graph/api/resources/datetimetimezone?view=graph-rest-1.0 </param>
        /// <returns></returns>
        public static DateTimeTimeZone ToDateTimeTimeZone(this DateTime dateTime, TimeZoneInfo timeZoneInfo)
        {
            return new DateTimeTimeZone
            {
                DateTime = dateTime.ToString(DateTimeFormat, CultureInfo.InvariantCulture),
                TimeZone = timeZoneInfo.Id
            };
        }

        public static DateTimeTimeZone ToDateTimeTimeZone(this DateTime dateTime, string timeZone)
        {
            return new DateTimeTimeZone
            {
                DateTime = dateTime.ToString(DateTimeFormat, CultureInfo.InvariantCulture),
                TimeZone = timeZone
            };
        }

        /// <summary>
        /// Converts the dateTimeOffset to a DateTimeTimeZone object
        /// <para>This method assumes the value is expressed on the same timezone as the target mailbox and the local machine</para>
        /// </summary>
        /// <param name="dateTimeOffset">>A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).</param>
        /// <returns></returns>
        public static DateTimeTimeZone ToDateTimeTimeZone(this DateTimeOffset dateTimeOffset)
        {
            return new DateTimeTimeZone
            {
                DateTime = dateTimeOffset.ToString(DateTimeFormat, CultureInfo.InvariantCulture),
                TimeZone = string.Empty
            };
        }
        /// <summary>
        /// Converts the dateTimeOffset to a DateTimeTimeZone object
        /// </summary>
        /// <param name="dateTimeOffset">>A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).</param>
        /// <param name="timeZone">The expected values for timeZone are specified here: https://docs.microsoft.com/en-us/graph/api/resources/datetimetimezone?view=graph-rest-1.0 </param>
        /// <returns></returns>
        public static DateTimeTimeZone ToDateTimeTimeZone(this DateTimeOffset dateTimeOffset, string timeZone)
        {
            return new DateTimeTimeZone
            {
                DateTime = dateTimeOffset.ToString(DateTimeFormat, CultureInfo.InvariantCulture),
                TimeZone = timeZone
            };
        }
        /// <summary>
        /// Converts the dateTimeOffset to a DateTimeTimeZone object
        /// </summary>
        /// <param name="dateTimeOffset">>A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).</param>
        /// <param name="timeZoneInfo">The expected values for timeZone are specified here: https://docs.microsoft.com/en-us/graph/api/resources/datetimetimezone?view=graph-rest-1.0 </param>
        /// <returns></returns>
        public static DateTimeTimeZone ToDateTimeTimeZone(this DateTimeOffset dateTimeOffset, TimeZoneInfo timeZoneInfo)
        {
            return new DateTimeTimeZone
            {
                DateTime = dateTimeOffset.ToString(DateTimeFormat, CultureInfo.InvariantCulture),
                TimeZone = timeZoneInfo.Id
            };
        }

    }
}

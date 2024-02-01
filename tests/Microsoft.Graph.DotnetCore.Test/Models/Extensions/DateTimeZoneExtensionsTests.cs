using Microsoft.Graph.Beta.Models;
using System;
using Xunit;
using System.Globalization;
using System.Collections.Generic;

namespace Microsoft.Graph.DotnetCore.Test.Extensions
{
    public class DateTimeZoneExtensionsTests
    {
        internal const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffffffK";

        [Fact]
        public void ToDateTime_Should_Correctly_Convert_DateTimeString_To_UTCDateTimeObject()
        {
            var dateTimeString = "2019-01-25T06:37:39.8058788Z";
            var expectedDateTime = DateTime.ParseExact(dateTimeString , DateTimeFormat, CultureInfo.InvariantCulture).ToUniversalTime();

            DateTimeTimeZone dateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = "UTC",
                DateTime = dateTimeString
            };

            var actualDateTime = dateTimeTimeZone.ToDateTime();

            Assert.Equal(expectedDateTime, actualDateTime);
            Assert.Equal(expectedDateTime.Kind, actualDateTime.Kind);
            Assert.Equal(DateTimeKind.Utc, actualDateTime.Kind);

            //scenario where the dateTime is not in UTC
            dateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = "UTC",
                DateTime = "2019-01-25T06:37:39.8058788"
            };
            actualDateTime = dateTimeTimeZone.ToDateTime();
            Assert.Equal(expectedDateTime, actualDateTime);
            Assert.Equal(expectedDateTime.Kind, actualDateTime.Kind);
            Assert.Equal(DateTimeKind.Utc, actualDateTime.Kind);
        }

        [Fact]
        public void ToDateTime_Should_Correctly_Convert_DateTimeString_To_Local_DateTimeObject_Correctly()
        {
            var localDateTime = DateTime.Now;
            var localDateTimeString = localDateTime.ToString(DateTimeFormat, CultureInfo.InvariantCulture);
            DateTimeTimeZone dateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = TimeZoneInfo.Local.Id,
                DateTime = localDateTimeString
            };

            var actualDateTime = dateTimeTimeZone.ToDateTime().ToLocalTime();
            var expectedDateTime = localDateTime;

            Assert.Equal(expectedDateTime, actualDateTime);
            Assert.Equal(expectedDateTime.Kind, actualDateTime.Kind);
        }

        [Fact]
        public void ToDateTime_Should_Correctly_Convert_DateTimeString_To_Local_No_timezone_offset_provided()
        {
            var localDateTime = DateTime.Now;
            var localDateTimeString = localDateTime.ToString("yyyy-MM-ddTHH:mm:ss.fffffff", CultureInfo.InvariantCulture);
            DateTimeTimeZone dateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = TimeZoneInfo.Local.Id,
                DateTime = localDateTimeString
            };

            var actualDateTime = dateTimeTimeZone.ToDateTime().ToLocalTime();
            var expectedDateTime = localDateTime;
            Assert.Equal(expectedDateTime, actualDateTime);
            Assert.Equal(expectedDateTime.Kind, actualDateTime.Kind);
        }

        [Fact]
        public void ToDateTime_Should_Correctly_Convert_DateTimeString_To_UnspecifiedDateTimeObject()
        {
            DateTimeTimeZone dateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = "Asia/Jerusalem",
                DateTime = "2019-01-25T06:37:39.8058788Z"
            };

            var actualDateTime = dateTimeTimeZone.ToDateTime();
            var expectedDateTime = DateTime.ParseExact(dateTimeTimeZone.DateTime, DateTimeFormat, CultureInfo.InvariantCulture).ToUniversalTime();

            Assert.Equal(expectedDateTime, actualDateTime.ToUniversalTime());

            //scenario where the dateTime is Local but the timezone is unspecified
            expectedDateTime = DateTime.Now;
            var dateTimeString = expectedDateTime.ToString(DateTimeFormat, CultureInfo.InvariantCulture);
            dateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = "Asia/Jerusalem",
                DateTime = dateTimeString
            };
            actualDateTime = dateTimeTimeZone.ToDateTime();
            Assert.Equal(expectedDateTime, actualDateTime.ToLocalTime());

            //scenario where the dateTime has no timezone offset and timezone is unspecified
            dateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = "Asia/Jerusalem",
                DateTime = "2024-01-16T08:30:00.0000000"
            };

            actualDateTime = dateTimeTimeZone.ToDateTime();
            expectedDateTime = new DateTime(2024, 1, 16, 08, 30, 0, DateTimeKind.Unspecified);
            Assert.Equal(expectedDateTime, actualDateTime);
            Assert.Equal(DateTimeKind.Unspecified, actualDateTime.Kind);
        }

        [Fact]
        public void ToDateTimeOffset_Should_Convert_DateTimeTimeZone_To_DateTimeOffset()
        {
            DateTimeTimeZone dateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = "UTC",
                DateTime = "2019-01-25T06:37:39.8058788Z"
            };

            DateTime dateTime = DateTime.ParseExact(dateTimeTimeZone.DateTime, DateTimeFormat, CultureInfo.InvariantCulture);
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(dateTimeTimeZone.TimeZone);
            TimeSpan offset = timeZoneInfo.GetUtcOffset(dateTime);
            dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);

            var expectedDateTimeOffset = new DateTimeOffset(dateTime, offset);
            var actualDateTimeOffset = dateTimeTimeZone.ToDateTimeOffset();

            Assert.Equal(expectedDateTimeOffset, actualDateTimeOffset);
        }

        [Fact]
        public void ToDateTimeOffset_Should_Convert_DateTimeTimeZone_To_DateTimeOffset_With_Non_UTC()
        {
            DateTimeTimeZone dateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = "Eastern Standard Time",
                DateTime = "2019-01-25T06:37:39.8058788"
            };

            DateTime dateTime = DateTime.ParseExact(dateTimeTimeZone.DateTime, DateTimeFormat, CultureInfo.InvariantCulture);
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(dateTimeTimeZone.TimeZone);
            TimeSpan offset = timeZoneInfo.GetUtcOffset(dateTime);
            dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);

            var expectedDateTimeOffset = new DateTimeOffset(dateTime, offset);
            var actualDateTimeOffset = dateTimeTimeZone.ToDateTimeOffset();

            Assert.Equal(expectedDateTimeOffset, actualDateTimeOffset);
        }

        [Fact]
        public void FromDateTime_Should_Convert_DateTime_To_DateTimeTimeZone()
        {
            DateTimeStyles dateTimeStyles = DateTimeStyles.RoundtripKind;
            var dateTime = DateTime.ParseExact("2019-01-25T06:37:39.8058788Z", DateTimeFormat, CultureInfo.InvariantCulture, dateTimeStyles);
            var expectedDateTime = dateTime.ToString(DateTimeFormat, CultureInfo.InvariantCulture);

            DateTimeTimeZone expectedDateTimeTimeZone = new DateTimeTimeZone
            {
                TimeZone = "UTC",
                DateTime = expectedDateTime
            };

            var actualDateTimeTimeZone = dateTime.ToDateTimeTimeZone("UTC");

            Assert.Equal(expectedDateTimeTimeZone.DateTime, actualDateTimeTimeZone.DateTime);
            Assert.Equal(expectedDateTimeTimeZone.TimeZone, actualDateTimeTimeZone.TimeZone);
        }

        [Fact]
        public void FromDateTimeOffset_Should_Convert_DateTimeOffset_To_DateTimeTimeZone()
        {
            List<DateTimeTimeZone> dateTimeTimeZoneList = new List<DateTimeTimeZone>();
            DateTimeTimeZone dateTimeTimeZoneTestOne = new DateTimeTimeZone
            {
                TimeZone = "Eastern Standard Time",
                DateTime = "2019-06-03T14:00:00.0000000"
            };
            dateTimeTimeZoneList.Add(dateTimeTimeZoneTestOne);

            DateTimeTimeZone dateTimeTimeZoneTestTwo = new DateTimeTimeZone
            {
                TimeZone = "UTC",
                DateTime = "2019-01-25T06:37:39.8058788Z"
            };
            dateTimeTimeZoneList.Add(dateTimeTimeZoneTestTwo);

            DateTimeTimeZone dateTimeTimeZoneTestThree = new DateTimeTimeZone
            {
                TimeZone = "Mauritius Standard Time",
                DateTime = "2019-06-03T22:00:00.0000000"
            };
            dateTimeTimeZoneList.Add(dateTimeTimeZoneTestThree);

            foreach (var dateTimeTimeZone in dateTimeTimeZoneList)
            {
                DateTime dateTime = GetDateTimeFromDateTimeTimeZone(dateTimeTimeZone);
                TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(dateTimeTimeZone.TimeZone);

                TimeSpan offset = timeZoneInfo.GetUtcOffset(dateTime);
                dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);

                var expectedDateTimeOffset = new DateTimeOffset(dateTime, offset);
                expectedDateTimeOffset = TimeZoneInfo.ConvertTime(expectedDateTimeOffset, timeZoneInfo);
                var actualDateTimeTimeZone = expectedDateTimeOffset.ToDateTimeTimeZone(dateTimeTimeZone.TimeZone);

                Assert.Equal(expectedDateTimeOffset.ToString(DateTimeFormat, CultureInfo.InvariantCulture), actualDateTimeTimeZone.DateTime);
                Assert.Equal(timeZoneInfo.Id, actualDateTimeTimeZone.TimeZone);
            }
        }

        [Fact]
        public void FromDateTimeOffset_Should_Convert_DateTimeOffset_To_DateTimeTimeZone_DefaultParameter()
        {
            List<DateTimeTimeZone> dateTimeTimeZoneList = new List<DateTimeTimeZone>();
            DateTimeTimeZone dateTimeTimeZoneTestOne = new DateTimeTimeZone
            {
                TimeZone = "Eastern Standard Time",
                DateTime = "2019-06-03T14:00:00.0000000"
            };
            dateTimeTimeZoneList.Add(dateTimeTimeZoneTestOne);

            DateTimeTimeZone dateTimeTimeZoneTestTwo = new DateTimeTimeZone
            {
                TimeZone = "UTC",
                DateTime = "2019-01-25T06:37:39.8058788Z"
            };
            dateTimeTimeZoneList.Add(dateTimeTimeZoneTestTwo);

            DateTimeTimeZone dateTimeTimeZoneTestThree = new DateTimeTimeZone
            {
                TimeZone = "Mauritius Standard Time",
                DateTime = "2019-06-03T22:00:00.0000000"
            };
            dateTimeTimeZoneList.Add(dateTimeTimeZoneTestThree);

            foreach (var dateTimeTimeZone in dateTimeTimeZoneList)
            {
                DateTime dateTime = GetDateTimeFromDateTimeTimeZone(dateTimeTimeZone);
                TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(dateTimeTimeZone.TimeZone);

                TimeSpan offset = timeZoneInfo.GetUtcOffset(dateTime);
                dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);

                var expectedDateTimeOffset = new DateTimeOffset(dateTime, offset);
                expectedDateTimeOffset = TimeZoneInfo.ConvertTime(expectedDateTimeOffset, timeZoneInfo);
                var actualDateTimeTimeZone = expectedDateTimeOffset.ToDateTimeTimeZone();

                Assert.Equal(expectedDateTimeOffset.ToString(DateTimeFormat, CultureInfo.InvariantCulture), actualDateTimeTimeZone.DateTime);
                Assert.Empty(actualDateTimeTimeZone.TimeZone);
            }
        }

        private DateTime GetDateTimeFromDateTimeTimeZone(DateTimeTimeZone dateTimeTimeZone)
        {
            DateTime dateTime = DateTime.ParseExact(dateTimeTimeZone.DateTime, DateTimeFormat, CultureInfo.InvariantCulture);
            return dateTime;
        }
    }
}

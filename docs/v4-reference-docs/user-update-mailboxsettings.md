---
title: "Update user mailbox settings"
description: "Update one or more settings for the user's mailbox. This includes settings for automatic replies (notify people automatically upon receipt of their email), locale (language and country/region), time zone, and working hours."
ms.localizationpriority: medium
author: "abheek-das"
ms.prod: "outlook"
doc_type: apiPageType
---

# Update user mailbox settings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Enable, configure, or disable one or more of the following settings as part of a user's [mailboxSettings](../resources/mailboxsettings.md):

- [automatic replies](../resources/automaticrepliessetting.md) (notify people automatically upon receipt of their email)
- dateFormat
- delegateMeetingMessageDeliveryOptions
- [locale](../resources/localeinfo.md) (language and country/region)
- timeFormat
- time zone
- [working hours](../resources/workinghours.md)

When updating the preferred date or time format for a user, specify it in respectively, the [short date](/dotnet/standard/base-types/standard-date-and-time-format-strings#ShortDate) or [short time](/dotnet/standard/base-types/standard-date-and-time-format-strings#ShortTime) format. 

When updating the preferred time zone for a user, specify it in the Windows or [Internet Assigned Numbers Authority (IANA) time zone](https://www.iana.org/time-zones) (also known as Olson time zone) format. You can also further customize the time zone as shown in [example 2](#example-2) below.

> [!TIP] 
> You cannot create or delete any mailbox settings.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | MailboxSettings.ReadWrite    |
|Delegated (personal Microsoft account) | MailboxSettings.ReadWrite    |
|Application | MailboxSettings.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /me/mailboxSettings
PATCH /users/{id|userPrincipalName}/mailboxSettings
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.
## Request headers
| Name       | Type | Description|
|:-----------|:------|:----------|
| Authorization  | string  | Bearer {token}. Required. |

## Request body
In the request body, supply the values for the relevant properties that should be updated. Existing properties that are not included in the 
request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you 
shouldn't include existing values that haven't changed. The following are the writable/updatable properties:

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|automaticRepliesSetting|[automaticRepliesSetting](../resources/automaticrepliessetting.md)|Configuration settings to automatically notify the sender of an incoming email with a message from the signed-in user. You can set such notifications for only a future date range.|
|dateFormat|string|The date format for the user's mailbox.|
|delegateMeetingMessageDeliveryOptions|delegateMeetingMessageDeliveryOptions| If the user has a calendar delegate, this specifies whether the delegate, mailbox owner, or both receive meeting messages and meeting responses. Possible values are: `sendToDelegateAndInformationToPrincipal`, `sendToDelegateAndPrincipal`, `sendToDelegateOnly`.|
|language|[localeInfo](../resources/localeinfo.md)|The locale information for the user, including the preferred language and country/region.|
|timeFormat|string|The time format for the user's mailbox.|
|timeZone|string|The default time zone for the user's mailbox.|
|workingHours|[workingHours](../resources/workinghours.md)|The hours, days of a week, and time zone that the user works.|

## Response

If successful, this method returns a `200 OK` response code and the updated properties of a [mailboxSettings](../resources/mailboxsettings.md) object in the response body.

## Errors

Setting working hours with inappropriate values may return the following errors.

| Scenario   | HTTP status code | Error code | Error message |
|:-----------|:------|:----------|:----------|
| Invalid **startTime** or **endTime** | 400 | RequestBodyRead | Cannot convert the literal '08' to the expected type 'Edm.TimeOfDay'.|
| Start time is greater than end time | 400 | ErrorInvalidTimeSettings | Start Time should occur before End Time. |
| Invalid day in **daysOfWeek** | 400 | InvalidArguments | Requested value 'RandomDay' was not found.|
| Invalid **timeZone** | 400 | InvalidTimeZone | Time Zone settings provided are invalid.|


## Examples
### Example 1
#### Request 
The first example enables automatic replies for a date range, by setting the following properties of the **automaticRepliesSetting** property:
**status**, **scheduledStartDateTime** and **scheduledEndDateTime**.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_mailboxsettings_1"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/mailboxSettings
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Me/mailboxSettings",
    "automaticRepliesSetting": {
        "status": "Scheduled",
        "scheduledStartDateTime": {
          "dateTime": "2016-03-20T18:00:00.0000000",
          "timeZone": "UTC"
        },
        "scheduledEndDateTime": {
          "dateTime": "2016-03-28T18:00:00.0000000",
          "timeZone": "UTC"
        }
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var mailboxSettings = new MailboxSettings
{
	AutomaticRepliesSetting = new AutomaticRepliesSetting
	{
		Status = AutomaticRepliesStatus.Scheduled,
		ScheduledStartDateTime = new DateTimeTimeZone
		{
			DateTime = "2016-03-20T18:00:00",
			TimeZone = "UTC"
		},
		ScheduledEndDateTime = new DateTimeTimeZone
		{
			DateTime = "2016-03-28T18:00:00",
			TimeZone = "UTC"
		}
	},
	AdditionalData = new Dictionary<string, object>()
	{
		{"@odata.context", "https://graph.microsoft.com/beta/$metadata#Me/mailboxSettings"}
	}
};

var me = new User();
me.MailboxSettings = mailboxSettings;

await graphClient.Me
	.Request()
	.UpdateAsync(me);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The response includes the updated settings for automatic replies. Note: The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "name": "update_mailboxsettings_1",
  "truncated": true,
  "@odata.type": "microsoft.graph.mailboxSettings"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Me/mailboxSettings",
    "automaticRepliesSetting": {
        "status": "scheduled",
        "externalAudience": "all",
        "scheduledStartDateTime": {
            "dateTime": "2016-03-20T02:00:00.0000000",
            "timeZone": "UTC"
        },
        "scheduledEndDateTime": {
            "dateTime": "2016-03-28T02:00:00.0000000",
            "timeZone": "UTC"
        },
    "internalReplyMessage": "<html>\n<body>\n<p>I'm at our company's worldwide reunion and will respond to your message as soon as I return.<br>\n</p></body>\n</html>\n",
    "externalReplyMessage": "<html>\n<body>\n<p>I'm at the Contoso worldwide reunion and will respond to your message as soon as I return.<br>\n</p></body>\n</html>\n"
    }
}
```

### Example 2
#### Request
The second example customizes the time zone for the working hours of the signed-in user, by setting the **timeZone** property 
to a [custom time zone](../resources/customtimezone.md).


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_mailboxsettings_2"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/mailboxSettings
Content-Type: application/json

{
  "workingHours": {
      "endTime" : "18:30:00.0000000", 
      "daysOfWeek": [ 
          "Monday", 
          "Tuesday", 
          "Wednesday", 
          "Thursday", 
          "Friday", 
          "Saturday" 
      ], 
      "timeZone" : { 
         "@odata.type": "#microsoft.graph.customTimeZone", 
         "bias":-300, 
         "name": "Customized Time Zone",
         "standardOffset":{   
           "time":"02:00:00.0000000", 
           "dayOccurrence":2, 
           "dayOfWeek":"Sunday", 
           "month":10, 
           "year":0 
         }, 
         "daylightOffset":{   
           "daylightBias":100, 
           "time":"02:00:00.0000000", 
           "dayOccurrence":4, 
           "dayOfWeek":"Sunday", 
           "month":5, 
           "year":0 
         } 
      } 
  }
} 
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var mailboxSettings = new MailboxSettings
{
	WorkingHours = new WorkingHours
	{
		EndTime = new TimeOfDay(18, 30, 0),
		DaysOfWeek = new List<DayOfWeek>()
		{
			DayOfWeek.Monday,
			DayOfWeek.Tuesday,
			DayOfWeek.Wednesday,
			DayOfWeek.Thursday,
			DayOfWeek.Friday,
			DayOfWeek.Saturday
		},
		TimeZone = new CustomTimeZone
		{
			Bias = -300,
			Name = "Customized Time Zone",
			StandardOffset = new StandardTimeZoneOffset
			{
				Time = new TimeOfDay(2, 0, 0),
				DayOccurrence = 2,
				DayOfWeek = DayOfWeek.Sunday,
				Month = 10,
				Year = 0
			},
			DaylightOffset = new DaylightTimeZoneOffset
			{
				DaylightBias = 100,
				Time = new TimeOfDay(2, 0, 0),
				DayOccurrence = 4,
				DayOfWeek = DayOfWeek.Sunday,
				Month = 5,
				Year = 0
			}
		}
	}
};

var me = new User();
me.MailboxSettings = mailboxSettings;

await graphClient.Me
	.Request()
	.UpdateAsync(me);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
Here is an example of the response. Note: The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "name": "update_mailboxsettings_2",
  "truncated": true,
  "@odata.type": "microsoft.graph.mailboxSettings"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context":"https://graph.microsoft.com/beta/$metadata#users('94447c6e-ea4c-494c-a9ed-d905e366c5cb')/mailboxSettings",
    "workingHours":{
        "daysOfWeek":[
            "monday",
            "tuesday",
            "wednesday",
            "thursday",
            "friday",
            "saturday"
        ],
        "startTime":"09:00:00.0000000",
        "endTime":"18:30:00.0000000",
        "timeZone":{
            "@odata.type":"#microsoft.graph.customTimeZone",
            "bias":-200,
            "name":"Customized Time Zone",
            "standardOffset":{
                "time":"02:00:00.0000000",
                "dayOccurrence":4,
                "dayOfWeek":"sunday",
                "month":5,
                "year":0
            },
            "daylightOffset":{
                "daylightBias":-100,
                "time":"02:00:00.0000000",
                "dayOccurrence":2,
                "dayOfWeek":"sunday",
                "month":10,
                "year":0
            }
        }
    }
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Update mailbox settings",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->

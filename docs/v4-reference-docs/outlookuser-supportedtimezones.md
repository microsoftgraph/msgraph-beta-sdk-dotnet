---
title: "outlookUser: supportedTimeZones"
description: "Get the list of time zones that are supported for the user, as configured on the user's mailbox server."
ms.localizationpriority: medium
author: "abheek-das"
ms.prod: "outlook"
doc_type: apiPageType
---

# outlookUser: supportedTimeZones

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the list of time zones that are supported for the user, as configured on the user's mailbox server.

You can explicitly specify to have time zones returned in the Windows time zone format or  [Internet Assigned Numbers Authority (IANA) time zone](https://www.iana.org/time-zones) 
(also known as Olson time zone) format. The Windows format is the default.

When setting up an Outlook client, the user selects the preferred time zone from this supported list. You can subsequently get the preferred time zone by 
[getting the user's mailbox settings](user-get-mailboxsettings.md).


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.Read, User.ReadBasic.All    |
|Delegated (personal Microsoft account) | User.Read    |
|Application | User.Read.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /me/outlook/supportedTimeZones
GET /users/{id|userPrincipalName}/outlook/supportedTimeZones

GET /me/outlook/supportedTimeZones(TimeZoneStandard=microsoft.graph.timeZoneStandard'{timezone_format}')
GET /users/{id|userPrincipalName}/outlook/supportedTimeZones(TimeZoneStandard=microsoft.graph.timeZoneStandard'{timezone_format}')
```

## Function parameters
| Parameter      | Type    | Description|
|:---------------|:--------|:----------|
| TimeZoneStandard  | String  | A time zone format. Supported values are: `Windows`, and `Iana`. Optional. |

## Request headers
| Name       | Type | Description|
|:---------------|:--------|:----------|
| Authorization  | string  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns `200 OK` response code and a collection of [timeZoneInformation](../resources/timezoneinformation.md) objects in the response body.

## Example

##### Request 1
The following example does not specify the `timeZoneStandard` parameter, and gets the list of supported time zones represented in the Windows time zone format. 

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_supportedtimezones_default"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/outlook/supportedTimeZones
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var supportedTimeZones = await graphClient.Me.Outlook
	.SupportedTimeZones()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_supportedtimezones_iana"
} -->

```msgraph-interactive
GET https://graph.microsoft.com/beta/me/outlook/supportedTimeZones(TimeZoneStandard=microsoft.graph.timeZoneStandard'Iana')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var supportedTimeZones = await graphClient.Me.Outlook
	.SupportedTimeZones(TimeZoneStandard.Iana)
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).


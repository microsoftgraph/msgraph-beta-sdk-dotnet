---
title: "channel: doesUserHaveAccess"
description: "Determine whether a user has access to a shared channel."
author: "devjha-ms"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# channel: doesUserHaveAccess
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Determine whether a [user](../resources/useridentity.md) has access to a shared [channel](../resources/channel.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account) | ChannelMember.Read.All, ChannelMember.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | ChannelMember.Read.All, ChannelMember.ReadWrite.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /teams/{team-id}/channels/{channel-id}/doesUserHaveAccess
```

## Function parameters
In the request URL, provide the following query parameters with values.
The following table shows the parameters that can be used with this function.

|Parameter|Type|Description|
|:---|:---|:---|
|tenantId|String|The ID of the Azure Active Directory tenant that the [user](../resources/useridentity.md) belongs to. The default value for this property is the current **tenantId** of the signed-in user or app.|
|userId|String|Unique identifier for the [user](../resources/useridentity.md). Either specify the **userId** or the **userPrincipalName** property in the request.|
|userPrincipalName|String|The user principal name (UPN) of the [user](../resources/useridentity.md). Either specify the **userId** or the **userPrincipalName** property in the request.|


## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this function.

## Response

If successful, this function returns a `200 OK` response code and a Boolean in the response body.

## Examples

### Example 1: Check access for an internal user

The following is an example of a request that checks whether an internal user has access to a shared channel.

#### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "channel_doesuserhaveaccess",
  "sampleKeys": ["19:33b76eea88574bd1969dca37e2b7a819@thread.skype", "0fddfdc5-f319-491f-a514-be1bc1bf9ddc", "6285581f-484b-4845-9e01-60667f8b12ae"]
}
-->
``` http
GET https://graph.microsoft.com/beta/teams/0fddfdc5-f319-491f-a514-be1bc1bf9ddc/channels/19:33b76eea88574bd1969dca37e2b7a819@thread.skype/doesUserHaveAccess(userId='6285581f-484b-4845-9e01-60667f8b12ae')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var boolean = await graphClient.Teams["{team-id}"].Channels["{channel-id}"]
	.DoesUserHaveAccess("6285581f-484b-4845-9e01-60667f8b12ae")
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "@odata.type": "string"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": true
}
```


### Example 2: Check access for an external user

The following is an example of a request that uses the **tenantId** property to check whether an external user has access to a shared channel.

#### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "channel_doesuserhaveaccess_externaluser",
  "sampleKeys": ["19:33b76eea88574bd1969dca37e2b7a819@thread.skype", "0fddfdc5-f319-491f-a514-be1bc1bf9ddc", "62855810-484b-4823-9e01-60667f8b12ae", "57fb72d0-d811-46f4-8947-305e6072eaa5"]
}
-->
``` http
GET https://graph.microsoft.com/beta/teams/0fddfdc5-f319-491f-a514-be1bc1bf9ddc/channels/19:33b76eea88574bd1969dca37e2b7a819@thread.skype/doesUserHaveAccess(userId='62855810-484b-4823-9e01-60667f8b12ae', tenantId='57fb72d0-d811-46f4-8947-305e6072eaa5')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var boolean = await graphClient.Teams["{team-id}"].Channels["{channel-id}"]
	.DoesUserHaveAccess("62855810-484b-4823-9e01-60667f8b12ae","57fb72d0-d811-46f4-8947-305e6072eaa5")
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "@odata.type": "string"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": true
}
```


### Example 3: Check user access for a user using the user principal name

The following is an example of a request that uses the **userPrincipalName** property to check whether an internal user has access to a shared channel.

#### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "channel_doesuserhaveaccess_usingupn",
  "sampleKeys": ["19:33b76eea88574bd1969dca37e2b7a819@thread.skype", "0fddfdc5-f319-491f-a514-be1bc1bf9ddc", "john.doe@contoso.com"]
}
-->
``` http
GET https://graph.microsoft.com/beta/teams/0fddfdc5-f319-491f-a514-be1bc1bf9ddc/channels/19:33b76eea88574bd1969dca37e2b7a819@thread.skype/doesUserHaveAccess(userPrincipalName='john.doe@contoso.com')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var boolean = await graphClient.Teams["{team-id}"].Channels["{channel-id}"]
	.DoesUserHaveAccess("john.doe@contoso.com")
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "@odata.type": "string"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": false
}
```


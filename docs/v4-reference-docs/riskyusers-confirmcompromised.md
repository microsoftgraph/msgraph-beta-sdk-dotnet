---
title: Confirm riskyUser compromised
description: Confirm a riskyUser object as compromised.
author: tracyshi
ms.localizationpriority: medium
ms.prod: identity-and-sign-in
doc_type: apiPageType
---
# riskyUser: confirmCompromised

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>**Note:** The riskyUsers API requires an Azure AD Premium P2 license.

Confirm one or more [riskyUser](../resources/riskyuser.md) objects as compromised. This action sets the targeted user's risk level to high.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | IdentityRiskyUser.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | IdentityRiskyUser.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /riskyUsers/confirmCompromised
```


## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
Specify the risky user IDs to dismiss in the request body.

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.
## Examples
<!--### Example 1: Confirm users as compromised-->
### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "confirm_riskyuser_1"
}-->
```http
POST https://graph.microsoft.com/beta/riskyUsers/confirmCompromised
Content-type: application/json

{
  "userIds": [
    "29f270bb-4d23-4f68-8a57-dc73dc0d4caf",
    "20f91ec9-d140-4d90-9cd9-f618587a1471"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userIds = new List<String>()
{
	"29f270bb-4d23-4f68-8a57-dc73dc0d4caf",
	"20f91ec9-d140-4d90-9cd9-f618587a1471"
};

await graphClient.RiskyUsers
	.ConfirmCompromised(userIds)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
<!-- {
  "blockType": "response",
  "truncated": true
} -->
```http
HTTP/1.1 204 No Content
```

<!--
### Example 2: Confirm a user as compromised
#### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "confirm_riskyuser_2"
}-->
<!--```http
POST https://graph.microsoft.com/beta/identityProtection/riskyUsers/confirmCompromised
Content-type: application/json

{
  "userIds": [
    "29f270bb-4d23-4f68-8a57-dc73dc0d4caf"
  ]
}
```
# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userIds = new List<String>()
{
	"29f270bb-4d23-4f68-8a57-dc73dc0d4caf"
};

await graphClient.IdentityProtection.RiskyUsers
	.ConfirmCompromised(userIds)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
Here is an example of the response.
<!-- {
  "blockType": "response",
  "truncated": true
} -->
<!--```http
HTTP/1.1 204 No Content
```
<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Confirm compromised riskyUsers",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}-->

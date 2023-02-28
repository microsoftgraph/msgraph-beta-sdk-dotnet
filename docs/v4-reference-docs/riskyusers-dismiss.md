---
title: Dismiss riskyUser
description: Dismiss the risk of a riskyUser object.
author: tracyshi
ms.localizationpriority: medium
ms.prod: identity-and-sign-in
doc_type: apiPageType
---

# riskyUser: dismiss

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>**Note:** Using the riskyUsers API requires an Azure AD Premium P2 license.

Dismiss the risk of one or more [riskyUser](../resources/riskyuser.md) objects. This action sets the targeted user's risk level to none. The maximum count of users to dismiss in one call is 60.

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
POST /riskyUsers/dismiss
```


## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
Specify the userIds to dismiss in the request body.

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.
## Examples
<!--### Example 1: Dismiss risky users-->
### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "dismiss_riskyuser_1"
}-->
```http
POST https://graph.microsoft.com/beta/riskyUsers/dismiss
Content-Type: application/json

{
  "userIds": [
    "04487ee0-f4f6-4e7f-8999-facc5a30e232",
    "13387ee0-f4f6-4e7f-8999-facc5120e345"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userIds = new List<String>()
{
	"04487ee0-f4f6-4e7f-8999-facc5a30e232",
	"13387ee0-f4f6-4e7f-8999-facc5120e345"
};

await graphClient.RiskyUsers
	.Dismiss(userIds)
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
### Example 2: Dismiss a risky user
#### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "dismiss_riskyuser_2"
}-->
<!--```http
POST https://graph.microsoft.com/beta/identityProtection/riskyUsers/dismiss
Content-Type: application/json

{
  "userIds": [
    "04487ee0-f4f6-4e7f-8999-facc5a30e232"
  ]
}
```
# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userIds = new List<String>()
{
	"04487ee0-f4f6-4e7f-8999-facc5a30e232"
};

await graphClient.IdentityProtection.RiskyUsers
	.Dismiss(userIds)
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
  "description": "Dismiss riskyUsers",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}-->


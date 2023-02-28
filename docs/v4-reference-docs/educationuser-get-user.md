---
title: "Get user"
description: "Retrieve the simple directory **user** that corresponds to this **educationUser**."
ms.localizationpriority: medium
author: "mmast-msft"
ms.prod: "education"
doc_type: apiPageType
---

# Get user

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the simple directory **user** that corresponds to this **educationUser**.

> [!NOTE]
> If the delegated token is used, members can only see information about their own account. Use the `beta/education/me/users` resource in this case.

## Permissions

A combination of permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                                                               |
| :------------------------------------- | :-------------------------------------------------------------------------------------------------------- |
| Delegated (work or school account)     | One from EduRoster.ReadBasic, EduRoster.Read, EduRoster.Write plus either Directory.Read.All or User.Read |
| Delegated (personal Microsoft account) | Not supported.                                                                                            |
| Application                            | EduRoster.Read.All, EduRoster.ReadWrite.All plus Directory.Read.All                                       |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /education/me/user
GET /education/users/{id}/user
```

## Request headers

| Header        | Value                     |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [user](../resources/user.md) object in the response body.

## Example

##### Request

The following is an example of the request.

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "get_educationuser_1"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/education/me/user
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var user = await graphClient.Education.Me.User
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).


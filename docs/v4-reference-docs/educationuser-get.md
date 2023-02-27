---
title: "Get educationUser"
description: "Retrieve the properties and relationships of a user."
author: "mmast-msft"
ms.localizationpriority: medium
ms.prod: "education"
doc_type: apiPageType
---

# Get educationUser

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of a user.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

> [!NOTE]
> If the delegated token is used, members can only see information about their own account. Use the `beta/education/me/users` resource in this case.

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | EduRoster.ReadBasic                         |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | EduRoster.Read.All, EduRoster.ReadWrite.All |

> [!IMPORTANT]
> When using Delegated permission scopes, Graph will only return a limited set of properties: `id`, `primaryRole`, `accountEnabled`, `displayName`, `givenName`, `surname`, `userPrincipalName`, `userType`, `onPremisesInfo`, `student/externalId`, `teacher/externalId`. If your application requires additional properties, you must use Application permission scopes.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /education/me
GET /education/users/{id}
```

## Optional query parameters

This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

## Request headers

| Header        | Value                     |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [educationUser](../resources/educationuser.md) object in the response body.

## Example

##### Request

The following is an example of the request.

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "get_educationuser_2",
  "sampleKeys": ["13012"]
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/education/users/13012
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var educationUser = await graphClient.Education.Users["{educationUser-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).


---
title: "Update program (deprecated)"
description: "In the Azure AD access reviews feature, update an existing program object."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "markwahl-msft"
---

# Update program (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the access review API is deprecated and will stop returning data on May 19, 2023. Please use [access reviews API](/graph/api/resources/accessreviewsv2-overview?view=graph-rest-beta&preserve-view=true).
In the Azure AD [access reviews](../resources/accessreviews-root.md) feature, update an existing [program](../resources/program.md) object.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | ProgramControl.ReadWrite.All   |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Not supported. |

The signed in user must also be in a directory role that permits them to update a program.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /programs/{programId}
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
In the request body, supply a JSON representation of a [program](../resources/program.md) object.

The following table shows the properties that can be supplied when you update a program.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
| `displayName`               |`String`                              |  The name of the program.                   |
| `description`               |`String`                              |  The description of the program.           |


## Response
If successful, this method returns a `204, Accepted` response code and [program](../resources/program.md) object in the response body.

## Example
##### Request
In the request body, supply a JSON representation of the [program](../resources/program.md) object parameters to change.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_program"
}-->
```http
PATCH https://graph.microsoft.com/beta/programs/7e59d237-2fb0-4e5d-b7bb-d4f9f9129213
Content-type: application/json

{
    "displayName": "testprogram3 new name"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var program = new Program
{
	DisplayName = "testprogram3 new name"
};

await graphClient.Programs["{program-id}"]
	.Request()
	.UpdateAsync(program);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).


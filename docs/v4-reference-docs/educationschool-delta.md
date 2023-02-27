---
title: "educationSchool: delta"
description: "Get newly created or updated schools without having to perform a full read of the entire school collection."
ms.localizationpriority: medium
author: "mlafleur"
ms.prod: "education"
doc_type: apiPageType
---

# educationSchool: delta

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get newly created or updated schools without having to perform a full read of the entire school collection. See [Use delta query](/graph/delta-query-overview) for details.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                              |
| :------------------------------------- | :----------------------------------------------------------------------- |
| Delegated (work or school account)     | EduRoster.ReadBasic, EduRoster.Read, or EduRoster.ReadWrite              |
| Delegated (personal Microsoft account) | Not supported.                                                           |
| Application                            | EduRoster.ReadBasic.All, EduRoster.Read.All, or EduRoster.WriteWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /education/schools/delta
```

## Request headers

| Name          | Description   |
| :------------ | :------------ |
| Authorization | Bearer {code} |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [educationSchool](../resources/educationschool.md) collection object in the response body.

> [!IMPORTANT]
> educationSchool deltas do not include deleted schools.

## Example

The following example shows how to call this API.

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "educationschool_delta"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/education/schools/delta
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var delta = await graphClient.Education.Schools
	.Delta()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.educationSchool",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "address": { "@odata.type": "microsoft.graph.physicalAddress" },
      "createdBy": { "@odata.type": "microsoft.graph.identitySet" },
      "description": "String",
      "displayName": "String",
      "externalId": "String",
      "externalPrincipalId": "String",
      "externalSource": "string",
      "highestGrade": "String",
      "id": "String (identifier)",
      "lowestGrade": "String",
      "phone": "String",
      "principalEmail": "String",
      "principalName": "String",
      "schoolNumber": "String"
    }
  ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "educationSchool: delta",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->



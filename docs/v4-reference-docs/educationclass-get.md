---
title: "Get educationClass"
description: "Retrieve a class from the system."
ms.localizationpriority: medium
author: "mmast-msft"
ms.prod: "education"
doc_type: apiPageType
---

# Get educationClass

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a class from the system. A class is a universal group with a special property that indicates to the system that the group is a class. Group members represent the students; group admins represent the teachers in the class. If you're using the delegated token, the user will only see classes in which they are members.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  EduRoster.ReadBasic  |
|Delegated (personal Microsoft account) |  Not supported.  |
|Application | EduRoster.Read.All, EduRoster.ReadWrite.All | 

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /education/classes/{id}
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code and an [educationClass](../resources/educationclass.md) object in the response body.

## Example
### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_educationclass",
  "sampleKeys": ["11023"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/education/classes/11023
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var educationClass = await graphClient.Education.Classes["{educationClass-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response. 

>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.educationClass"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "11023",
  "description": "English Level 2",
  "classCode": "11023",
  "createdBy": {
    "user": {
      "displayName": "Susana Rocha",
      "id": "14012",
    }
  },
  "displayName": "English - Language 2",
  "externalId": "301",
  "externalName": "English Level 1",
  "externalSource": "School of Fine Art",
  "mailNickname": "fineartschool.net "
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Get educationClass",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->

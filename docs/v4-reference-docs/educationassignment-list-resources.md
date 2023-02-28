---
title: "List assignment resources"
description: "Get all the resources associated with an assignment."
author: "Sureshpadimi88"
ms.localizationpriority: medium
ms.prod: "education"
doc_type: apiPageType
---

# List assignment resources

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get all the [educationAssignmentResource](../resources/educationassignmentresource.md) objects associated with an [assignment](../resources/educationassignment.md). Only teachers, students, and applications with application permissions can perform this operation.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  EduAssignments.ReadBasic, EduAssignments.ReadWriteBasic, EduAssignments.Read, EduAssignments.ReadWrite  |
|Delegated (personal Microsoft account) |  Not supported.  |
|Application | EduAssignments.ReadBasic.All, EduAssignments.ReadWriteBasic.All, EduAssignments.Read.All, EduAssignments.ReadWrite.All | 

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /education/classes/{id}/assignments/{id}/resources
```

## Optional query parameters

This method supports the `$top`, `$filter`, `$orderBy`, and `$select` OData query parameters to help customize the response.
For general information, see [OData query parameters](/graph/query-parameters).


## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |

## Request body
Don't supply a request body for this method.

## Response
If successful, this method returns a `200 OK` response code and a collection of [educationAssignmentResource](../resources/educationassignmentresource.md) objects in the response body.

## Example
### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["f4a941ff-9da6-4707-ba5b-0eae93cad0b4","9018ae7a-9953-4796-a152-4c54e0910922"],
  "name": "get_resources_1"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/education/classes/f4a941ff-9da6-4707-ba5b-0eae93cad0b4/assignments/9018ae7a-9953-4796-a152-4c54e0910922/resources
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var resources = await graphClient.Education.Classes["{educationClass-id}"].Assignments["{educationAssignment-id}"].Resources
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
  "@odata.type": "microsoft.graph.educationAssignmentResource",
  "isCollection": true
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "value": [
        {
            "distributeForStudentWork": false,
            "id": "eec7f642-9d9a-406f-bbae-4b3b2c12e273",
            "resource": {
                "@odata.type": "#microsoft.graph.educationFileResource",
                "displayName": "First file uploaded as Education resource by t-cristobalb",
                "createdDateTime": "2021-07-16T23:41:53.9378423Z",
                "lastModifiedDateTime": "2021-07-16T23:41:53.9378423Z",
                "fileUrl": "https://graph.microsoft.com/beta/drives/b!DPA6q59Tw0mtgmyXRUmrQRqBZTesG-lMkl1cBmvvMeU6BLWBcGc_R6UgCKyYyTin/items/016XPCQEA5VVDIMU4BSFG3VBI37MPHZ3OE",
                "createdBy": {
                    "application": null,
                    "device": null,
                    "user": {
                        "id": "f3a5344e-dbde-48b0-be24-b5b62a243836",
                        "displayName": null
                    }
                },
                "lastModifiedBy": {
                    "application": null,
                    "device": null,
                    "user": {
                        "id": "f3a5344e-dbde-48b0-be24-b5b62a243836",
                        "displayName": null
                    }
                }
            }
        },
        {
            "distributeForStudentWork": false,
            "id": "ceb3a7e7-158e-4164-9f80-104d14884389",
            "resource": {
                "@odata.type": "#microsoft.graph.educationPowerPointResource",
                "displayName": "state diagram.pptx",
                "createdDateTime": "2021-08-27T14:42:04.8778499Z",
                "lastModifiedDateTime": "2021-08-27T14:42:04.8778499Z",
                "fileUrl": "https://graph.microsoft.com/beta/drives/b!DPA6q59Tw0mtgmyXRUmrQRqBZTesG-lMkl1cBmvvMeU6BLWBcGc_R6UgCKyYyTin/items/016XPCQEGRJFHRKPSI6RB3XQ6HGTB4L4FV",
                "createdBy": {
                    "application": null,
                    "device": null,
                    "user": {
                        "id": "f3a5344e-dbde-48b0-be24-b5b62a243836",
                        "displayName": null
                    }
                },
                "lastModifiedBy": {
                    "application": null,
                    "device": null,
                    "user": {
                        "id": "f3a5344e-dbde-48b0-be24-b5b62a243836",
                        "displayName": null
                    }
                }
            }
        }
    ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List resources",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->

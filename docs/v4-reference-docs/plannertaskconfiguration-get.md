---
title: "Get plannerTaskConfiguration"
description: "Read the properties and relationships of a plannerTaskConfiguration object."
author: "TarkanSevilmis"
ms.localizationpriority: medium
ms.prod: "business-scenarios"
doc_type: apiPageType
---

# Get plannerTaskConfiguration

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [plannerTaskConfiguration](../resources/plannertaskconfiguration.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|BusinessScenarioConfig.Read.OwnedBy, BusinessScenarioConfig.ReadWrite.OwnedBy, BusinessScenarioConfig.Read.All, BusinessScenarioConfig.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|BusinessScenarioConfig.Read.OwnedBy, BusinessScenarioConfig.ReadWrite.OwnedBy|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /solutions/businessScenarios/{businessScenarioId}/planner/taskConfiguration
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [plannerTaskConfiguration](../resources/plannertaskconfiguration.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_plannertaskconfiguration",
  "sampleKeys": ["c5d514e6c6864911ac46c720affb6e4d"]
}
-->
``` http
GET https://graph.microsoft.com/beta/solutions/businessScenarios/c5d514e6c6864911ac46c720affb6e4d/planner/taskConfiguration
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerTaskConfiguration = await graphClient.Solutions.BusinessScenarios["{businessScenario-id}"].Planner.TaskConfiguration
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
  "@odata.type": "microsoft.graph.plannerTaskConfiguration"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerTaskConfiguration",
  "id": "52be01e6291f403aa49f2b9f5288ab48",
  "editPolicy": {
    "rules": [
      {
        "defaultRule": "block",
        "role": {
          "@odata.type": "#microsoft.graph.plannerRelationshipBasedUserType",
          "roleKind": "relationship",
          "role": "defaultRules"
        },
        "propertyRule": {
          "move": [],
          "delete": [],
          "title": [],
          "notes": [],
          "priority": [],
          "startDate": [],
          "dueDate": [],
          "percentComplete": ["allow"],
          "order": [],
          "previewType": [],
          "ruleKind": "taskRule",
          "references": null,
          "checkLists": null,
          "assignments": {
            "defaultRules": ["addSelf"],
            "overrides": []
          },
          "appliedCategories": null
        }
      },
      {
        "defaultRule": "block",
        "role": {
          "@odata.type": "#microsoft.graph.plannerRelationshipBasedUserType",
          "roleKind": "relationship",
          "role": "taskAssignees"
        },
        "propertyRule": {
          "move": [],
          "delete": [],
          "title": [],
          "notes": [],
          "priority": [],
          "startDate": ["allow"],
          "dueDate": ["allow"],
          "percentComplete": ["allow"],
          "order": ["allow"],
          "previewType": [],
          "ruleKind": "taskRule",
          "references": {
            "defaultRules": ["allow"],
            "overrides": [
              {
                "name": "userCreated",
                "rules": ["allow"]
              },
              {
                "name": "applicationCreated",
                "rules": ["block"]
              }
            ]
          },
          "checkLists": {
            "defaultRules": ["allow"],
            "overrides": [
              {
                "name": "userCreated",
                "rules": ["allow"]
              },
              {
                "name": "applicationCreated",
                "rules": ["check"]
              }
            ]
          },
          "assignments": {
            "defaultRules": ["block"],
            "overrides": [
              {
                "name": "userCreated",
                "rules": ["removeSelf"]
              },
              {
                "name": "applicationCreated",
                "rules": ["check"]
              }
            ]
          },
          "appliedCategories": {
            "defaultRules": [
              "allow"
            ],
            "overrides": []
          }
        }
      }
    ]
  }
}
```

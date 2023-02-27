---
title: "List retentionEvents"
description: "Get a list of the retentionEvent objects and their properties."
author: "sseth"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# List retentionEvents
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [retentionEvent](../resources/security-retentionevent.md) objects and their properties.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|RecordsManagement.Read.All, RecordsManagement.ReadWrite.All|
|Delegated (personal Microsoft account)|Not Supported.|
|Application|Not Supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /security/triggers/retentionEvents
```

## Optional query parameters
This method supports the expand OData query parameters to help customize the response. For example, to get the event type, use `$expand=retentionEventType`. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [microsoft.graph.security.retentionEvent](../resources/security-retentionevent.md)  objects in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_retentionevent"
}
-->
``` http
GET https://graph.microsoft.com/beta/security/triggers/retentionEvents
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var retentionEvents = await graphClient.Security.Triggers.RetentionEvents
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.security.retentionEvent)"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "@odata.type": "#microsoft.graph.security.retentionEvent",
      "id": "fcdbfb58-d0c6-85dd-d011-4e0ff9a6805d",
      "displayName": "String",
      "description": "String",
      "eventQueries": [
        {
          "@odata.type": "microsoft.graph.security.eventQueries"
        }
      ],
      "eventTriggerDateTime": "String (timestamp)",
      "createdBy": {
        "@odata.type": "microsoft.graph.identitySet"
      },
      "createdDateTime": "String (timestamp)",
      "lastModifiedBy": {
        "@odata.type": "microsoft.graph.identitySet"
      },
      "lastModifiedDateTime": "String (timestamp)",
      "eventPropagationResults": [
        {
          "@odata.type": "microsoft.graph.security.eventPropagationResult"
        }
      ],
      "eventStatus": {
        "@odata.type": "microsoft.graph.security.retentionEventStatus"
      },
      "lastStatusUpdateDateTime": "String (timestamp)"
    }
  ]
}
```

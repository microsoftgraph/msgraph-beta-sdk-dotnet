---
title: "Create retentionEventType"
description: "Create a new retentionEventType object."
author: "sseth"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# Create retentionEventType
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [retentionEventType](../resources/security-retentioneventtype.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|RecordsManagement.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /security/triggerTypes/retentionEventTypes
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [retentionEventType](../resources/security-retentioneventtype.md) object.

Specify the following properties when creating a **retentionEventType**.

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|Name of the event type.|
|description|String|Information about the event type. Optional.|




## Response

If successful, this method returns a `201 Created` response code and a [microsoft.graph.security.retentionEventType](../resources/security-retentioneventtype.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_retentioneventtype_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/security/triggerTypes/retentionEventTypes
Content-Type: application/json
Content-length: 199

{
  "@odata.type": "#microsoft.graph.security.retentionEventType",
  "displayName": "String",
  "description": "String",
  "createdBy": {
    "@odata.type": "microsoft.graph.identitySet"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var retentionEventType = new Microsoft.Graph.Security.RetentionEventType
{
	DisplayName = "String",
	Description = "String",
	CreatedBy = new IdentitySet
	{
	}
};

await graphClient.Security.TriggerTypes.RetentionEventTypes
	.Request()
	.AddAsync(retentionEventType);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.security.retentionEventType"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.security.retentionEventType",
  "id": "dd689e79-9e79-dd68-799e-68dd799e68dd",
  "displayName": "String",
  "description": "String",
  "createdBy": {
    "@odata.type": "microsoft.graph.identitySet"
  },
  "createdDateTime": "String (timestamp)",
  "lastModifiedBy": {
    "@odata.type": "microsoft.graph.identitySet"
  },
  "lastModifiedDateTime": "String (timestamp)"
}
```


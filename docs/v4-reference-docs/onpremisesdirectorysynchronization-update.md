---
title: "Update onPremisesDirectorySynchronization"
description: "Update the properties of an onPremisesDirectorySynchronization object."
author: "dkershaw10"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Update onPremisesDirectorySynchronization

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [onPremisesDirectorySynchronization](../resources/onpremisesdirectorysynchronization.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)  |
| :------------------------------------- | :------------------------------------------- |
| Delegated (work or school account)     | OnPremDirectorySynchronization.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported.                               |
| Application                            | Not supported.                               |

For delegated scenarios, the user needs to be assigned the *Global administrator* [role](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles).

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /directory/onPremisesSynchronization/{id}
```

## Request headers

| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

| Property      | Type                                                                                                                                           | Description                                                                                                                                |
| :------------ | :--------------------------------------------------------------------------------------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| configuration | [onPremisesDirectorySynchronizationConfiguration](../resources/onpremisesdirectorysynchronizationconfiguration.md) | Consists of configurations that can be fine-tuned and impact the on-premises directory synchronization process for a tenant. |
| features      | [onPremisesDirectorySynchronizationFeature](../resources/onpremisesdirectorysynchronizationfeature.md)             | Consists of directory synchronization features that can be enabled or disabled.                                          |

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_onpremisesdirectorysynchronization"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/directory/onPremisesSynchronization/{id}
Content-Type: application/json
Content-length: 293

{
  "configuration": {
    "accidentalDeletionPrevention": {
      "synchronizationPreventionType": "enabledForCount",
      "alertThreshold": 500
    },
    "synchronizationInterval": "PT30M",
    "customerRequestedSynchronizationInterval": "PT1H"
  },
  "features": {
    "groupWriteBackEnabled": true
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var onPremisesDirectorySynchronization = new OnPremisesDirectorySynchronization
{
	Configuration = new OnPremisesDirectorySynchronizationConfiguration
	{
		AccidentalDeletionPrevention = new OnPremisesAccidentalDeletionPrevention
		{
			SynchronizationPreventionType = OnPremisesDirectorySynchronizationDeletionPreventionType.EnabledForCount,
			AlertThreshold = 500
		},
		SynchronizationInterval = new Duration("PT30M"),
		CustomerRequestedSynchronizationInterval = new Duration("PT1H")
	},
	Features = new OnPremisesDirectorySynchronizationFeature
	{
		GroupWriteBackEnabled = true
	}
};

await graphClient.Directory.OnPremisesSynchronization["{onPremisesDirectorySynchronization-id}"]
	.Request()
	.UpdateAsync(onPremisesDirectorySynchronization);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

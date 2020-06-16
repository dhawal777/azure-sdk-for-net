// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EventChannelsOperations.
    /// </summary>
    public static partial class EventChannelsOperationsExtensions
    {
            /// <summary>
            /// Get an event channel.
            /// </summary>
            /// <remarks>
            /// Get properties of an event channel.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='eventChannelName'>
            /// Name of the event channel.
            /// </param>
            public static EventChannel Get(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string eventChannelName)
            {
                return operations.GetAsync(resourceGroupName, partnerNamespaceName, eventChannelName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an event channel.
            /// </summary>
            /// <remarks>
            /// Get properties of an event channel.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='eventChannelName'>
            /// Name of the event channel.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventChannel> GetAsync(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string eventChannelName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, partnerNamespaceName, eventChannelName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create an event channel.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates a new event channel with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='eventChannelName'>
            /// Name of the event channel.
            /// </param>
            /// <param name='eventChannelInfo'>
            /// EventChannel information.
            /// </param>
            public static EventChannel CreateOrUpdate(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string eventChannelName, EventChannel eventChannelInfo)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, partnerNamespaceName, eventChannelName, eventChannelInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create an event channel.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates a new event channel with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='eventChannelName'>
            /// Name of the event channel.
            /// </param>
            /// <param name='eventChannelInfo'>
            /// EventChannel information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventChannel> CreateOrUpdateAsync(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string eventChannelName, EventChannel eventChannelInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, partnerNamespaceName, eventChannelName, eventChannelInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an event channel.
            /// </summary>
            /// <remarks>
            /// Delete existing event channel.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='eventChannelName'>
            /// Name of the event channel.
            /// </param>
            public static void Delete(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string eventChannelName)
            {
                operations.DeleteAsync(resourceGroupName, partnerNamespaceName, eventChannelName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an event channel.
            /// </summary>
            /// <remarks>
            /// Delete existing event channel.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='eventChannelName'>
            /// Name of the event channel.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string eventChannelName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, partnerNamespaceName, eventChannelName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List event channels.
            /// </summary>
            /// <remarks>
            /// List all the event channels in a partner namespace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            public static IPage<EventChannel> ListByPartnerNamespace(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string filter = default(string), int? top = default(int?))
            {
                return operations.ListByPartnerNamespaceAsync(resourceGroupName, partnerNamespaceName, filter, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List event channels.
            /// </summary>
            /// <remarks>
            /// List all the event channels in a partner namespace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventChannel>> ListByPartnerNamespaceAsync(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPartnerNamespaceWithHttpMessagesAsync(resourceGroupName, partnerNamespaceName, filter, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an event channel.
            /// </summary>
            /// <remarks>
            /// Delete existing event channel.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='eventChannelName'>
            /// Name of the event channel.
            /// </param>
            public static void BeginDelete(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string eventChannelName)
            {
                operations.BeginDeleteAsync(resourceGroupName, partnerNamespaceName, eventChannelName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an event channel.
            /// </summary>
            /// <remarks>
            /// Delete existing event channel.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerNamespaceName'>
            /// Name of the partner namespace.
            /// </param>
            /// <param name='eventChannelName'>
            /// Name of the event channel.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IEventChannelsOperations operations, string resourceGroupName, string partnerNamespaceName, string eventChannelName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, partnerNamespaceName, eventChannelName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List event channels.
            /// </summary>
            /// <remarks>
            /// List all the event channels in a partner namespace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EventChannel> ListByPartnerNamespaceNext(this IEventChannelsOperations operations, string nextPageLink)
            {
                return operations.ListByPartnerNamespaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List event channels.
            /// </summary>
            /// <remarks>
            /// List all the event channels in a partner namespace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventChannel>> ListByPartnerNamespaceNextAsync(this IEventChannelsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPartnerNamespaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
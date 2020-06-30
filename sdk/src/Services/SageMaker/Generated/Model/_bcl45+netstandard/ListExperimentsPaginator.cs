#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Base class for ListExperiments paginators.
    /// </summary>
    internal sealed partial class ListExperimentsPaginator : IPaginator<ListExperimentsResponse>, IListExperimentsPaginator
    {
        private readonly IAmazonSageMaker _client;
        private readonly ListExperimentsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListExperimentsResponse> Responses => new PaginatedResponse<ListExperimentsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ExperimentSummaries
        /// </summary>
        public IPaginatedEnumerable<ExperimentSummary> ExperimentSummaries => 
            new PaginatedResultKeyResponse<ListExperimentsResponse, ExperimentSummary>(this, (i) => i.ExperimentSummaries);

        internal ListExperimentsPaginator(IAmazonSageMaker client, ListExperimentsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListExperimentsResponse> IPaginator<ListExperimentsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = _request.NextToken;
            ListExperimentsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListExperiments(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (nextToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListExperimentsResponse> IPaginator<ListExperimentsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = _request.NextToken;
            ListExperimentsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListExperimentsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (nextToken != null);
        }
#endif
    }
}
#endif
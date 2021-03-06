/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v1
 * Contact: api@domain.com.au
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Domain.Api.V1.Client;

namespace Domain.Api.V1.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatisticsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Record a statistic event along with its associated metadata (if applicable)
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event">The event type</param>
        /// <param name="body">A JSON object dictionary of the metadata associated with the event.</param>
        /// <returns></returns>
        void StatisticsPost(string _event, Object body);

        /// <summary>
        /// Record a statistic event along with its associated metadata (if applicable)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event">The event type</param>
        /// <param name="body">A JSON object dictionary of the metadata associated with the event.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> StatisticsPostWithHttpInfo(string _event, Object body);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatisticsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Record a statistic event along with its associated metadata (if applicable)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event">The event type</param>
        /// <param name="body">A JSON object dictionary of the metadata associated with the event.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task StatisticsPostAsync(string _event, Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Record a statistic event along with its associated metadata (if applicable)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event">The event type</param>
        /// <param name="body">A JSON object dictionary of the metadata associated with the event.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> StatisticsPostWithHttpInfoAsync(string _event, Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatisticsApi : IStatisticsApiSync, IStatisticsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StatisticsApi : IStatisticsApi
    {
        private Domain.Api.V1.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatisticsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatisticsApi(String basePath)
        {
            this.Configuration = Domain.Api.V1.Client.Configuration.MergeConfigurations(
                Domain.Api.V1.Client.GlobalConfiguration.Instance,
                new Domain.Api.V1.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Domain.Api.V1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Domain.Api.V1.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Domain.Api.V1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatisticsApi(Domain.Api.V1.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Domain.Api.V1.Client.Configuration.MergeConfigurations(
                Domain.Api.V1.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Domain.Api.V1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Domain.Api.V1.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Domain.Api.V1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StatisticsApi(Domain.Api.V1.Client.ISynchronousClient client, Domain.Api.V1.Client.IAsynchronousClient asyncClient, Domain.Api.V1.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Domain.Api.V1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Domain.Api.V1.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Domain.Api.V1.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Domain.Api.V1.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Domain.Api.V1.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Record a statistic event along with its associated metadata (if applicable) 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event">The event type</param>
        /// <param name="body">A JSON object dictionary of the metadata associated with the event.</param>
        /// <returns></returns>
        public void StatisticsPost(string _event, Object body)
        {
            StatisticsPostWithHttpInfo(_event, body);
        }

        /// <summary>
        /// Record a statistic event along with its associated metadata (if applicable) 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event">The event type</param>
        /// <param name="body">A JSON object dictionary of the metadata associated with the event.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Domain.Api.V1.Client.ApiResponse<Object> StatisticsPostWithHttpInfo(string _event, Object body)
        {
            // verify the required parameter '_event' is set
            if (_event == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter '_event' when calling StatisticsApi->StatisticsPost");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter 'body' when calling StatisticsApi->StatisticsPost");

            Domain.Api.V1.Client.RequestOptions localVarRequestOptions = new Domain.Api.V1.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };

            var localVarContentType = Domain.Api.V1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Domain.Api.V1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("event", Domain.Api.V1.Client.ClientUtils.ParameterToString(_event)); // path parameter
            localVarRequestOptions.Data = body;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/v1/statistics/{event}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StatisticsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Record a statistic event along with its associated metadata (if applicable) 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event">The event type</param>
        /// <param name="body">A JSON object dictionary of the metadata associated with the event.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task StatisticsPostAsync(string _event, Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await StatisticsPostWithHttpInfoAsync(_event, body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Record a statistic event along with its associated metadata (if applicable) 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event">The event type</param>
        /// <param name="body">A JSON object dictionary of the metadata associated with the event.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Domain.Api.V1.Client.ApiResponse<Object>> StatisticsPostWithHttpInfoAsync(string _event, Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter '_event' is set
            if (_event == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter '_event' when calling StatisticsApi->StatisticsPost");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter 'body' when calling StatisticsApi->StatisticsPost");


            Domain.Api.V1.Client.RequestOptions localVarRequestOptions = new Domain.Api.V1.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json", 
                "text/json", 
                "text/html", 
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };


            var localVarContentType = Domain.Api.V1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Domain.Api.V1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("event", Domain.Api.V1.Client.ClientUtils.ParameterToString(_event)); // path parameter
            localVarRequestOptions.Data = body;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/v1/statistics/{event}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StatisticsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}

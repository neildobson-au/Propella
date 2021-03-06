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
using Domain.Api.V1.Model;

namespace Domain.Api.V1.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISuburbPerformanceStatisticsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves suburb performance data
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="state">State where the suburb is</param>
        /// <param name="suburbId">Suburb Identifier.  Use the &#x60;addressLocators&#x60; resource to determine the suburbId.</param>
        /// <param name="propertyCategory">Property Category. Valid values are: &#x60;house&#x60;, &#x60;unit&#x60;, &#x60;land&#x60;</param>
        /// <param name="chronologicalSpan">The size of each chunk of information we want in months. 3, 6, or 12.</param>
        /// <param name="tPlusFrom">Countdown number in chronological spans from the current (current chronological span is 1)</param>
        /// <param name="tPlusTo">Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3)</param>
        /// <param name="bedrooms">Restrict statistics to properties with this number of bedrooms (optional)</param>
        /// <param name="values">Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: &#x60;MedianSoldPrice&#x60;, &#x60;AuctionNumberAuctioned&#x60;, &#x60;AuctionNumberSold&#x60;, &#x60;AuctionNumberWithdrawn&#x60;, &#x60;NumberSold&#x60;, &#x60;LowestSoldPrice&#x60;, &#x60;HighestSoldPrice&#x60;, &#x60;5thPercentileSoldPrice&#x60;, &#x60;25thPercentileSoldPrice&#x60;, &#x60;75thPercentileSoldPrice&#x60;, &#x60;95thPercentileSoldPrice&#x60;, &#x60;DaysOnMarket&#x60;, &#x60;DiscountPercentage&#x60;, &#x60;MedianRentListingPrice&#x60;, &#x60;NumberRentListing&#x60;, &#x60;HighestRentListingPrice&#x60;, &#x60;LowestRentListingPrice&#x60;, &#x60;MedianSaleListingPrice&#x60;, &#x60;NumberSaleListing&#x60;, &#x60;HighestSaleListingPrice&#x60;, &#x60;LowestSaleListingPrice&#x60; (optional)</param>
        /// <returns>DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel</returns>
        DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel SuburbPerformanceStatisticsGet(string state, int suburbId, string propertyCategory, int chronologicalSpan, int tPlusFrom, int tPlusTo, string bedrooms = default(string), string values = default(string));

        /// <summary>
        /// Retrieves suburb performance data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="state">State where the suburb is</param>
        /// <param name="suburbId">Suburb Identifier.  Use the &#x60;addressLocators&#x60; resource to determine the suburbId.</param>
        /// <param name="propertyCategory">Property Category. Valid values are: &#x60;house&#x60;, &#x60;unit&#x60;, &#x60;land&#x60;</param>
        /// <param name="chronologicalSpan">The size of each chunk of information we want in months. 3, 6, or 12.</param>
        /// <param name="tPlusFrom">Countdown number in chronological spans from the current (current chronological span is 1)</param>
        /// <param name="tPlusTo">Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3)</param>
        /// <param name="bedrooms">Restrict statistics to properties with this number of bedrooms (optional)</param>
        /// <param name="values">Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: &#x60;MedianSoldPrice&#x60;, &#x60;AuctionNumberAuctioned&#x60;, &#x60;AuctionNumberSold&#x60;, &#x60;AuctionNumberWithdrawn&#x60;, &#x60;NumberSold&#x60;, &#x60;LowestSoldPrice&#x60;, &#x60;HighestSoldPrice&#x60;, &#x60;5thPercentileSoldPrice&#x60;, &#x60;25thPercentileSoldPrice&#x60;, &#x60;75thPercentileSoldPrice&#x60;, &#x60;95thPercentileSoldPrice&#x60;, &#x60;DaysOnMarket&#x60;, &#x60;DiscountPercentage&#x60;, &#x60;MedianRentListingPrice&#x60;, &#x60;NumberRentListing&#x60;, &#x60;HighestRentListingPrice&#x60;, &#x60;LowestRentListingPrice&#x60;, &#x60;MedianSaleListingPrice&#x60;, &#x60;NumberSaleListing&#x60;, &#x60;HighestSaleListingPrice&#x60;, &#x60;LowestSaleListingPrice&#x60; (optional)</param>
        /// <returns>ApiResponse of DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel</returns>
        ApiResponse<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel> SuburbPerformanceStatisticsGetWithHttpInfo(string state, int suburbId, string propertyCategory, int chronologicalSpan, int tPlusFrom, int tPlusTo, string bedrooms = default(string), string values = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISuburbPerformanceStatisticsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves suburb performance data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="state">State where the suburb is</param>
        /// <param name="suburbId">Suburb Identifier.  Use the &#x60;addressLocators&#x60; resource to determine the suburbId.</param>
        /// <param name="propertyCategory">Property Category. Valid values are: &#x60;house&#x60;, &#x60;unit&#x60;, &#x60;land&#x60;</param>
        /// <param name="chronologicalSpan">The size of each chunk of information we want in months. 3, 6, or 12.</param>
        /// <param name="tPlusFrom">Countdown number in chronological spans from the current (current chronological span is 1)</param>
        /// <param name="tPlusTo">Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3)</param>
        /// <param name="bedrooms">Restrict statistics to properties with this number of bedrooms (optional)</param>
        /// <param name="values">Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: &#x60;MedianSoldPrice&#x60;, &#x60;AuctionNumberAuctioned&#x60;, &#x60;AuctionNumberSold&#x60;, &#x60;AuctionNumberWithdrawn&#x60;, &#x60;NumberSold&#x60;, &#x60;LowestSoldPrice&#x60;, &#x60;HighestSoldPrice&#x60;, &#x60;5thPercentileSoldPrice&#x60;, &#x60;25thPercentileSoldPrice&#x60;, &#x60;75thPercentileSoldPrice&#x60;, &#x60;95thPercentileSoldPrice&#x60;, &#x60;DaysOnMarket&#x60;, &#x60;DiscountPercentage&#x60;, &#x60;MedianRentListingPrice&#x60;, &#x60;NumberRentListing&#x60;, &#x60;HighestRentListingPrice&#x60;, &#x60;LowestRentListingPrice&#x60;, &#x60;MedianSaleListingPrice&#x60;, &#x60;NumberSaleListing&#x60;, &#x60;HighestSaleListingPrice&#x60;, &#x60;LowestSaleListingPrice&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel</returns>
        System.Threading.Tasks.Task<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel> SuburbPerformanceStatisticsGetAsync(string state, int suburbId, string propertyCategory, int chronologicalSpan, int tPlusFrom, int tPlusTo, string bedrooms = default(string), string values = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves suburb performance data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="state">State where the suburb is</param>
        /// <param name="suburbId">Suburb Identifier.  Use the &#x60;addressLocators&#x60; resource to determine the suburbId.</param>
        /// <param name="propertyCategory">Property Category. Valid values are: &#x60;house&#x60;, &#x60;unit&#x60;, &#x60;land&#x60;</param>
        /// <param name="chronologicalSpan">The size of each chunk of information we want in months. 3, 6, or 12.</param>
        /// <param name="tPlusFrom">Countdown number in chronological spans from the current (current chronological span is 1)</param>
        /// <param name="tPlusTo">Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3)</param>
        /// <param name="bedrooms">Restrict statistics to properties with this number of bedrooms (optional)</param>
        /// <param name="values">Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: &#x60;MedianSoldPrice&#x60;, &#x60;AuctionNumberAuctioned&#x60;, &#x60;AuctionNumberSold&#x60;, &#x60;AuctionNumberWithdrawn&#x60;, &#x60;NumberSold&#x60;, &#x60;LowestSoldPrice&#x60;, &#x60;HighestSoldPrice&#x60;, &#x60;5thPercentileSoldPrice&#x60;, &#x60;25thPercentileSoldPrice&#x60;, &#x60;75thPercentileSoldPrice&#x60;, &#x60;95thPercentileSoldPrice&#x60;, &#x60;DaysOnMarket&#x60;, &#x60;DiscountPercentage&#x60;, &#x60;MedianRentListingPrice&#x60;, &#x60;NumberRentListing&#x60;, &#x60;HighestRentListingPrice&#x60;, &#x60;LowestRentListingPrice&#x60;, &#x60;MedianSaleListingPrice&#x60;, &#x60;NumberSaleListing&#x60;, &#x60;HighestSaleListingPrice&#x60;, &#x60;LowestSaleListingPrice&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel>> SuburbPerformanceStatisticsGetWithHttpInfoAsync(string state, int suburbId, string propertyCategory, int chronologicalSpan, int tPlusFrom, int tPlusTo, string bedrooms = default(string), string values = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISuburbPerformanceStatisticsApi : ISuburbPerformanceStatisticsApiSync, ISuburbPerformanceStatisticsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SuburbPerformanceStatisticsApi : ISuburbPerformanceStatisticsApi
    {
        private Domain.Api.V1.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SuburbPerformanceStatisticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SuburbPerformanceStatisticsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuburbPerformanceStatisticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SuburbPerformanceStatisticsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="SuburbPerformanceStatisticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SuburbPerformanceStatisticsApi(Domain.Api.V1.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SuburbPerformanceStatisticsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SuburbPerformanceStatisticsApi(Domain.Api.V1.Client.ISynchronousClient client, Domain.Api.V1.Client.IAsynchronousClient asyncClient, Domain.Api.V1.Client.IReadableConfiguration configuration)
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
        /// Retrieves suburb performance data 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="state">State where the suburb is</param>
        /// <param name="suburbId">Suburb Identifier.  Use the &#x60;addressLocators&#x60; resource to determine the suburbId.</param>
        /// <param name="propertyCategory">Property Category. Valid values are: &#x60;house&#x60;, &#x60;unit&#x60;, &#x60;land&#x60;</param>
        /// <param name="chronologicalSpan">The size of each chunk of information we want in months. 3, 6, or 12.</param>
        /// <param name="tPlusFrom">Countdown number in chronological spans from the current (current chronological span is 1)</param>
        /// <param name="tPlusTo">Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3)</param>
        /// <param name="bedrooms">Restrict statistics to properties with this number of bedrooms (optional)</param>
        /// <param name="values">Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: &#x60;MedianSoldPrice&#x60;, &#x60;AuctionNumberAuctioned&#x60;, &#x60;AuctionNumberSold&#x60;, &#x60;AuctionNumberWithdrawn&#x60;, &#x60;NumberSold&#x60;, &#x60;LowestSoldPrice&#x60;, &#x60;HighestSoldPrice&#x60;, &#x60;5thPercentileSoldPrice&#x60;, &#x60;25thPercentileSoldPrice&#x60;, &#x60;75thPercentileSoldPrice&#x60;, &#x60;95thPercentileSoldPrice&#x60;, &#x60;DaysOnMarket&#x60;, &#x60;DiscountPercentage&#x60;, &#x60;MedianRentListingPrice&#x60;, &#x60;NumberRentListing&#x60;, &#x60;HighestRentListingPrice&#x60;, &#x60;LowestRentListingPrice&#x60;, &#x60;MedianSaleListingPrice&#x60;, &#x60;NumberSaleListing&#x60;, &#x60;HighestSaleListingPrice&#x60;, &#x60;LowestSaleListingPrice&#x60; (optional)</param>
        /// <returns>DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel</returns>
        public DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel SuburbPerformanceStatisticsGet(string state, int suburbId, string propertyCategory, int chronologicalSpan, int tPlusFrom, int tPlusTo, string bedrooms = default(string), string values = default(string))
        {
            Domain.Api.V1.Client.ApiResponse<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel> localVarResponse = SuburbPerformanceStatisticsGetWithHttpInfo(state, suburbId, propertyCategory, chronologicalSpan, tPlusFrom, tPlusTo, bedrooms, values);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves suburb performance data 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="state">State where the suburb is</param>
        /// <param name="suburbId">Suburb Identifier.  Use the &#x60;addressLocators&#x60; resource to determine the suburbId.</param>
        /// <param name="propertyCategory">Property Category. Valid values are: &#x60;house&#x60;, &#x60;unit&#x60;, &#x60;land&#x60;</param>
        /// <param name="chronologicalSpan">The size of each chunk of information we want in months. 3, 6, or 12.</param>
        /// <param name="tPlusFrom">Countdown number in chronological spans from the current (current chronological span is 1)</param>
        /// <param name="tPlusTo">Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3)</param>
        /// <param name="bedrooms">Restrict statistics to properties with this number of bedrooms (optional)</param>
        /// <param name="values">Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: &#x60;MedianSoldPrice&#x60;, &#x60;AuctionNumberAuctioned&#x60;, &#x60;AuctionNumberSold&#x60;, &#x60;AuctionNumberWithdrawn&#x60;, &#x60;NumberSold&#x60;, &#x60;LowestSoldPrice&#x60;, &#x60;HighestSoldPrice&#x60;, &#x60;5thPercentileSoldPrice&#x60;, &#x60;25thPercentileSoldPrice&#x60;, &#x60;75thPercentileSoldPrice&#x60;, &#x60;95thPercentileSoldPrice&#x60;, &#x60;DaysOnMarket&#x60;, &#x60;DiscountPercentage&#x60;, &#x60;MedianRentListingPrice&#x60;, &#x60;NumberRentListing&#x60;, &#x60;HighestRentListingPrice&#x60;, &#x60;LowestRentListingPrice&#x60;, &#x60;MedianSaleListingPrice&#x60;, &#x60;NumberSaleListing&#x60;, &#x60;HighestSaleListingPrice&#x60;, &#x60;LowestSaleListingPrice&#x60; (optional)</param>
        /// <returns>ApiResponse of DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel</returns>
        public Domain.Api.V1.Client.ApiResponse<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel> SuburbPerformanceStatisticsGetWithHttpInfo(string state, int suburbId, string propertyCategory, int chronologicalSpan, int tPlusFrom, int tPlusTo, string bedrooms = default(string), string values = default(string))
        {
            // verify the required parameter 'state' is set
            if (state == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter 'state' when calling SuburbPerformanceStatisticsApi->SuburbPerformanceStatisticsGet");

            // verify the required parameter 'propertyCategory' is set
            if (propertyCategory == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter 'propertyCategory' when calling SuburbPerformanceStatisticsApi->SuburbPerformanceStatisticsGet");

            Domain.Api.V1.Client.RequestOptions localVarRequestOptions = new Domain.Api.V1.Client.RequestOptions();

            String[] _contentTypes = new String[] {
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

            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "state", state));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "suburbId", suburbId));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "propertyCategory", propertyCategory));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "chronologicalSpan", chronologicalSpan));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "tPlusFrom", tPlusFrom));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "tPlusTo", tPlusTo));
            if (bedrooms != null)
            {
                localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "bedrooms", bedrooms));
            }
            if (values != null)
            {
                localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "values", values));
            }

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
            var localVarResponse = this.Client.Get<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel>("/v1/suburbPerformanceStatistics", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SuburbPerformanceStatisticsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves suburb performance data 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="state">State where the suburb is</param>
        /// <param name="suburbId">Suburb Identifier.  Use the &#x60;addressLocators&#x60; resource to determine the suburbId.</param>
        /// <param name="propertyCategory">Property Category. Valid values are: &#x60;house&#x60;, &#x60;unit&#x60;, &#x60;land&#x60;</param>
        /// <param name="chronologicalSpan">The size of each chunk of information we want in months. 3, 6, or 12.</param>
        /// <param name="tPlusFrom">Countdown number in chronological spans from the current (current chronological span is 1)</param>
        /// <param name="tPlusTo">Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3)</param>
        /// <param name="bedrooms">Restrict statistics to properties with this number of bedrooms (optional)</param>
        /// <param name="values">Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: &#x60;MedianSoldPrice&#x60;, &#x60;AuctionNumberAuctioned&#x60;, &#x60;AuctionNumberSold&#x60;, &#x60;AuctionNumberWithdrawn&#x60;, &#x60;NumberSold&#x60;, &#x60;LowestSoldPrice&#x60;, &#x60;HighestSoldPrice&#x60;, &#x60;5thPercentileSoldPrice&#x60;, &#x60;25thPercentileSoldPrice&#x60;, &#x60;75thPercentileSoldPrice&#x60;, &#x60;95thPercentileSoldPrice&#x60;, &#x60;DaysOnMarket&#x60;, &#x60;DiscountPercentage&#x60;, &#x60;MedianRentListingPrice&#x60;, &#x60;NumberRentListing&#x60;, &#x60;HighestRentListingPrice&#x60;, &#x60;LowestRentListingPrice&#x60;, &#x60;MedianSaleListingPrice&#x60;, &#x60;NumberSaleListing&#x60;, &#x60;HighestSaleListingPrice&#x60;, &#x60;LowestSaleListingPrice&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel</returns>
        public async System.Threading.Tasks.Task<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel> SuburbPerformanceStatisticsGetAsync(string state, int suburbId, string propertyCategory, int chronologicalSpan, int tPlusFrom, int tPlusTo, string bedrooms = default(string), string values = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Domain.Api.V1.Client.ApiResponse<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel> localVarResponse = await SuburbPerformanceStatisticsGetWithHttpInfoAsync(state, suburbId, propertyCategory, chronologicalSpan, tPlusFrom, tPlusTo, bedrooms, values, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves suburb performance data 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="state">State where the suburb is</param>
        /// <param name="suburbId">Suburb Identifier.  Use the &#x60;addressLocators&#x60; resource to determine the suburbId.</param>
        /// <param name="propertyCategory">Property Category. Valid values are: &#x60;house&#x60;, &#x60;unit&#x60;, &#x60;land&#x60;</param>
        /// <param name="chronologicalSpan">The size of each chunk of information we want in months. 3, 6, or 12.</param>
        /// <param name="tPlusFrom">Countdown number in chronological spans from the current (current chronological span is 1)</param>
        /// <param name="tPlusTo">Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3)</param>
        /// <param name="bedrooms">Restrict statistics to properties with this number of bedrooms (optional)</param>
        /// <param name="values">Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: &#x60;MedianSoldPrice&#x60;, &#x60;AuctionNumberAuctioned&#x60;, &#x60;AuctionNumberSold&#x60;, &#x60;AuctionNumberWithdrawn&#x60;, &#x60;NumberSold&#x60;, &#x60;LowestSoldPrice&#x60;, &#x60;HighestSoldPrice&#x60;, &#x60;5thPercentileSoldPrice&#x60;, &#x60;25thPercentileSoldPrice&#x60;, &#x60;75thPercentileSoldPrice&#x60;, &#x60;95thPercentileSoldPrice&#x60;, &#x60;DaysOnMarket&#x60;, &#x60;DiscountPercentage&#x60;, &#x60;MedianRentListingPrice&#x60;, &#x60;NumberRentListing&#x60;, &#x60;HighestRentListingPrice&#x60;, &#x60;LowestRentListingPrice&#x60;, &#x60;MedianSaleListingPrice&#x60;, &#x60;NumberSaleListing&#x60;, &#x60;HighestSaleListingPrice&#x60;, &#x60;LowestSaleListingPrice&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel)</returns>
        public async System.Threading.Tasks.Task<Domain.Api.V1.Client.ApiResponse<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel>> SuburbPerformanceStatisticsGetWithHttpInfoAsync(string state, int suburbId, string propertyCategory, int chronologicalSpan, int tPlusFrom, int tPlusTo, string bedrooms = default(string), string values = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'state' is set
            if (state == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter 'state' when calling SuburbPerformanceStatisticsApi->SuburbPerformanceStatisticsGet");

            // verify the required parameter 'propertyCategory' is set
            if (propertyCategory == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter 'propertyCategory' when calling SuburbPerformanceStatisticsApi->SuburbPerformanceStatisticsGet");


            Domain.Api.V1.Client.RequestOptions localVarRequestOptions = new Domain.Api.V1.Client.RequestOptions();

            String[] _contentTypes = new String[] {
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

            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "state", state));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "suburbId", suburbId));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "propertyCategory", propertyCategory));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "chronologicalSpan", chronologicalSpan));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "tPlusFrom", tPlusFrom));
            localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "tPlusTo", tPlusTo));
            if (bedrooms != null)
            {
                localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "bedrooms", bedrooms));
            }
            if (values != null)
            {
                localVarRequestOptions.QueryParameters.Add(Domain.Api.V1.Client.ClientUtils.ParameterToMultiMap("", "values", values));
            }

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel>("/v1/suburbPerformanceStatistics", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SuburbPerformanceStatisticsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}

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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.GameLift.Model;
using Amazon.GameLift.Model.Internal.MarshallTransformations;
using Amazon.GameLift.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GameLift
{
    /// <summary>
    /// Implementation for accessing GameLift
    ///
    /// Amazon GameLift Service 
    /// <para>
    ///  Amazon GameLift provides a range of multiplayer game hosting solutions. As a fully
    /// managed service, GameLift helps you:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Set up EC2-based computing resources and use GameLift FleetIQ to and deploy your game
    /// servers on low-cost, reliable Spot instances.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Track game server availability and route players into game sessions to minimize latency.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Automatically scale your resources to meet player demand and manage costs
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Optionally add FlexMatch matchmaking.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// With GameLift as a managed service, you have the option to deploy your custom game
    /// server or use Amazon GameLift Realtime Servers to quickly stand up lightweight game
    /// servers for your game. Realtime Servers provides an efficient game server framework
    /// with core Amazon GameLift infrastructure already built in.
    /// </para>
    ///  
    /// <para>
    ///  <b>Now in Public Preview:</b> 
    /// </para>
    ///  
    /// <para>
    /// Use GameLift FleetIQ as a standalone feature with EC2 instances and Auto Scaling groups.
    /// GameLift FleetIQ provides optimizations that make low-cost Spot instances viable for
    /// game hosting. This extension of GameLift FleetIQ gives you access to these optimizations
    /// while managing your EC2 instances and Auto Scaling groups within your own AWS account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Get Amazon GameLift Tools and Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// This reference guide describes the low-level service API for Amazon GameLift and provides
    /// links to language-specific SDK reference topics. See also <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-components.html">
    /// Amazon GameLift Tools and Resources</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>API Summary</b> 
    /// </para>
    ///  
    /// <para>
    /// The Amazon GameLift service API includes two key sets of actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Manage game sessions and player access -- Integrate this functionality into game client
    /// services in order to create new game sessions, retrieve information on existing game
    /// sessions; reserve a player slot in a game session, request matchmaking, etc.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configure and manage game server resources -- Manage your Amazon GameLift hosting
    /// resources, including builds, scripts, fleets, queues, and aliases. Set up matchmakers,
    /// configure auto-scaling, retrieve game logs, and get hosting and game metrics.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html">
    /// Task-based list of API actions</a> </b> 
    /// </para>
    /// </summary>
    public partial class AmazonGameLiftClient : AmazonServiceClient, IAmazonGameLift
    {
        private static IServiceMetadata serviceMetadata = new AmazonGameLiftMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonGameLiftClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameLiftConfig()) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameLiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(AmazonGameLiftConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGameLiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGameLiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials and an
        /// AmazonGameLiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(AWSCredentials credentials, AmazonGameLiftConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameLiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameLiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGameLiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameLiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameLiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGameLiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AcceptMatch

        /// <summary>
        /// Registers a player's acceptance or rejection of a proposed FlexMatch match. A matchmaking
        /// configuration may require player acceptance; if so, then matches built with that configuration
        /// cannot be completed unless all players accept the proposed match within a specified
        /// time limit. 
        /// 
        ///  
        /// <para>
        /// When FlexMatch builds a match, all the matchmaking tickets involved in the proposed
        /// match are placed into status <code>REQUIRES_ACCEPTANCE</code>. This is a trigger for
        /// your game to get acceptance from all players in the ticket. Acceptances are only valid
        /// for tickets when they are in this status; all other acceptances result in an error.
        /// </para>
        ///  
        /// <para>
        /// To register acceptance, specify the ticket ID, a response, and one or more players.
        /// Once all players have registered acceptance, the matchmaking tickets advance to status
        /// <code>PLACING</code>, where a new game session is created for the match. 
        /// </para>
        ///  
        /// <para>
        /// If any player rejects the match, or if acceptances are not received before a specified
        /// timeout, the proposed match is dropped. The matchmaking tickets are then handled in
        /// one of two ways: For tickets where one or more players rejected the match, the ticket
        /// status is returned to <code>SEARCHING</code> to find a new match. For tickets where
        /// one or more players failed to respond, the ticket status is set to <code>CANCELLED</code>,
        /// and processing is terminated. A new matchmaking request for these players can be submitted
        /// as needed. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-events.html">
        /// FlexMatch Events Reference</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptMatch service method.</param>
        /// 
        /// <returns>The response from the AcceptMatch service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        public virtual AcceptMatchResponse AcceptMatch(AcceptMatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptMatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMatchResponseUnmarshaller.Instance;

            return Invoke<AcceptMatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptMatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptMatch operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptMatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        public virtual IAsyncResult BeginAcceptMatch(AcceptMatchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptMatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptMatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptMatch.</param>
        /// 
        /// <returns>Returns a  AcceptMatchResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        public virtual AcceptMatchResponse EndAcceptMatch(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptMatchResponse>(asyncResult);
        }

        #endregion
        
        #region  ClaimGameServer

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Locates an available game server and temporarily reserves it to host gameplay and
        /// players. This action is called by a game client or client service (such as a matchmaker)
        /// to request hosting resources for a new game session. In response, GameLift FleetIQ
        /// searches for an available game server in the specified game server group, places the
        /// game server in "claimed" status for 60 seconds, and returns connection information
        /// back to the requester so that players can connect to the game server. 
        /// </para>
        ///  
        /// <para>
        /// There are two ways you can claim a game server. For the first option, you provide
        /// a game server group ID only, which prompts GameLift FleetIQ to search for an available
        /// game server in the specified group and claim it. With this option, GameLift FleetIQ
        /// attempts to consolidate gameplay on as few instances as possible to minimize hosting
        /// costs. For the second option, you request a specific game server by its ID. This option
        /// results in a less efficient claiming process because it does not take advantage of
        /// consolidation and may fail if the requested game server is unavailable. 
        /// </para>
        ///  
        /// <para>
        /// To claim a game server, identify a game server group and (optionally) a game server
        /// ID. If your game requires that game data be provided to the game server at the start
        /// of a game, such as a game map or player information, you can provide it in your claim
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// When a game server is successfully claimed, connection information is returned. A
        /// claimed game server's utilization status remains AVAILABLE, while the claim status
        /// is set to CLAIMED for up to 60 seconds. This time period allows the game server to
        /// be prompted to update its status to UTILIZED (using <a>UpdateGameServer</a>). If the
        /// game server's status is not updated within 60 seconds, the game server reverts to
        /// unclaimed status and is available to be claimed by another request.
        /// </para>
        ///  
        /// <para>
        /// If you try to claim a specific game server, this request will fail in the following
        /// cases: (1) if the game server utilization status is UTILIZED, (2) if the game server
        /// claim status is CLAIMED, or (3) if the instance that the game server is running on
        /// is flagged as draining.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClaimGameServer service method.</param>
        /// 
        /// <returns>The response from the ClaimGameServer service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.OutOfCapacityException">
        /// The specified game server group has no available game servers to fulfill a <code>ClaimGameServer</code>
        /// request. Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ClaimGameServer">REST API Reference for ClaimGameServer Operation</seealso>
        public virtual ClaimGameServerResponse ClaimGameServer(ClaimGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClaimGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClaimGameServerResponseUnmarshaller.Instance;

            return Invoke<ClaimGameServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ClaimGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClaimGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndClaimGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ClaimGameServer">REST API Reference for ClaimGameServer Operation</seealso>
        public virtual IAsyncResult BeginClaimGameServer(ClaimGameServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClaimGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClaimGameServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ClaimGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginClaimGameServer.</param>
        /// 
        /// <returns>Returns a  ClaimGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ClaimGameServer">REST API Reference for ClaimGameServer Operation</seealso>
        public virtual ClaimGameServerResponse EndClaimGameServer(IAsyncResult asyncResult)
        {
            return EndInvoke<ClaimGameServerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAlias

        /// <summary>
        /// Creates an alias for a fleet. In most situations, you can use an alias ID in place
        /// of a fleet ID. An alias provides a level of abstraction for a fleet that is useful
        /// when redirecting player traffic from one fleet to another, such as when updating your
        /// game build. 
        /// 
        ///  
        /// <para>
        /// Amazon GameLift supports two types of routing strategies for aliases: simple and terminal.
        /// A simple alias points to an active fleet. A terminal alias is used to display messaging
        /// or link to a URL instead of routing players to an active fleet. For example, you might
        /// use a terminal alias when a game version is no longer supported and you want to direct
        /// players to an upgrade site. 
        /// </para>
        ///  
        /// <para>
        /// To create a fleet alias, specify an alias name, routing strategy, and optional description.
        /// Each simple alias can point to only one fleet, but a fleet can have multiple aliases.
        /// If successful, a new alias record is returned, including an alias ID and an ARN. You
        /// can reassign an alias to another fleet by calling <code>UpdateAlias</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBuild

        /// <summary>
        /// Creates a new Amazon GameLift build resource for your game server binary files. Game
        /// server binaries must be combined into a zip file for use with Amazon GameLift. 
        /// 
        ///  <important> 
        /// <para>
        /// When setting up a new game build for GameLift, we recommend using the AWS CLI command
        /// <b> <a href="https://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a>
        /// </b>. This helper command combines two tasks: (1) it uploads your build files from
        /// a file directory to a GameLift Amazon S3 location, and (2) it creates a new build
        /// resource. 
        /// </para>
        ///  </important> 
        /// <para>
        /// The <code>CreateBuild</code> operation can used in the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a new game build with build files that are in an S3 location under an AWS
        /// account that you control. To use this option, you must first give Amazon GameLift
        /// access to the S3 bucket. With permissions in place, call <code>CreateBuild</code>
        /// and specify a build name, operating system, and the S3 storage location of your game
        /// build.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To directly upload your build files to a GameLift S3 location. To use this option,
        /// first call <code>CreateBuild</code> and specify a build name and operating system.
        /// This action creates a new build resource and also returns an S3 location with temporary
        /// access credentials. Use the credentials to manually upload your build files to the
        /// specified S3 location. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
        /// Objects</a> in the <i>Amazon S3 Developer Guide</i>. Build files can be uploaded to
        /// the GameLift S3 location once only; that can't be updated. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, this operation creates a new build resource with a unique build ID
        /// and places it in <code>INITIALIZED</code> status. A build must be in <code>READY</code>
        /// status before you can create fleets with it.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">Uploading
        /// Your Game</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
        /// Create a Build with Files in Amazon S3</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild service method.</param>
        /// 
        /// <returns>The response from the CreateBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateBuild">REST API Reference for CreateBuild Operation</seealso>
        public virtual CreateBuildResponse CreateBuild(CreateBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return Invoke<CreateBuildResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateBuild">REST API Reference for CreateBuild Operation</seealso>
        public virtual IAsyncResult BeginCreateBuild(CreateBuildRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBuild.</param>
        /// 
        /// <returns>Returns a  CreateBuildResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateBuild">REST API Reference for CreateBuild Operation</seealso>
        public virtual CreateBuildResponse EndCreateBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFleet

        /// <summary>
        /// Creates a new fleet to run your game servers. whether they are custom game builds
        /// or Realtime Servers with game-specific script. A fleet is a set of Amazon Elastic
        /// Compute Cloud (Amazon EC2) instances, each of which can host multiple game sessions.
        /// When creating a fleet, you choose the hardware specifications, set some configuration
        /// options, and specify the game server to deploy on the new fleet. 
        /// 
        ///  
        /// <para>
        /// To create a new fleet, provide the following: (1) a fleet name, (2) an EC2 instance
        /// type and fleet type (spot or on-demand), (3) the build ID for your game build or script
        /// ID if using Realtime Servers, and (4) a runtime configuration, which determines how
        /// game servers will run on each instance in the fleet. 
        /// </para>
        ///  
        /// <para>
        /// If the <code>CreateFleet</code> call is successful, Amazon GameLift performs the following
        /// tasks. You can track the process of a fleet by checking the fleet status or by monitoring
        /// fleet creation events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a fleet resource. Status: <code>NEW</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Begins writing events to the fleet event log, which can be accessed in the Amazon
        /// GameLift console.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sets the fleet's target capacity to 1 (desired instances), which triggers Amazon GameLift
        /// to start one new EC2 instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Downloads the game build or Realtime script to the new instance and installs it. Statuses:
        /// <code>DOWNLOADING</code>, <code>VALIDATING</code>, <code>BUILDING</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Starts launching server processes on the instance. If the fleet is configured to run
        /// multiple server processes per instance, Amazon GameLift staggers each process launch
        /// by a few seconds. Status: <code>ACTIVATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sets the fleet's status to <code>ACTIVE</code> as soon as one server process is ready
        /// to host a game session.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// Up Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html#fleets-creating-debug-creation">Debug
        /// Fleet Creation Issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGameServerGroup

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Creates a GameLift FleetIQ game server group to manage a collection of EC2 instances
        /// for game hosting. In addition to creating the game server group, this action also
        /// creates an Auto Scaling group in your AWS account and establishes a link between the
        /// two groups. You have full control over configuration of the Auto Scaling group, but
        /// GameLift FleetIQ routinely certain Auto Scaling group properties in order to optimize
        /// the group's instances for low-cost game hosting. You can view the status of your game
        /// server groups in the GameLift Console. Game server group metrics and events are emitted
        /// to Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// Prior creating a new game server group, you must set up the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An EC2 launch template. The template provides configuration settings for a set of
        /// EC2 instances and includes the game server build that you want to deploy and run on
        /// each instance. For more information on creating a launch template, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">
        /// Launching an Instance from a Launch Template</a> in the <i>Amazon EC2 User Guide</i>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An IAM role. The role sets up limited access to your AWS account, allowing GameLift
        /// FleetIQ to create and manage the EC2 Auto Scaling group, get instance data, and emit
        /// metrics and events to CloudWatch. For more information on setting up an IAM permissions
        /// policy with principal access for GameLift, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-bucket-user-policy-specifying-principal-intro.html">
        /// Specifying a Principal in a Policy</a> in the <i>Amazon S3 Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create a new game server group, provide a name and specify the IAM role and EC2
        /// launch template. You also need to provide a list of instance types to be used in the
        /// group and set initial maximum and minimum limits on the group's instance count. You
        /// can optionally set an autoscaling policy with target tracking based on a GameLift
        /// FleetIQ metric.
        /// </para>
        ///  
        /// <para>
        /// Once the game server group and corresponding Auto Scaling group are created, you have
        /// full access to change the Auto Scaling group's configuration as needed. Keep in mind,
        /// however, that some properties are periodically updated by GameLift FleetIQ as it balances
        /// the group's instances based on availability and cost.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-asgroups.html">Updating
        /// a GameLift FleetIQ-Linked Auto Scaling Group</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGameServerGroup service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameServerGroup">REST API Reference for CreateGameServerGroup Operation</seealso>
        public virtual CreateGameServerGroupResponse CreateGameServerGroup(CreateGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGameServerGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameServerGroup">REST API Reference for CreateGameServerGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateGameServerGroup(CreateGameServerGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameServerGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGameServerGroup.</param>
        /// 
        /// <returns>Returns a  CreateGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameServerGroup">REST API Reference for CreateGameServerGroup Operation</seealso>
        public virtual CreateGameServerGroupResponse EndCreateGameServerGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGameServerGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGameSession

        /// <summary>
        /// Creates a multiplayer game session for players. This action creates a game session
        /// record and assigns an available server process in the specified fleet to host the
        /// game session. A fleet must have an <code>ACTIVE</code> status before a game session
        /// can be created in it.
        /// 
        ///  
        /// <para>
        /// To create a game session, specify either fleet ID or alias ID and indicate a maximum
        /// number of players to allow in the game session. You can also provide a name and game-specific
        /// properties for this game session. If successful, a <a>GameSession</a> object is returned
        /// containing the game session properties and other settings you specified.
        /// </para>
        ///  
        /// <para>
        ///  <b>Idempotency tokens.</b> You can add a token that uniquely identifies game session
        /// requests. This is useful for ensuring that game session requests are idempotent. Multiple
        /// requests with the same idempotency token are processed only once; subsequent requests
        /// return the original result. All response values are the same with the exception of
        /// game session status, which may change.
        /// </para>
        ///  
        /// <para>
        ///  <b>Resource creation limits.</b> If you are creating a game session on a fleet with
        /// a resource creation limit policy in force, then you must specify a creator ID. Without
        /// this ID, Amazon GameLift has no way to evaluate the policy for this new game session
        /// request.
        /// </para>
        ///  
        /// <para>
        ///  <b>Player acceptance policy.</b> By default, newly created game sessions are open
        /// to new players. You can restrict new player access by using <a>UpdateGameSession</a>
        /// to change the game session's player session creation policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Game session logs.</b> Logs are retained for all active game sessions for 14 days.
        /// To access the logs, call <a>GetGameSessionLogUrl</a> to download the log files.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession service method.</param>
        /// 
        /// <returns>The response from the CreateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.FleetCapacityExceededException">
        /// The specified fleet has no available instances to fulfill a <code>CreateGameSession</code>
        /// request. Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.IdempotentParameterMismatchException">
        /// A game session with this custom ID string already exists in this fleet. Resolve this
        /// conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        public virtual CreateGameSessionResponse CreateGameSession(CreateGameSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGameSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        public virtual IAsyncResult BeginCreateGameSession(CreateGameSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGameSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGameSession.</param>
        /// 
        /// <returns>Returns a  CreateGameSessionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        public virtual CreateGameSessionResponse EndCreateGameSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGameSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGameSessionQueue

        /// <summary>
        /// Establishes a new queue for processing requests to place new game sessions. A queue
        /// identifies where new game sessions can be hosted -- by specifying a list of destinations
        /// (fleets or aliases) -- and how long requests can wait in the queue before timing out.
        /// You can set up a queue to try to place game sessions on fleets in multiple Regions.
        /// To add placement requests to a queue, call <a>StartGameSessionPlacement</a> and reference
        /// the queue name.
        /// 
        ///  
        /// <para>
        ///  <b>Destination order.</b> When processing a request for a game session, Amazon GameLift
        /// tries each destination in order until it finds one with available resources to host
        /// the new game session. A queue's default order is determined by how destinations are
        /// listed. The default order is overridden when a game session placement request provides
        /// player latency information. Player latency information enables Amazon GameLift to
        /// prioritize destinations where players report the lowest average latency, as a result
        /// placing the new game session where the majority of players will have the best possible
        /// gameplay experience.
        /// </para>
        ///  
        /// <para>
        ///  <b>Player latency policies.</b> For placement requests containing player latency
        /// information, use player latency policies to protect individual players from very high
        /// latencies. With a latency cap, even when a destination can deliver a low latency for
        /// most players, the game is not placed where any individual player is reporting latency
        /// higher than a policy's maximum. A queue can have multiple latency policies, which
        /// are enforced consecutively starting with the policy with the lowest latency cap. Use
        /// multiple policies to gradually relax latency controls; for example, you might set
        /// a policy with a low latency cap for the first 60 seconds, a second policy with a higher
        /// cap for the next 60 seconds, etc. 
        /// </para>
        ///  
        /// <para>
        /// To create a new queue, provide a name, timeout value, a list of destinations and,
        /// if desired, a set of latency policies. If successful, a new queue object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-design.html">
        /// Design a Game Session Queue</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-creating.html">
        /// Create a Game Session Queue</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSessionQueue service method.</param>
        /// 
        /// <returns>The response from the CreateGameSessionQueue service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        public virtual CreateGameSessionQueueResponse CreateGameSessionQueue(CreateGameSessionQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionQueueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSessionQueue operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGameSessionQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        public virtual IAsyncResult BeginCreateGameSessionQueue(CreateGameSessionQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGameSessionQueue.</param>
        /// 
        /// <returns>Returns a  CreateGameSessionQueueResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        public virtual CreateGameSessionQueueResponse EndCreateGameSessionQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGameSessionQueueResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMatchmakingConfiguration

        /// <summary>
        /// Defines a new matchmaking configuration for use with FlexMatch. A matchmaking configuration
        /// sets out guidelines for matching players and getting the matches into games. You can
        /// set up multiple matchmaking configurations to handle the scenarios needed for your
        /// game. Each matchmaking ticket (<a>StartMatchmaking</a> or <a>StartMatchBackfill</a>)
        /// specifies a configuration for the match and provides player attributes to support
        /// the configuration being used. 
        /// 
        ///  
        /// <para>
        /// To create a matchmaking configuration, at a minimum you must specify the following:
        /// configuration name; a rule set that governs how to evaluate players and find acceptable
        /// matches; a game session queue to use when placing a new game session for the match;
        /// and the maximum time allowed for a matchmaking attempt.
        /// </para>
        ///  
        /// <para>
        /// There are two ways to track the progress of matchmaking tickets: (1) polling ticket
        /// status with <a>DescribeMatchmaking</a>; or (2) receiving notifications with Amazon
        /// Simple Notification Service (SNS). To use notifications, you first need to set up
        /// an SNS topic to receive the notifications, and provide the topic ARN in the matchmaking
        /// configuration. Since notifications promise only "best effort" delivery, we recommend
        /// calling <code>DescribeMatchmaking</code> if no notifications are received within 30
        /// seconds.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-configuration.html">
        /// Design a FlexMatch Matchmaker</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-notification.html">
        /// Setting up Notifications for Matchmaking</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateMatchmakingConfiguration service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingConfiguration">REST API Reference for CreateMatchmakingConfiguration Operation</seealso>
        public virtual CreateMatchmakingConfigurationResponse CreateMatchmakingConfiguration(CreateMatchmakingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMatchmakingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingConfiguration">REST API Reference for CreateMatchmakingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateMatchmakingConfiguration(CreateMatchmakingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMatchmakingConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateMatchmakingConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingConfiguration">REST API Reference for CreateMatchmakingConfiguration Operation</seealso>
        public virtual CreateMatchmakingConfigurationResponse EndCreateMatchmakingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMatchmakingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMatchmakingRuleSet

        /// <summary>
        /// Creates a new rule set for FlexMatch matchmaking. A rule set describes the type of
        /// match to create, such as the number and size of teams. It also sets the parameters
        /// for acceptable player matches, such as minimum skill level or character type. A rule
        /// set is used by a <a>MatchmakingConfiguration</a>. 
        /// 
        ///  
        /// <para>
        /// To create a matchmaking rule set, provide unique rule set name and the rule set body
        /// in JSON format. Rule sets must be defined in the same Region as the matchmaking configuration
        /// they are used with.
        /// </para>
        ///  
        /// <para>
        /// Since matchmaking rule sets cannot be edited, it is a good idea to check the rule
        /// set syntax using <a>ValidateMatchmakingRuleSet</a> before creating a new rule set.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-configuration.html">Design
        /// a Matchmaker</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-intro.html">Matchmaking
        /// with FlexMatch</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingRuleSet service method.</param>
        /// 
        /// <returns>The response from the CreateMatchmakingRuleSet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingRuleSet">REST API Reference for CreateMatchmakingRuleSet Operation</seealso>
        public virtual CreateMatchmakingRuleSetResponse CreateMatchmakingRuleSet(CreateMatchmakingRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingRuleSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingRuleSet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMatchmakingRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingRuleSet">REST API Reference for CreateMatchmakingRuleSet Operation</seealso>
        public virtual IAsyncResult BeginCreateMatchmakingRuleSet(CreateMatchmakingRuleSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMatchmakingRuleSet.</param>
        /// 
        /// <returns>Returns a  CreateMatchmakingRuleSetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingRuleSet">REST API Reference for CreateMatchmakingRuleSet Operation</seealso>
        public virtual CreateMatchmakingRuleSetResponse EndCreateMatchmakingRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMatchmakingRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePlayerSession

        /// <summary>
        /// Reserves an open player slot in an active game session. Before a player can be added,
        /// a game session must have an <code>ACTIVE</code> status, have a creation policy of
        /// <code>ALLOW_ALL</code>, and have an open player slot. To add a group of players to
        /// a game session, use <a>CreatePlayerSessions</a>. When the player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// string of player data. If successful, a slot is reserved in the game session for the
        /// player and a new <a>PlayerSession</a> object is returned. Player sessions cannot be
        /// updated. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreatePlayerSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreatePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="gameSessionId">A unique identifier for the game session to add a player to.</param>
        /// <param name="playerId">A unique identifier for a player. Player IDs are developer-defined.</param>
        /// 
        /// <returns>The response from the CreatePlayerSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Resolve the conflict before
        /// retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        public virtual CreatePlayerSessionResponse CreatePlayerSession(string gameSessionId, string playerId)
        {
            var request = new CreatePlayerSessionRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerId = playerId;
            return CreatePlayerSession(request);
        }


        /// <summary>
        /// Reserves an open player slot in an active game session. Before a player can be added,
        /// a game session must have an <code>ACTIVE</code> status, have a creation policy of
        /// <code>ALLOW_ALL</code>, and have an open player slot. To add a group of players to
        /// a game session, use <a>CreatePlayerSessions</a>. When the player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// string of player data. If successful, a slot is reserved in the game session for the
        /// player and a new <a>PlayerSession</a> object is returned. Player sessions cannot be
        /// updated. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreatePlayerSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreatePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession service method.</param>
        /// 
        /// <returns>The response from the CreatePlayerSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Resolve the conflict before
        /// retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        public virtual CreatePlayerSessionResponse CreatePlayerSession(CreatePlayerSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlayerSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlayerSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        public virtual IAsyncResult BeginCreatePlayerSession(CreatePlayerSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlayerSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlayerSession.</param>
        /// 
        /// <returns>Returns a  CreatePlayerSessionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        public virtual CreatePlayerSessionResponse EndCreatePlayerSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePlayerSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePlayerSessions

        /// <summary>
        /// Reserves open slots in a game session for a group of players. Before players can be
        /// added, a game session must have an <code>ACTIVE</code> status, have a creation policy
        /// of <code>ALLOW_ALL</code>, and have an open player slot. To add a single player to
        /// a game session, use <a>CreatePlayerSession</a>. When a player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID, a list of player IDs, and optionally
        /// a set of player data strings. If successful, a slot is reserved in the game session
        /// for each player and a set of new <a>PlayerSession</a> objects is returned. Player
        /// sessions cannot be updated.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreatePlayerSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreatePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="gameSessionId">A unique identifier for the game session to add players to.</param>
        /// <param name="playerIds">List of unique identifiers for the players to be added.</param>
        /// 
        /// <returns>The response from the CreatePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Resolve the conflict before
        /// retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        public virtual CreatePlayerSessionsResponse CreatePlayerSessions(string gameSessionId, List<string> playerIds)
        {
            var request = new CreatePlayerSessionsRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerIds = playerIds;
            return CreatePlayerSessions(request);
        }


        /// <summary>
        /// Reserves open slots in a game session for a group of players. Before players can be
        /// added, a game session must have an <code>ACTIVE</code> status, have a creation policy
        /// of <code>ALLOW_ALL</code>, and have an open player slot. To add a single player to
        /// a game session, use <a>CreatePlayerSession</a>. When a player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID, a list of player IDs, and optionally
        /// a set of player data strings. If successful, a slot is reserved in the game session
        /// for each player and a set of new <a>PlayerSession</a> objects is returned. Player
        /// sessions cannot be updated.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreatePlayerSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreatePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions service method.</param>
        /// 
        /// <returns>The response from the CreatePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Resolve the conflict before
        /// retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        public virtual CreatePlayerSessionsResponse CreatePlayerSessions(CreatePlayerSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlayerSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        public virtual IAsyncResult BeginCreatePlayerSessions(CreatePlayerSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlayerSessions.</param>
        /// 
        /// <returns>Returns a  CreatePlayerSessionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        public virtual CreatePlayerSessionsResponse EndCreatePlayerSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePlayerSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateScript

        /// <summary>
        /// Creates a new script record for your Realtime Servers script. Realtime scripts are
        /// JavaScript that provide configuration settings and optional custom game logic for
        /// your game. The script is deployed when you create a Realtime Servers fleet to host
        /// your game sessions. Script logic is executed during an active game session. 
        /// 
        ///  
        /// <para>
        /// To create a new script record, specify a script name and provide the script file(s).
        /// The script files and all dependencies must be zipped into a single file. You can pull
        /// the zip file from either of these locations: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A locally available directory. Use the <i>ZipFile</i> parameter for this option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Simple Storage Service (Amazon S3) bucket under your AWS account. Use the
        /// <i>StorageLocation</i> parameter for this option. You'll need to have an Identity
        /// Access Management (IAM) role that allows the Amazon GameLift service to access your
        /// S3 bucket. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the call is successful, a new script record is created with a unique script ID.
        /// If the script file is provided as a local file, the file is uploaded to an Amazon
        /// GameLift-owned S3 bucket and the script record's storage location reflects this location.
        /// If the script file is provided as an S3 bucket, Amazon GameLift accesses the file
        /// at this storage location as needed for deployment.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">Set
        /// Up a Role for Amazon GameLift Access</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScript service method.</param>
        /// 
        /// <returns>The response from the CreateScript service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return Invoke<CreateScriptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScript operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual IAsyncResult BeginCreateScript(CreateScriptRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScript.</param>
        /// 
        /// <returns>Returns a  CreateScriptResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual CreateScriptResponse EndCreateScript(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateScriptResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcPeeringAuthorization

        /// <summary>
        /// Requests authorization to create or delete a peer connection between the VPC for your
        /// Amazon GameLift fleet and a virtual private cloud (VPC) in your AWS account. VPC peering
        /// enables the game servers on your fleet to communicate directly with other AWS resources.
        /// Once you've received authorization, call <a>CreateVpcPeeringConnection</a> to establish
        /// the peering connection. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Fleets</a>.
        /// 
        ///  
        /// <para>
        /// You can peer with VPCs that are owned by any AWS account you have access to, including
        /// the account that you use to manage your Amazon GameLift fleets. You cannot peer with
        /// VPCs that are in different Regions.
        /// </para>
        ///  
        /// <para>
        /// To request authorization to create a connection, call this operation from the AWS
        /// account with the VPC that you want to peer to your Amazon GameLift fleet. For example,
        /// to enable your game servers to retrieve data from a DynamoDB table, use the account
        /// that manages that DynamoDB resource. Identify the following values: (1) The ID of
        /// the VPC that you want to peer with, and (2) the ID of the AWS account that you use
        /// to manage Amazon GameLift. If successful, VPC peering is authorized for the specified
        /// VPC. 
        /// </para>
        ///  
        /// <para>
        /// To request authorization to delete a connection, call this operation from the AWS
        /// account with the VPC that is peered with your Amazon GameLift fleet. Identify the
        /// following values: (1) VPC ID that you want to delete the peering connection for, and
        /// (2) ID of the AWS account that you use to manage Amazon GameLift. 
        /// </para>
        ///  
        /// <para>
        /// The authorization remains valid for 24 hours unless it is canceled by a call to <a>DeleteVpcPeeringAuthorization</a>.
        /// You must create or delete the peering connection while the authorization is valid.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringAuthorization service method.</param>
        /// 
        /// <returns>The response from the CreateVpcPeeringAuthorization service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        public virtual CreateVpcPeeringAuthorizationResponse CreateVpcPeeringAuthorization(CreateVpcPeeringAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringAuthorizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringAuthorization operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcPeeringAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        public virtual IAsyncResult BeginCreateVpcPeeringAuthorization(CreateVpcPeeringAuthorizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcPeeringAuthorization.</param>
        /// 
        /// <returns>Returns a  CreateVpcPeeringAuthorizationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        public virtual CreateVpcPeeringAuthorizationResponse EndCreateVpcPeeringAuthorization(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcPeeringAuthorizationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcPeeringConnection

        /// <summary>
        /// Establishes a VPC peering connection between a virtual private cloud (VPC) in an AWS
        /// account with the VPC for your Amazon GameLift fleet. VPC peering enables the game
        /// servers on your fleet to communicate directly with other AWS resources. You can peer
        /// with VPCs in any AWS account that you have access to, including the account that you
        /// use to manage your Amazon GameLift fleets. You cannot peer with VPCs that are in different
        /// Regions. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Fleets</a>.
        /// 
        ///  
        /// <para>
        /// Before calling this operation to establish the peering connection, you first need
        /// to call <a>CreateVpcPeeringAuthorization</a> and identify the VPC you want to peer
        /// with. Once the authorization for the specified VPC is issued, you have 24 hours to
        /// establish the connection. These two operations handle all tasks necessary to peer
        /// the two VPCs, including acceptance, updating routing tables, etc. 
        /// </para>
        ///  
        /// <para>
        /// To establish the connection, call this operation from the AWS account that is used
        /// to manage the Amazon GameLift fleets. Identify the following values: (1) The ID of
        /// the fleet you want to be enable a VPC peering connection for; (2) The AWS account
        /// with the VPC that you want to peer with; and (3) The ID of the VPC you want to peer
        /// with. This operation is asynchronous. If successful, a <a>VpcPeeringConnection</a>
        /// request is created. You can use continuous polling to track the request's status using
        /// <a>DescribeVpcPeeringConnections</a>, or by monitoring fleet events for success or
        /// failure using <a>DescribeFleetEvents</a>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpcPeeringConnection service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        public virtual CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpcPeeringConnectionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        public virtual CreateVpcPeeringConnectionResponse EndCreateVpcPeeringConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcPeeringConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAlias

        /// <summary>
        /// Deletes an alias. This action removes all record of the alias. Game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasId">A unique identifier of the alias that you want to delete. You can use either the alias ID or ARN value.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse DeleteAlias(string aliasId)
        {
            var request = new DeleteAliasRequest();
            request.AliasId = aliasId;
            return DeleteAlias(request);
        }


        /// <summary>
        /// Deletes an alias. This action removes all record of the alias. Game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlias(DeleteAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse EndDeleteAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBuild

        /// <summary>
        /// Deletes a build. This action permanently deletes the build resource and any uploaded
        /// build files. Deleting a build does not affect the status of any active fleets using
        /// the build, but you can no longer create new fleets with the deleted build.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify the build ID. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="buildId">A unique identifier for a build to delete. You can use either the build ID or ARN value. </param>
        /// 
        /// <returns>The response from the DeleteBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        public virtual DeleteBuildResponse DeleteBuild(string buildId)
        {
            var request = new DeleteBuildRequest();
            request.BuildId = buildId;
            return DeleteBuild(request);
        }


        /// <summary>
        /// Deletes a build. This action permanently deletes the build resource and any uploaded
        /// build files. Deleting a build does not affect the status of any active fleets using
        /// the build, but you can no longer create new fleets with the deleted build.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify the build ID. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild service method.</param>
        /// 
        /// <returns>The response from the DeleteBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        public virtual DeleteBuildResponse DeleteBuild(DeleteBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return Invoke<DeleteBuildResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        public virtual IAsyncResult BeginDeleteBuild(DeleteBuildRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBuild.</param>
        /// 
        /// <returns>Returns a  DeleteBuildResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        public virtual DeleteBuildResponse EndDeleteBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFleet

        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a>CreateVpcPeeringAuthorization</a>.
        /// You do not need to explicitly delete the VPC peering connection--this is done as part
        /// of the delete fleet process.
        /// </para>
        ///  
        /// <para>
        /// This action removes the fleet and its resources. Once a fleet is deleted, you can
        /// no longer use any of the resource in that fleet.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="fleetId">A unique identifier for a fleet to be deleted. You can use either the fleet ID or ARN value.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual DeleteFleetResponse DeleteFleet(string fleetId)
        {
            var request = new DeleteFleetRequest();
            request.FleetId = fleetId;
            return DeleteFleet(request);
        }


        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a>CreateVpcPeeringAuthorization</a>.
        /// You do not need to explicitly delete the VPC peering connection--this is done as part
        /// of the delete fleet process.
        /// </para>
        ///  
        /// <para>
        /// This action removes the fleet and its resources. Once a fleet is deleted, you can
        /// no longer use any of the resource in that fleet.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGameServerGroup

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Terminates a game server group and permanently deletes the game server group record.
        /// You have several options for how these resources are impacted when deleting the game
        /// server group. Depending on the type of delete action selected, this action may affect
        /// three types of resources: the game server group, the corresponding Auto Scaling group,
        /// and all game servers currently running in the group. 
        /// </para>
        ///  
        /// <para>
        /// To delete a game server group, identify the game server group to delete and specify
        /// the type of delete action to initiate. Game server groups can only be deleted if they
        /// are in ACTIVE or ERROR status.
        /// </para>
        ///  
        /// <para>
        /// If the delete request is successful, a series of actions are kicked off. The game
        /// server group status is changed to DELETE_SCHEDULED, which prevents new game servers
        /// from being registered and stops autoscaling activity. Once all game servers in the
        /// game server group are de-registered, GameLift FleetIQ can begin deleting resources.
        /// If any of the delete actions fail, the game server group is placed in ERROR status.
        /// </para>
        ///  
        /// <para>
        /// GameLift FleetIQ emits delete events to Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGameServerGroup service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameServerGroup">REST API Reference for DeleteGameServerGroup Operation</seealso>
        public virtual DeleteGameServerGroupResponse DeleteGameServerGroup(DeleteGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGameServerGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameServerGroup">REST API Reference for DeleteGameServerGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGameServerGroup(DeleteGameServerGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameServerGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGameServerGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameServerGroup">REST API Reference for DeleteGameServerGroup Operation</seealso>
        public virtual DeleteGameServerGroupResponse EndDeleteGameServerGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGameServerGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGameSessionQueue

        /// <summary>
        /// Deletes a game session queue. This action means that any <a>StartGameSessionPlacement</a>
        /// requests that reference this queue will fail. To delete a queue, specify the queue
        /// name.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-intro.html">
        /// Using Multi-Region Queues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameSessionQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteGameSessionQueue service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameSessionQueue">REST API Reference for DeleteGameSessionQueue Operation</seealso>
        public virtual DeleteGameSessionQueueResponse DeleteGameSessionQueue(DeleteGameSessionQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteGameSessionQueueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameSessionQueue operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGameSessionQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameSessionQueue">REST API Reference for DeleteGameSessionQueue Operation</seealso>
        public virtual IAsyncResult BeginDeleteGameSessionQueue(DeleteGameSessionQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGameSessionQueue.</param>
        /// 
        /// <returns>Returns a  DeleteGameSessionQueueResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameSessionQueue">REST API Reference for DeleteGameSessionQueue Operation</seealso>
        public virtual DeleteGameSessionQueueResponse EndDeleteGameSessionQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGameSessionQueueResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMatchmakingConfiguration

        /// <summary>
        /// Permanently removes a FlexMatch matchmaking configuration. To delete, specify the
        /// configuration name. A matchmaking configuration cannot be deleted if it is being used
        /// in any active matchmaking tickets.
        /// 
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteMatchmakingConfiguration service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingConfiguration">REST API Reference for DeleteMatchmakingConfiguration Operation</seealso>
        public virtual DeleteMatchmakingConfigurationResponse DeleteMatchmakingConfiguration(DeleteMatchmakingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchmakingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMatchmakingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingConfiguration">REST API Reference for DeleteMatchmakingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteMatchmakingConfiguration(DeleteMatchmakingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMatchmakingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteMatchmakingConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingConfiguration">REST API Reference for DeleteMatchmakingConfiguration Operation</seealso>
        public virtual DeleteMatchmakingConfigurationResponse EndDeleteMatchmakingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMatchmakingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMatchmakingRuleSet

        /// <summary>
        /// Deletes an existing matchmaking rule set. To delete the rule set, provide the rule
        /// set name. Rule sets cannot be deleted if they are currently being used by a matchmaking
        /// configuration. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingRuleSet service method.</param>
        /// 
        /// <returns>The response from the DeleteMatchmakingRuleSet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingRuleSet">REST API Reference for DeleteMatchmakingRuleSet Operation</seealso>
        public virtual DeleteMatchmakingRuleSetResponse DeleteMatchmakingRuleSet(DeleteMatchmakingRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchmakingRuleSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingRuleSet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMatchmakingRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingRuleSet">REST API Reference for DeleteMatchmakingRuleSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteMatchmakingRuleSet(DeleteMatchmakingRuleSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMatchmakingRuleSet.</param>
        /// 
        /// <returns>Returns a  DeleteMatchmakingRuleSetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingRuleSet">REST API Reference for DeleteMatchmakingRuleSet Operation</seealso>
        public virtual DeleteMatchmakingRuleSetResponse EndDeleteMatchmakingRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMatchmakingRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteScalingPolicy

        /// <summary>
        /// Deletes a fleet scaling policy. This action means that the policy is no longer in
        /// force and removes all record of it. To delete a scaling policy, specify both the scaling
        /// policy name and the fleet ID it is associated with.
        /// 
        ///  
        /// <para>
        /// To temporarily suspend scaling policies, call <a>StopFleetActions</a>. This operation
        /// suspends all policies for the fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manage scaling policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Manage fleet actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteScalingPolicy service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        public virtual DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteScalingPolicy(DeleteScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScalingPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteScalingPolicyResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        public virtual DeleteScalingPolicyResponse EndDeleteScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteScript

        /// <summary>
        /// Deletes a Realtime script. This action permanently deletes the script record. If script
        /// files were uploaded, they are also deleted (files stored in an S3 bucket are not deleted).
        /// 
        /// 
        ///  
        /// <para>
        /// To delete a script, specify the script ID. Before deleting a script, be sure to terminate
        /// all fleets that are deployed with the script being deleted. Fleet instances periodically
        /// check for script updates, and if the script record no longer exists, the instance
        /// will go into an error state and be unable to host game sessions.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScript service method.</param>
        /// 
        /// <returns>The response from the DeleteScript service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScript">REST API Reference for DeleteScript Operation</seealso>
        public virtual DeleteScriptResponse DeleteScript(DeleteScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScriptResponseUnmarshaller.Instance;

            return Invoke<DeleteScriptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScript operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScript">REST API Reference for DeleteScript Operation</seealso>
        public virtual IAsyncResult BeginDeleteScript(DeleteScriptRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScriptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScript.</param>
        /// 
        /// <returns>Returns a  DeleteScriptResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScript">REST API Reference for DeleteScript Operation</seealso>
        public virtual DeleteScriptResponse EndDeleteScript(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScriptResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcPeeringAuthorization

        /// <summary>
        /// Cancels a pending VPC peering authorization for the specified VPC. If you need to
        /// delete an existing VPC peering connection, call <a>DeleteVpcPeeringConnection</a>.
        /// 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringAuthorization service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        public virtual DeleteVpcPeeringAuthorizationResponse DeleteVpcPeeringAuthorization(DeleteVpcPeeringAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringAuthorizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringAuthorization operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcPeeringAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        public virtual IAsyncResult BeginDeleteVpcPeeringAuthorization(DeleteVpcPeeringAuthorizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcPeeringAuthorization.</param>
        /// 
        /// <returns>Returns a  DeleteVpcPeeringAuthorizationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        public virtual DeleteVpcPeeringAuthorizationResponse EndDeleteVpcPeeringAuthorization(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcPeeringAuthorizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcPeeringConnection

        /// <summary>
        /// Removes a VPC peering connection. To delete the connection, you must have a valid
        /// authorization for the VPC peering connection that you want to delete. You can check
        /// for an authorization by calling <a>DescribeVpcPeeringAuthorizations</a> or request
        /// a new one using <a>CreateVpcPeeringAuthorization</a>. 
        /// 
        ///  
        /// <para>
        /// Once a valid authorization exists, call this operation from the AWS account that is
        /// used to manage the Amazon GameLift fleets. Identify the connection to delete by the
        /// connection ID and fleet ID. If successful, the connection is removed. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringConnection service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        public virtual DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpcPeeringConnectionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        public virtual DeleteVpcPeeringConnectionResponse EndDeleteVpcPeeringConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcPeeringConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterGameServer

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Removes the game server resource from the game server group. As a result of this action,
        /// the de-registered game server can no longer be claimed and will not returned in a
        /// list of active game servers. 
        /// </para>
        ///  
        /// <para>
        /// To de-register a game server, specify the game server group and game server ID. If
        /// successful, this action emits a CloudWatch event with termination time stamp and reason.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterGameServer service method.</param>
        /// 
        /// <returns>The response from the DeregisterGameServer service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeregisterGameServer">REST API Reference for DeregisterGameServer Operation</seealso>
        public virtual DeregisterGameServerResponse DeregisterGameServer(DeregisterGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGameServerResponseUnmarshaller.Instance;

            return Invoke<DeregisterGameServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeregisterGameServer">REST API Reference for DeregisterGameServer Operation</seealso>
        public virtual IAsyncResult BeginDeregisterGameServer(DeregisterGameServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGameServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterGameServer.</param>
        /// 
        /// <returns>Returns a  DeregisterGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeregisterGameServer">REST API Reference for DeregisterGameServer Operation</seealso>
        public virtual DeregisterGameServerResponse EndDeregisterGameServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterGameServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlias

        /// <summary>
        /// Retrieves properties for an alias. This operation returns all alias metadata and settings.
        /// To get an alias's target fleet ID only, use <code>ResolveAlias</code>. 
        /// 
        ///  
        /// <para>
        /// To get alias properties, specify the alias ID. If successful, the requested alias
        /// record is returned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasId">The unique identifier for the fleet alias that you want to retrieve. You can use either the alias ID or ARN value. </param>
        /// 
        /// <returns>The response from the DescribeAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        public virtual DescribeAliasResponse DescribeAlias(string aliasId)
        {
            var request = new DescribeAliasRequest();
            request.AliasId = aliasId;
            return DescribeAlias(request);
        }


        /// <summary>
        /// Retrieves properties for an alias. This operation returns all alias metadata and settings.
        /// To get an alias's target fleet ID only, use <code>ResolveAlias</code>. 
        /// 
        ///  
        /// <para>
        /// To get alias properties, specify the alias ID. If successful, the requested alias
        /// record is returned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        public virtual DescribeAliasResponse DescribeAlias(DescribeAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        public virtual IAsyncResult BeginDescribeAlias(DescribeAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlias.</param>
        /// 
        /// <returns>Returns a  DescribeAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        public virtual DescribeAliasResponse EndDescribeAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBuild

        /// <summary>
        /// Retrieves properties for a custom game build. To request a build resource, specify
        /// a build ID. If successful, an object containing the build properties is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="buildId">A unique identifier for a build to retrieve properties for. You can use either the build ID or ARN value. </param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        public virtual DescribeBuildResponse DescribeBuild(string buildId)
        {
            var request = new DescribeBuildRequest();
            request.BuildId = buildId;
            return DescribeBuild(request);
        }


        /// <summary>
        /// Retrieves properties for a custom game build. To request a build resource, specify
        /// a build ID. If successful, an object containing the build properties is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild service method.</param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        public virtual DescribeBuildResponse DescribeBuild(DescribeBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return Invoke<DescribeBuildResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        public virtual IAsyncResult BeginDescribeBuild(DescribeBuildRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBuild.</param>
        /// 
        /// <returns>Returns a  DescribeBuildResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        public virtual DescribeBuildResponse EndDescribeBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEC2InstanceLimits

        /// <summary>
        /// Retrieves the following information for the specified EC2 instance type:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of instances allowed per AWS account (service limit).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Current usage for the AWS account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about the capabilities of each instance type, see <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>. Note that the instance types offered may vary depending on
        /// the region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="ec2InstanceType">Name of an EC2 instance type that is supported in Amazon GameLift. A fleet instance type determines the computing resources of each instance in the fleet, including CPU, memory, storage, and networking capacity. Amazon GameLift supports the following EC2 instance types. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a> for detailed descriptions. Leave this parameter blank to retrieve limits for all types.</param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        public virtual DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(EC2InstanceType ec2InstanceType)
        {
            var request = new DescribeEC2InstanceLimitsRequest();
            request.EC2InstanceType = ec2InstanceType;
            return DescribeEC2InstanceLimits(request);
        }


        /// <summary>
        /// Retrieves the following information for the specified EC2 instance type:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of instances allowed per AWS account (service limit).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Current usage for the AWS account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about the capabilities of each instance type, see <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>. Note that the instance types offered may vary depending on
        /// the region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        public virtual DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEC2InstanceLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeEC2InstanceLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEC2InstanceLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEC2InstanceLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        public virtual IAsyncResult BeginDescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEC2InstanceLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEC2InstanceLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEC2InstanceLimits.</param>
        /// 
        /// <returns>Returns a  DescribeEC2InstanceLimitsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        public virtual DescribeEC2InstanceLimitsResponse EndDescribeEC2InstanceLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEC2InstanceLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetAttributes

        /// <summary>
        /// Retrieves core properties, including configuration, status, and metadata, for a fleet.
        /// 
        /// 
        ///  
        /// <para>
        /// To get attributes for one or more fleets, provide a list of fleet IDs or fleet ARNs.
        /// To get attributes for all fleets, do not specify a fleet identifier. When requesting
        /// attributes for multiple fleets, use the pagination parameters to retrieve results
        /// as a set of sequential pages. If successful, a <a>FleetAttributes</a> object is returned
        /// for each fleet requested, unless the fleet identifier is not found.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
        /// exceeds this limit, the request fails and the error message includes the maximum allowed
        /// number.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAttributes service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
        public virtual DescribeFleetAttributesResponse DescribeFleetAttributes(DescribeFleetAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetAttributes(DescribeFleetAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeFleetAttributesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
        public virtual DescribeFleetAttributesResponse EndDescribeFleetAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetCapacity

        /// <summary>
        /// Retrieves the current capacity statistics for one or more fleets. These statistics
        /// present a snapshot of the fleet's instances and provide insight on current or imminent
        /// scaling activity. To get statistics on game hosting activity in the fleet, see <a>DescribeFleetUtilization</a>.
        /// 
        ///  
        /// <para>
        /// You can request capacity for all fleets or specify a list of one or more fleet identifiers.
        /// When requesting multiple fleets, use the pagination parameters to retrieve results
        /// as a set of sequential pages. If successful, a <a>FleetCapacity</a> object is returned
        /// for each requested fleet ID. When a list of fleet IDs is provided, attribute objects
        /// are returned only for fleets that currently exist.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
        /// exceeds this limit, the request fails and the error message includes the maximum allowed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// Metrics for Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetCapacity service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
        public virtual DescribeFleetCapacityResponse DescribeFleetCapacity(DescribeFleetCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetCapacityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetCapacity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetCapacity(DescribeFleetCapacityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetCapacity.</param>
        /// 
        /// <returns>Returns a  DescribeFleetCapacityResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
        public virtual DescribeFleetCapacityResponse EndDescribeFleetCapacity(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetCapacityResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetEvents

        /// <summary>
        /// Retrieves entries from the specified fleet's event log. You can specify a time range
        /// to limit the result set. Use the pagination parameters to retrieve results as a set
        /// of sequential pages. If successful, a collection of event log entries matching the
        /// request are returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetEvents service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
        public virtual DescribeFleetEventsResponse DescribeFleetEvents(DescribeFleetEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetEvents(DescribeFleetEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetEvents.</param>
        /// 
        /// <returns>Returns a  DescribeFleetEventsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
        public virtual DescribeFleetEventsResponse EndDescribeFleetEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetPortSettings

        /// <summary>
        /// Retrieves a fleet's inbound connection permissions. Connection permissions specify
        /// the range of IP addresses and port settings that incoming traffic can use to access
        /// server processes in the fleet. Game sessions that are running on instances in the
        /// fleet use connections that fall in this range. 
        /// 
        ///  
        /// <para>
        /// To get a fleet's inbound connection permissions, specify the fleet's unique identifier.
        /// If successful, a collection of <a>IpPermission</a> objects is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="fleetId">A unique identifier for a fleet to retrieve port settings for. You can use either the fleet ID or ARN value.</param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
        public virtual DescribeFleetPortSettingsResponse DescribeFleetPortSettings(string fleetId)
        {
            var request = new DescribeFleetPortSettingsRequest();
            request.FleetId = fleetId;
            return DescribeFleetPortSettings(request);
        }


        /// <summary>
        /// Retrieves a fleet's inbound connection permissions. Connection permissions specify
        /// the range of IP addresses and port settings that incoming traffic can use to access
        /// server processes in the fleet. Game sessions that are running on instances in the
        /// fleet use connections that fall in this range. 
        /// 
        ///  
        /// <para>
        /// To get a fleet's inbound connection permissions, specify the fleet's unique identifier.
        /// If successful, a collection of <a>IpPermission</a> objects is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
        public virtual DescribeFleetPortSettingsResponse DescribeFleetPortSettings(DescribeFleetPortSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetPortSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetPortSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetPortSettings(DescribeFleetPortSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetPortSettings.</param>
        /// 
        /// <returns>Returns a  DescribeFleetPortSettingsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
        public virtual DescribeFleetPortSettingsResponse EndDescribeFleetPortSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetPortSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetUtilization

        /// <summary>
        /// Retrieves utilization statistics for one or more fleets. These statistics provide
        /// insight into how available hosting resources are currently being used. To get statistics
        /// on available hosting resources, see <a>DescribeFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// You can request utilization data for all fleets, or specify a list of one or more
        /// fleet IDs. When requesting multiple fleets, use the pagination parameters to retrieve
        /// results as a set of sequential pages. If successful, a <a>FleetUtilization</a> object
        /// is returned for each requested fleet ID, unless the fleet identifier is not found.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
        /// exceeds this limit, the request fails and the error message includes the maximum allowed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// Metrics for Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetUtilization service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
        public virtual DescribeFleetUtilizationResponse DescribeFleetUtilization(DescribeFleetUtilizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetUtilizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetUtilization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetUtilization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetUtilization(DescribeFleetUtilizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetUtilization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetUtilization.</param>
        /// 
        /// <returns>Returns a  DescribeFleetUtilizationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
        public virtual DescribeFleetUtilizationResponse EndDescribeFleetUtilization(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetUtilizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGameServer

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information for a game server resource. Information includes the game server
        /// statuses, health check info, and the instance the game server is running on. 
        /// </para>
        ///  
        /// <para>
        /// To retrieve game server information, specify the game server ID. If successful, the
        /// requested game server object is returned. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServer service method.</param>
        /// 
        /// <returns>The response from the DescribeGameServer service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServer">REST API Reference for DescribeGameServer Operation</seealso>
        public virtual DescribeGameServerResponse DescribeGameServer(DescribeGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerResponseUnmarshaller.Instance;

            return Invoke<DescribeGameServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServer">REST API Reference for DescribeGameServer Operation</seealso>
        public virtual IAsyncResult BeginDescribeGameServer(DescribeGameServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameServer.</param>
        /// 
        /// <returns>Returns a  DescribeGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServer">REST API Reference for DescribeGameServer Operation</seealso>
        public virtual DescribeGameServerResponse EndDescribeGameServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGameServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGameServerGroup

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on a game server group. 
        /// </para>
        ///  
        /// <para>
        /// To get attributes for a game server group, provide a group name or ARN value. If successful,
        /// a <a>GameServerGroup</a> object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGameServerGroup service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerGroup">REST API Reference for DescribeGameServerGroup Operation</seealso>
        public virtual DescribeGameServerGroupResponse DescribeGameServerGroup(DescribeGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGameServerGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerGroup">REST API Reference for DescribeGameServerGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeGameServerGroup(DescribeGameServerGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameServerGroup.</param>
        /// 
        /// <returns>Returns a  DescribeGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerGroup">REST API Reference for DescribeGameServerGroup Operation</seealso>
        public virtual DescribeGameServerGroupResponse EndDescribeGameServerGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGameServerGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGameSessionDetails

        /// <summary>
        /// Retrieves properties, including the protection policy in force, for one or more game
        /// sessions. This action can be used in several ways: (1) provide a <code>GameSessionId</code>
        /// or <code>GameSessionArn</code> to request details for a specific game session; (2)
        /// provide either a <code>FleetId</code> or an <code>AliasId</code> to request properties
        /// for all game sessions running on a fleet. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify just one of the following: game session ID,
        /// fleet ID, or alias ID. You can filter this request by game session status. Use the
        /// pagination parameters to retrieve results as a set of sequential pages. If successful,
        /// a <a>GameSessionDetail</a> object is returned for each session matching the request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionDetails service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessionDetails service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        public virtual DescribeGameSessionDetailsResponse DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionDetails operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameSessionDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        public virtual IAsyncResult BeginDescribeGameSessionDetails(DescribeGameSessionDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameSessionDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameSessionDetails.</param>
        /// 
        /// <returns>Returns a  DescribeGameSessionDetailsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        public virtual DescribeGameSessionDetailsResponse EndDescribeGameSessionDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGameSessionDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGameSessionPlacement

        /// <summary>
        /// Retrieves properties and current status of a game session placement request. To get
        /// game session placement details, specify the placement ID. If successful, a <a>GameSessionPlacement</a>
        /// object is returned.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionPlacement service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessionPlacement service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        public virtual DescribeGameSessionPlacementResponse DescribeGameSessionPlacement(DescribeGameSessionPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionPlacementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionPlacement operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameSessionPlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        public virtual IAsyncResult BeginDescribeGameSessionPlacement(DescribeGameSessionPlacementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionPlacementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameSessionPlacement.</param>
        /// 
        /// <returns>Returns a  DescribeGameSessionPlacementResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        public virtual DescribeGameSessionPlacementResponse EndDescribeGameSessionPlacement(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGameSessionPlacementResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGameSessionQueues

        /// <summary>
        /// Retrieves the properties for one or more game session queues. When requesting multiple
        /// queues, use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>GameSessionQueue</a> object is returned for each requested queue.
        /// When specifying a list of queues, objects are returned only for queues that currently
        /// exist in the Region.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-console.html">
        /// View Your Queues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionQueues service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessionQueues service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        public virtual DescribeGameSessionQueuesResponse DescribeGameSessionQueues(DescribeGameSessionQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionQueuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionQueues operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameSessionQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        public virtual IAsyncResult BeginDescribeGameSessionQueues(DescribeGameSessionQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameSessionQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameSessionQueues.</param>
        /// 
        /// <returns>Returns a  DescribeGameSessionQueuesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        public virtual DescribeGameSessionQueuesResponse EndDescribeGameSessionQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGameSessionQueuesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGameSessions

        /// <summary>
        /// Retrieves a set of one or more game sessions. Request a specific game session or request
        /// all game sessions on a fleet. Alternatively, use <a>SearchGameSessions</a> to request
        /// a set of active game sessions that are filtered by certain criteria. To retrieve protection
        /// policy settings for game sessions, use <a>DescribeGameSessionDetails</a>.
        /// 
        ///  
        /// <para>
        /// To get game sessions, specify one of the following: game session ID, fleet ID, or
        /// alias ID. You can filter this request by game session status. Use the pagination parameters
        /// to retrieve results as a set of sequential pages. If successful, a <a>GameSession</a>
        /// object is returned for each game session matching the request.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        public virtual DescribeGameSessionsResponse DescribeGameSessions(DescribeGameSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        public virtual IAsyncResult BeginDescribeGameSessions(DescribeGameSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameSessions.</param>
        /// 
        /// <returns>Returns a  DescribeGameSessionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        public virtual DescribeGameSessionsResponse EndDescribeGameSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGameSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstances

        /// <summary>
        /// Retrieves information about a fleet's instances, including instance IDs. Use this
        /// action to get details on all instances in the fleet or get details on one specific
        /// instance.
        /// 
        ///  
        /// <para>
        /// To get a specific instance, specify fleet ID and instance ID. To get all instances
        /// in a fleet, specify a fleet ID only. Use the pagination parameters to retrieve results
        /// as a set of sequential pages. If successful, an <a>Instance</a> object is returned
        /// for each result.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
        /// Access Fleet Instances</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
        /// Fleet Issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeInstances</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetInstanceAccess</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstances(DescribeInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMatchmaking

        /// <summary>
        /// Retrieves one or more matchmaking tickets. Use this operation to retrieve ticket information,
        /// including status and--once a successful match is made--acquire connection information
        /// for the resulting new game session. 
        /// 
        ///  
        /// <para>
        /// You can use this operation to track the progress of matchmaking requests (through
        /// polling) as an alternative to using event notifications. See more details on tracking
        /// matchmaking requests through polling or notifications in <a>StartMatchmaking</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To request matchmaking tickets, provide a list of up to 10 ticket IDs. If the request
        /// is successful, a ticket object is returned for each requested ID that currently exists.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-notification.html">
        /// Set Up FlexMatch Event Notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmaking service method.</param>
        /// 
        /// <returns>The response from the DescribeMatchmaking service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmaking">REST API Reference for DescribeMatchmaking Operation</seealso>
        public virtual DescribeMatchmakingResponse DescribeMatchmaking(DescribeMatchmakingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmaking operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMatchmaking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmaking">REST API Reference for DescribeMatchmaking Operation</seealso>
        public virtual IAsyncResult BeginDescribeMatchmaking(DescribeMatchmakingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMatchmaking.</param>
        /// 
        /// <returns>Returns a  DescribeMatchmakingResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmaking">REST API Reference for DescribeMatchmaking Operation</seealso>
        public virtual DescribeMatchmakingResponse EndDescribeMatchmaking(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMatchmakingResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMatchmakingConfigurations

        /// <summary>
        /// Retrieves the details of FlexMatch matchmaking configurations. With this operation,
        /// you have the following options: (1) retrieve all existing configurations, (2) provide
        /// the names of one or more configurations to retrieve, or (3) retrieve all configurations
        /// that use a specified rule set name. When requesting multiple items, use the pagination
        /// parameters to retrieve results as a set of sequential pages. If successful, a configuration
        /// is returned for each requested name. When specifying a list of names, only configurations
        /// that currently exist are returned. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/matchmaker-build.html">
        /// Setting Up FlexMatch Matchmakers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeMatchmakingConfigurations service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingConfigurations">REST API Reference for DescribeMatchmakingConfigurations Operation</seealso>
        public virtual DescribeMatchmakingConfigurationsResponse DescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMatchmakingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingConfigurations operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMatchmakingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingConfigurations">REST API Reference for DescribeMatchmakingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginDescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMatchmakingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMatchmakingConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeMatchmakingConfigurationsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingConfigurations">REST API Reference for DescribeMatchmakingConfigurations Operation</seealso>
        public virtual DescribeMatchmakingConfigurationsResponse EndDescribeMatchmakingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMatchmakingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMatchmakingRuleSets

        /// <summary>
        /// Retrieves the details for FlexMatch matchmaking rule sets. You can request all existing
        /// rule sets for the Region, or provide a list of one or more rule set names. When requesting
        /// multiple items, use the pagination parameters to retrieve results as a set of sequential
        /// pages. If successful, a rule set is returned for each requested name. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingRuleSets service method.</param>
        /// 
        /// <returns>The response from the DescribeMatchmakingRuleSets service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        public virtual DescribeMatchmakingRuleSetsResponse DescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingRuleSetsResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingRuleSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMatchmakingRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingRuleSets operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMatchmakingRuleSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        public virtual IAsyncResult BeginDescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingRuleSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMatchmakingRuleSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMatchmakingRuleSets.</param>
        /// 
        /// <returns>Returns a  DescribeMatchmakingRuleSetsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        public virtual DescribeMatchmakingRuleSetsResponse EndDescribeMatchmakingRuleSets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMatchmakingRuleSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePlayerSessions

        /// <summary>
        /// Retrieves properties for one or more player sessions. This action can be used in several
        /// ways: (1) provide a <code>PlayerSessionId</code> to request properties for a specific
        /// player session; (2) provide a <code>GameSessionId</code> to request properties for
        /// all player sessions in the specified game session; (3) provide a <code>PlayerId</code>
        /// to request properties for all player sessions of a specified player. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify only one of the following: a player session
        /// ID, a game session ID, or a player ID. You can filter this request by player session
        /// status. Use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>PlayerSession</a> object is returned for each session matching
        /// the request.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreatePlayerSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreatePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions service method.</param>
        /// 
        /// <returns>The response from the DescribePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
        public virtual DescribePlayerSessionsResponse DescribePlayerSessions(DescribePlayerSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribePlayerSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePlayerSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
        public virtual IAsyncResult BeginDescribePlayerSessions(DescribePlayerSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlayerSessions.</param>
        /// 
        /// <returns>Returns a  DescribePlayerSessionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
        public virtual DescribePlayerSessionsResponse EndDescribePlayerSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePlayerSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRuntimeConfiguration

        /// <summary>
        /// Retrieves a fleet's runtime configuration settings. The runtime configuration tells
        /// Amazon GameLift which server processes to run (and how) on each instance in the fleet.
        /// 
        ///  
        /// <para>
        /// To get a runtime configuration, specify the fleet's unique identifier. If successful,
        /// a <a>RuntimeConfiguration</a> object is returned for the requested fleet. If the requested
        /// fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-multiprocess.html">Running
        /// Multiple Processes on a Fleet</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeRuntimeConfiguration service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
        public virtual DescribeRuntimeConfigurationResponse DescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRuntimeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRuntimeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRuntimeConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeRuntimeConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
        public virtual DescribeRuntimeConfigurationResponse EndDescribeRuntimeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuntimeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScalingPolicies

        /// <summary>
        /// Retrieves all scaling policies applied to a fleet.
        /// 
        ///  
        /// <para>
        /// To get a fleet's scaling policies, specify the fleet ID. You can filter this request
        /// by policy status, such as to retrieve only active scaling policies. Use the pagination
        /// parameters to retrieve results as a set of sequential pages. If successful, set of
        /// <a>ScalingPolicy</a> objects is returned for the fleet.
        /// </para>
        ///  
        /// <para>
        /// A fleet may have all of its scaling policies suspended (<a>StopFleetActions</a>).
        /// This action does not affect the status of the scaling policies, which remains ACTIVE.
        /// To see whether a fleet's scaling policies are in force or suspended, call <a>DescribeFleetAttributes</a>
        /// and check the stopped actions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manage scaling policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Manage fleet actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingPolicies service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        public virtual DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        public virtual IAsyncResult BeginDescribeScalingPolicies(DescribeScalingPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeScalingPoliciesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        public virtual DescribeScalingPoliciesResponse EndDescribeScalingPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScript

        /// <summary>
        /// Retrieves properties for a Realtime script. 
        /// 
        ///  
        /// <para>
        /// To request a script record, specify the script ID. If successful, an object containing
        /// the script properties is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScript service method.</param>
        /// 
        /// <returns>The response from the DescribeScript service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScript">REST API Reference for DescribeScript Operation</seealso>
        public virtual DescribeScriptResponse DescribeScript(DescribeScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScriptResponseUnmarshaller.Instance;

            return Invoke<DescribeScriptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScript operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScript">REST API Reference for DescribeScript Operation</seealso>
        public virtual IAsyncResult BeginDescribeScript(DescribeScriptRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScriptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScript.</param>
        /// 
        /// <returns>Returns a  DescribeScriptResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScript">REST API Reference for DescribeScript Operation</seealso>
        public virtual DescribeScriptResponse EndDescribeScript(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScriptResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcPeeringAuthorizations

        /// <summary>
        /// Retrieves valid VPC peering authorizations that are pending for the AWS account. This
        /// operation returns all VPC peering authorizations and requests for peering. This includes
        /// those initiated and received by this account. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringAuthorizations service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringAuthorizations service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringAuthorizations">REST API Reference for DescribeVpcPeeringAuthorizations Operation</seealso>
        public virtual DescribeVpcPeeringAuthorizationsResponse DescribeVpcPeeringAuthorizations(DescribeVpcPeeringAuthorizationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringAuthorizationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringAuthorizations operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcPeeringAuthorizations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringAuthorizations">REST API Reference for DescribeVpcPeeringAuthorizations Operation</seealso>
        public virtual IAsyncResult BeginDescribeVpcPeeringAuthorizations(DescribeVpcPeeringAuthorizationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringAuthorizationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcPeeringAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcPeeringAuthorizations.</param>
        /// 
        /// <returns>Returns a  DescribeVpcPeeringAuthorizationsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringAuthorizations">REST API Reference for DescribeVpcPeeringAuthorizations Operation</seealso>
        public virtual DescribeVpcPeeringAuthorizationsResponse EndDescribeVpcPeeringAuthorizations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcPeeringAuthorizationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        /// <summary>
        /// Retrieves information on VPC peering connections. Use this operation to get peering
        /// information for all fleets or for one specific fleet ID. 
        /// 
        ///  
        /// <para>
        /// To retrieve connection information, call this operation from the AWS account that
        /// is used to manage the Amazon GameLift fleets. Specify a fleet ID or leave the parameter
        /// empty to retrieve all connection records. If successful, the retrieved information
        /// includes both active and pending connections. Active connections identify the IpV4
        /// CIDR block that the VPC uses to connect. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcPeeringConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual IAsyncResult BeginDescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcPeeringConnections.</param>
        /// 
        /// <returns>Returns a  DescribeVpcPeeringConnectionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual DescribeVpcPeeringConnectionsResponse EndDescribeVpcPeeringConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcPeeringConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGameSessionLogUrl

        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3 and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="gameSessionId">A unique identifier for the game session to get logs for. </param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        public virtual GetGameSessionLogUrlResponse GetGameSessionLogUrl(string gameSessionId)
        {
            var request = new GetGameSessionLogUrlRequest();
            request.GameSessionId = gameSessionId;
            return GetGameSessionLogUrl(request);
        }


        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3 and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl service method.</param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        public virtual GetGameSessionLogUrlResponse GetGameSessionLogUrl(GetGameSessionLogUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameSessionLogUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return Invoke<GetGameSessionLogUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGameSessionLogUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGameSessionLogUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        public virtual IAsyncResult BeginGetGameSessionLogUrl(GetGameSessionLogUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameSessionLogUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGameSessionLogUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGameSessionLogUrl.</param>
        /// 
        /// <returns>Returns a  GetGameSessionLogUrlResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        public virtual GetGameSessionLogUrlResponse EndGetGameSessionLogUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGameSessionLogUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstanceAccess

        /// <summary>
        /// Requests remote access to a fleet instance. Remote access is useful for debugging,
        /// gathering benchmarking data, or observing activity in real time. 
        /// 
        ///  
        /// <para>
        /// To remotely access an instance, you need credentials that match the operating system
        /// of the instance. For a Windows instance, Amazon GameLift returns a user name and password
        /// as strings for use with a Windows Remote Desktop client. For a Linux instance, Amazon
        /// GameLift returns a user name and RSA private key, also as strings, for use with an
        /// SSH client. The private key must be saved in the proper format to a <code>.pem</code>
        /// file before using. If you're making this request using the AWS CLI, saving the secret
        /// can be handled as part of the GetInstanceAccess request, as shown in one of the examples
        /// for this action. 
        /// </para>
        ///  
        /// <para>
        /// To request access to a specific instance, specify the IDs of both the instance and
        /// the fleet it belongs to. You can retrieve a fleet's instance IDs by calling <a>DescribeInstances</a>.
        /// If successful, an <a>InstanceAccess</a> object is returned that contains the instance's
        /// IP address and a set of credentials.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
        /// Access Fleet Instances</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
        /// Fleet Issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeInstances</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetInstanceAccess</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccess service method.</param>
        /// 
        /// <returns>The response from the GetInstanceAccess service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        public virtual GetInstanceAccessResponse GetInstanceAccess(GetInstanceAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return Invoke<GetInstanceAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccess operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        public virtual IAsyncResult BeginGetInstanceAccess(GetInstanceAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceAccess.</param>
        /// 
        /// <returns>Returns a  GetInstanceAccessResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        public virtual GetInstanceAccessResponse EndGetInstanceAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAliases

        /// <summary>
        /// Retrieves all aliases for this AWS account. You can filter the result set by alias
        /// name and/or routing strategy type. Use the pagination parameters to retrieve results
        /// in sequential pages.
        /// 
        ///  <note> 
        /// <para>
        /// Returned aliases are not listed in any particular order.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual ListAliasesResponse EndListAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAliasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBuilds

        /// <summary>
        /// Retrieves build resources for all builds associated with the AWS account in use. You
        /// can limit results to builds that are in a specific status by using the <code>Status</code>
        /// parameter. Use the pagination parameters to retrieve results in a set of sequential
        /// pages. 
        /// 
        ///  <note> 
        /// <para>
        /// Build resources are not listed in any particular order.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        public virtual ListBuildsResponse ListBuilds(ListBuildsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return Invoke<ListBuildsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuilds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        public virtual IAsyncResult BeginListBuilds(ListBuildsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuilds.</param>
        /// 
        /// <returns>Returns a  ListBuildsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        public virtual ListBuildsResponse EndListBuilds(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBuildsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFleets

        /// <summary>
        /// Retrieves a collection of fleet resources for this AWS account. You can filter the
        /// result set to find only those fleets that are deployed with a specific build or script.
        /// Use the pagination parameters to retrieve results in sequential pages.
        /// 
        ///  <note> 
        /// <para>
        /// Fleet resources are not listed in a particular order.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual ListFleetsResponse EndListFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGameServerGroups

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on all game servers groups that exist in the current AWS account
        /// for the selected region. Use the pagination parameters to retrieve results in a set
        /// of sequential pages. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGameServerGroups service method.</param>
        /// 
        /// <returns>The response from the ListGameServerGroups service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServerGroups">REST API Reference for ListGameServerGroups Operation</seealso>
        public virtual ListGameServerGroupsResponse ListGameServerGroups(ListGameServerGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGameServerGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServerGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGameServerGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGameServerGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGameServerGroups operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGameServerGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServerGroups">REST API Reference for ListGameServerGroups Operation</seealso>
        public virtual IAsyncResult BeginListGameServerGroups(ListGameServerGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGameServerGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServerGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGameServerGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGameServerGroups.</param>
        /// 
        /// <returns>Returns a  ListGameServerGroupsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServerGroups">REST API Reference for ListGameServerGroups Operation</seealso>
        public virtual ListGameServerGroupsResponse EndListGameServerGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGameServerGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGameServers

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on all game servers that are currently running in a specified
        /// game server group. If there are custom key sort values for your game servers, you
        /// can opt to have the returned list sorted based on these values. Use the pagination
        /// parameters to retrieve results in a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGameServers service method.</param>
        /// 
        /// <returns>The response from the ListGameServers service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServers">REST API Reference for ListGameServers Operation</seealso>
        public virtual ListGameServersResponse ListGameServers(ListGameServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGameServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServersResponseUnmarshaller.Instance;

            return Invoke<ListGameServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGameServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGameServers operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGameServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServers">REST API Reference for ListGameServers Operation</seealso>
        public virtual IAsyncResult BeginListGameServers(ListGameServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGameServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGameServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGameServers.</param>
        /// 
        /// <returns>Returns a  ListGameServersResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServers">REST API Reference for ListGameServers Operation</seealso>
        public virtual ListGameServersResponse EndListGameServers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGameServersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListScripts

        /// <summary>
        /// Retrieves script records for all Realtime scripts that are associated with the AWS
        /// account in use. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScripts service method.</param>
        /// 
        /// <returns>The response from the ListScripts service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListScripts">REST API Reference for ListScripts Operation</seealso>
        public virtual ListScriptsResponse ListScripts(ListScriptsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScriptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScriptsResponseUnmarshaller.Instance;

            return Invoke<ListScriptsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListScripts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScripts operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScripts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListScripts">REST API Reference for ListScripts Operation</seealso>
        public virtual IAsyncResult BeginListScripts(ListScriptsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScriptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScriptsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListScripts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScripts.</param>
        /// 
        /// <returns>Returns a  ListScriptsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListScripts">REST API Reference for ListScripts Operation</seealso>
        public virtual ListScriptsResponse EndListScripts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListScriptsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves all tags that are assigned to a GameLift resource. Resource tags are used
        /// to organize AWS resources for a range of purposes. This action handles the permissions
        /// necessary to manage tags for the following GameLift resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Script
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GameSessionQueue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingRuleSet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To list tags for a resource, specify the unique ARN value for the resource.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in the <i>AWS General Reference</i> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// AWS Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutScalingPolicy

        /// <summary>
        /// Creates or updates a scaling policy for a fleet. Scaling policies are used to automatically
        /// scale a fleet's hosting capacity to meet player demand. An active scaling policy instructs
        /// Amazon GameLift to track a fleet metric and automatically change the fleet's capacity
        /// when a certain threshold is reached. There are two types of scaling policies: target-based
        /// and rule-based. Use a target-based policy to quickly and efficiently manage fleet
        /// scaling; this option is the most commonly used. Use rule-based policies when you need
        /// to exert fine-grained control over auto-scaling. 
        /// 
        ///  
        /// <para>
        /// Fleets can have multiple scaling policies of each type in force at the same time;
        /// you can have one target-based policy, one or multiple rule-based scaling policies,
        /// or both. We recommend caution, however, because multiple auto-scaling policies can
        /// have unintended consequences.
        /// </para>
        ///  
        /// <para>
        /// You can temporarily suspend all scaling policies for a fleet by calling <a>StopFleetActions</a>
        /// with the fleet action AUTO_SCALING. To resume scaling policies, call <a>StartFleetActions</a>
        /// with the same fleet action. To stop just one scaling policy--or to permanently remove
        /// it, you must delete the policy with <a>DeleteScalingPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// Learn more about how to work with auto-scaling in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-autoscaling.html">Set
        /// Up Fleet Automatic Scaling</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Target-based policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A target-based policy tracks a single metric: PercentAvailableGameSessions. This metric
        /// tells us how much of a fleet's hosting capacity is ready to host game sessions but
        /// is not currently in use. This is the fleet's buffer; it measures the additional player
        /// demand that the fleet could handle at current capacity. With a target-based policy,
        /// you set your ideal buffer size and leave it to Amazon GameLift to take whatever action
        /// is needed to maintain that target. 
        /// </para>
        ///  
        /// <para>
        /// For example, you might choose to maintain a 10% buffer for a fleet that has the capacity
        /// to host 100 simultaneous game sessions. This policy tells Amazon GameLift to take
        /// action whenever the fleet's available capacity falls below or rises above 10 game
        /// sessions. Amazon GameLift will start new instances or stop unused instances in order
        /// to return to the 10% buffer. 
        /// </para>
        ///  
        /// <para>
        /// To create or update a target-based policy, specify a fleet ID and name, and set the
        /// policy type to "TargetBased". Specify the metric to track (PercentAvailableGameSessions)
        /// and reference a <a>TargetConfiguration</a> object with your desired buffer value.
        /// Exclude all other parameters. On a successful request, the policy name is returned.
        /// The scaling policy is automatically in force as soon as it's successfully created.
        /// If the fleet's auto-scaling actions are temporarily suspended, the new policy will
        /// be in force once the fleet actions are restarted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Rule-based policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A rule-based policy tracks specified fleet metric, sets a threshold value, and specifies
        /// the type of action to initiate when triggered. With a rule-based policy, you can select
        /// from several available fleet metrics. Each policy specifies whether to scale up or
        /// scale down (and by how much), so you need one policy for each type of action. 
        /// </para>
        ///  
        /// <para>
        /// For example, a policy may make the following statement: "If the percentage of idle
        /// instances is greater than 20% for more than 15 minutes, then reduce the fleet capacity
        /// by 10%."
        /// </para>
        ///  
        /// <para>
        /// A policy's rule statement has the following structure:
        /// </para>
        ///  
        /// <para>
        /// If <code>[MetricName]</code> is <code>[ComparisonOperator]</code> <code>[Threshold]</code>
        /// for <code>[EvaluationPeriods]</code> minutes, then <code>[ScalingAdjustmentType]</code>
        /// to/by <code>[ScalingAdjustment]</code>.
        /// </para>
        ///  
        /// <para>
        /// To implement the example, the rule statement would look like this:
        /// </para>
        ///  
        /// <para>
        /// If <code>[PercentIdleInstances]</code> is <code>[GreaterThanThreshold]</code> <code>[20]</code>
        /// for <code>[15]</code> minutes, then <code>[PercentChangeInCapacity]</code> to/by <code>[10]</code>.
        /// </para>
        ///  
        /// <para>
        /// To create or update a scaling policy, specify a unique combination of name and fleet
        /// ID, and set the policy type to "RuleBased". Specify the parameter values for a policy
        /// rule statement. On a successful request, the policy name is returned. Scaling policies
        /// are automatically in force as soon as they're successfully created. If the fleet's
        /// auto-scaling actions are temporarily suspended, the new policy will be in force once
        /// the fleet actions are restarted.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manage scaling policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Manage fleet actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutScalingPolicy(PutScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScalingPolicy.</param>
        /// 
        /// <returns>Returns a  PutScalingPolicyResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual PutScalingPolicyResponse EndPutScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterGameServer

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Creates a new game server resource and notifies GameLift FleetIQ that the game server
        /// is ready to host gameplay and players. This action is called by a game server process
        /// that is running on an instance in a game server group. Registering game servers enables
        /// GameLift FleetIQ to track available game servers and enables game clients and services
        /// to claim a game server for a new game session. 
        /// </para>
        ///  
        /// <para>
        /// To register a game server, identify the game server group and instance where the game
        /// server is running, and provide a unique identifier for the game server. You can also
        /// include connection and game server data; when a game client or service requests a
        /// game server by calling <a>ClaimGameServer</a>, this information is returned in response.
        /// </para>
        ///  
        /// <para>
        /// Once a game server is successfully registered, it is put in status AVAILABLE. A request
        /// to register a game server may fail if the instance it is in the process of shutting
        /// down as part of instance rebalancing or scale-down activity. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterGameServer service method.</param>
        /// 
        /// <returns>The response from the RegisterGameServer service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RegisterGameServer">REST API Reference for RegisterGameServer Operation</seealso>
        public virtual RegisterGameServerResponse RegisterGameServer(RegisterGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterGameServerResponseUnmarshaller.Instance;

            return Invoke<RegisterGameServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RegisterGameServer">REST API Reference for RegisterGameServer Operation</seealso>
        public virtual IAsyncResult BeginRegisterGameServer(RegisterGameServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterGameServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterGameServer.</param>
        /// 
        /// <returns>Returns a  RegisterGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RegisterGameServer">REST API Reference for RegisterGameServer Operation</seealso>
        public virtual RegisterGameServerResponse EndRegisterGameServer(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterGameServerResponse>(asyncResult);
        }

        #endregion
        
        #region  RequestUploadCredentials

        /// <summary>
        /// Retrieves a fresh set of credentials for use when uploading a new set of game build
        /// files to Amazon GameLift's Amazon S3. This is done as part of the build creation process;
        /// see <a>CreateBuild</a>.
        /// 
        ///  
        /// <para>
        /// To request new credentials, specify the build ID as returned with an initial <code>CreateBuild</code>
        /// request. If successful, a new set of credentials are returned, along with the S3 storage
        /// location associated with the build ID.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
        /// Create a Build with Files in S3</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="buildId">A unique identifier for a build to get credentials for. You can use either the build ID or ARN value. </param>
        /// 
        /// <returns>The response from the RequestUploadCredentials service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        public virtual RequestUploadCredentialsResponse RequestUploadCredentials(string buildId)
        {
            var request = new RequestUploadCredentialsRequest();
            request.BuildId = buildId;
            return RequestUploadCredentials(request);
        }


        /// <summary>
        /// Retrieves a fresh set of credentials for use when uploading a new set of game build
        /// files to Amazon GameLift's Amazon S3. This is done as part of the build creation process;
        /// see <a>CreateBuild</a>.
        /// 
        ///  
        /// <para>
        /// To request new credentials, specify the build ID as returned with an initial <code>CreateBuild</code>
        /// request. If successful, a new set of credentials are returned, along with the S3 storage
        /// location associated with the build ID.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
        /// Create a Build with Files in S3</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials service method.</param>
        /// 
        /// <returns>The response from the RequestUploadCredentials service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        public virtual RequestUploadCredentialsResponse RequestUploadCredentials(RequestUploadCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestUploadCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return Invoke<RequestUploadCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestUploadCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestUploadCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        public virtual IAsyncResult BeginRequestUploadCredentials(RequestUploadCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestUploadCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RequestUploadCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestUploadCredentials.</param>
        /// 
        /// <returns>Returns a  RequestUploadCredentialsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        public virtual RequestUploadCredentialsResponse EndRequestUploadCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<RequestUploadCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  ResolveAlias

        /// <summary>
        /// Retrieves the fleet ID that an alias is currently pointing to.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasId">The unique identifier of the alias that you want to retrieve a fleet ID for. You can use either the alias ID or ARN value.</param>
        /// 
        /// <returns>The response from the ResolveAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        public virtual ResolveAliasResponse ResolveAlias(string aliasId)
        {
            var request = new ResolveAliasRequest();
            request.AliasId = aliasId;
            return ResolveAlias(request);
        }


        /// <summary>
        /// Retrieves the fleet ID that an alias is currently pointing to.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias service method.</param>
        /// 
        /// <returns>The response from the ResolveAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        public virtual ResolveAliasResponse ResolveAlias(ResolveAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return Invoke<ResolveAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        public virtual IAsyncResult BeginResolveAlias(ResolveAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveAlias.</param>
        /// 
        /// <returns>Returns a  ResolveAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        public virtual ResolveAliasResponse EndResolveAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<ResolveAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  ResumeGameServerGroup

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Reinstates activity on a game server group after it has been suspended. A game server
        /// group may be suspended by calling <a>SuspendGameServerGroup</a>, or it may have been
        /// involuntarily suspended due to a configuration problem. You can manually resume activity
        /// on the group once the configuration problem has been resolved. Refer to the game server
        /// group status and status reason for more information on why group activity is suspended.
        /// </para>
        ///  
        /// <para>
        /// To resume activity, specify a game server group ARN and the type of activity to be
        /// resumed.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the ResumeGameServerGroup service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResumeGameServerGroup">REST API Reference for ResumeGameServerGroup Operation</seealso>
        public virtual ResumeGameServerGroupResponse ResumeGameServerGroup(ResumeGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<ResumeGameServerGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResumeGameServerGroup">REST API Reference for ResumeGameServerGroup Operation</seealso>
        public virtual IAsyncResult BeginResumeGameServerGroup(ResumeGameServerGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeGameServerGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeGameServerGroup.</param>
        /// 
        /// <returns>Returns a  ResumeGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResumeGameServerGroup">REST API Reference for ResumeGameServerGroup Operation</seealso>
        public virtual ResumeGameServerGroupResponse EndResumeGameServerGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeGameServerGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchGameSessions

        /// <summary>
        /// Retrieves all active game sessions that match a set of search criteria and sorts them
        /// in a specified order. You can search or sort by the following game session attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>gameSessionId</b> -- A unique identifier for the game session. You can use either
        /// a <code>GameSessionId</code> or <code>GameSessionArn</code> value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>gameSessionName</b> -- Name assigned to a game session. This value is set when
        /// requesting a new game session with <a>CreateGameSession</a> or updating with <a>UpdateGameSession</a>.
        /// Game session names do not need to be unique to a game session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>gameSessionProperties</b> -- Custom data defined in a game session's <code>GameProperty</code>
        /// parameter. <code>GameProperty</code> values are stored as key:value pairs; the filter
        /// expression must indicate the key and a string to search the data values for. For example,
        /// to search for game sessions with custom data containing the key:value pair "gameMode:brawl",
        /// specify the following: <code>gameSessionProperties.gameMode = "brawl"</code>. All
        /// custom data values are searched as strings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>maximumSessions</b> -- Maximum number of player sessions allowed for a game session.
        /// This value is set when requesting a new game session with <a>CreateGameSession</a>
        /// or updating with <a>UpdateGameSession</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>creationTimeMillis</b> -- Value indicating when a game session was created. It
        /// is expressed in Unix time as milliseconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>playerSessionCount</b> -- Number of players currently connected to a game session.
        /// This value changes rapidly as players join the session or drop out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>hasAvailablePlayerSessions</b> -- Boolean value indicating whether a game session
        /// has reached its maximum number of players. It is highly recommended that all search
        /// requests include this filter attribute to optimize search performance and return only
        /// sessions that players can join. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Returned values for <code>playerSessionCount</code> and <code>hasAvailablePlayerSessions</code>
        /// change quickly as players join sessions and others drop out. Results should be considered
        /// a snapshot in time. Be sure to refresh search results often, and handle sessions that
        /// fill up before a player can join. 
        /// </para>
        ///  </note> 
        /// <para>
        /// To search or sort, specify either a fleet ID or an alias ID, and provide a search
        /// filter expression, a sort expression, or both. If successful, a collection of <a>GameSession</a>
        /// objects matching the request is returned. Use the pagination parameters to retrieve
        /// results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// You can search for game sessions one fleet at a time only. To find game sessions across
        /// multiple fleets, you must search each fleet separately and combine the results. This
        /// search feature finds only game sessions that are in <code>ACTIVE</code> status. To
        /// locate games in statuses other than active, use <a>DescribeGameSessionDetails</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGameSessions service method.</param>
        /// 
        /// <returns>The response from the SearchGameSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        public virtual SearchGameSessionsResponse SearchGameSessions(SearchGameSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGameSessionsResponseUnmarshaller.Instance;

            return Invoke<SearchGameSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchGameSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchGameSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        public virtual IAsyncResult BeginSearchGameSessions(SearchGameSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGameSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchGameSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchGameSessions.</param>
        /// 
        /// <returns>Returns a  SearchGameSessionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        public virtual SearchGameSessionsResponse EndSearchGameSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchGameSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFleetActions

        /// <summary>
        /// Resumes activity on a fleet that was suspended with <a>StopFleetActions</a>. Currently,
        /// this operation is used to restart a fleet's auto-scaling activity. 
        /// 
        ///  
        /// <para>
        /// To start fleet actions, specify the fleet ID and the type of actions to restart. When
        /// auto-scaling fleet actions are restarted, Amazon GameLift once again initiates scaling
        /// events as triggered by the fleet's scaling policies. If actions on the fleet were
        /// never stopped, this operation will have no effect. You can view a fleet's stopped
        /// actions using <a>DescribeFleetAttributes</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFleetActions service method.</param>
        /// 
        /// <returns>The response from the StartFleetActions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        public virtual StartFleetActionsResponse StartFleetActions(StartFleetActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetActionsResponseUnmarshaller.Instance;

            return Invoke<StartFleetActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFleetActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFleetActions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFleetActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        public virtual IAsyncResult BeginStartFleetActions(StartFleetActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFleetActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFleetActions.</param>
        /// 
        /// <returns>Returns a  StartFleetActionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        public virtual StartFleetActionsResponse EndStartFleetActions(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFleetActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartGameSessionPlacement

        /// <summary>
        /// Places a request for a new game session in a queue (see <a>CreateGameSessionQueue</a>).
        /// When processing a placement request, Amazon GameLift searches for available resources
        /// on the queue's destinations, scanning each until it finds resources or the placement
        /// request times out.
        /// 
        ///  
        /// <para>
        /// A game session placement request can also request player sessions. When a new game
        /// session is successfully created, Amazon GameLift creates a player session for each
        /// player included in the request.
        /// </para>
        ///  
        /// <para>
        /// When placing a game session, by default Amazon GameLift tries each fleet in the order
        /// they are listed in the queue configuration. Ideally, a queue's destinations are listed
        /// in preference order.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, when requesting a game session with players, you can also provide latency
        /// data for each player in relevant Regions. Latency data indicates the performance lag
        /// a player experiences when connected to a fleet in the Region. Amazon GameLift uses
        /// latency data to reorder the list of destinations to place the game session in a Region
        /// with minimal lag. If latency data is provided for multiple players, Amazon GameLift
        /// calculates each Region's average lag for all players and reorders to get the best
        /// game play across all players. 
        /// </para>
        ///  
        /// <para>
        /// To place a new game session request, specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The queue name and a set of game session properties and settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A unique ID (such as a UUID) for the placement. You use this ID to track the status
        /// of the placement request
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) A set of player data and a unique player ID for each player that you are
        /// joining to the new game session (player data is optional, but if you include it, you
        /// must also provide a unique ID for each player)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Latency data for all players (if you want to optimize game play for the players)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, a new game session placement is created.
        /// </para>
        ///  
        /// <para>
        /// To track the status of a placement request, call <a>DescribeGameSessionPlacement</a>
        /// and check the request's status. If the status is <code>FULFILLED</code>, a new game
        /// session has been created and a game session ARN and Region are referenced. If the
        /// placement request times out, you can resubmit the request or retry it with a different
        /// queue. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGameSessionPlacement service method.</param>
        /// 
        /// <returns>The response from the StartGameSessionPlacement service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        public virtual StartGameSessionPlacementResponse StartGameSessionPlacement(StartGameSessionPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StartGameSessionPlacementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGameSessionPlacement operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartGameSessionPlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        public virtual IAsyncResult BeginStartGameSessionPlacement(StartGameSessionPlacementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartGameSessionPlacement.</param>
        /// 
        /// <returns>Returns a  StartGameSessionPlacementResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        public virtual StartGameSessionPlacementResponse EndStartGameSessionPlacement(IAsyncResult asyncResult)
        {
            return EndInvoke<StartGameSessionPlacementResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMatchBackfill

        /// <summary>
        /// Finds new players to fill open slots in an existing game session. This operation can
        /// be used to add players to matched games that start with fewer than the maximum number
        /// of players or to replace players when they drop out. By backfilling with the same
        /// matchmaker used to create the original match, you ensure that new players meet the
        /// match criteria and maintain a consistent experience throughout the game session. You
        /// can backfill a match anytime after a game session has been created. 
        /// 
        ///  
        /// <para>
        /// To request a match backfill, specify a unique ticket ID, the existing game session's
        /// ARN, a matchmaking configuration, and a set of data that describes all current players
        /// in the game session. If successful, a match backfill ticket is created and returned
        /// with status set to QUEUED. The ticket is placed in the matchmaker's ticket pool and
        /// processed. Track the status of the ticket to respond as needed. 
        /// </para>
        ///  
        /// <para>
        /// The process of finding backfill matches is essentially identical to the initial matchmaking
        /// process. The matchmaker searches the pool and groups tickets together to form potential
        /// matches, allowing only one backfill ticket per potential match. Once the a match is
        /// formed, the matchmaker creates player sessions for the new players. All tickets in
        /// the match are updated with the game session's connection information, and the <a>GameSession</a>
        /// object is updated to include matchmaker data on the new players. For more detail on
        /// how match backfill requests are processed, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-match.html">
        /// How Amazon GameLift FlexMatch Works</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-backfill.html">
        /// Backfill Existing Games with FlexMatch</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-match.html">
        /// How GameLift FlexMatch Works</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchBackfill service method.</param>
        /// 
        /// <returns>The response from the StartMatchBackfill service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        public virtual StartMatchBackfillResponse StartMatchBackfill(StartMatchBackfillRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchBackfillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchBackfillResponseUnmarshaller.Instance;

            return Invoke<StartMatchBackfillResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMatchBackfill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchBackfill operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMatchBackfill
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        public virtual IAsyncResult BeginStartMatchBackfill(StartMatchBackfillRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchBackfillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchBackfillResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMatchBackfill operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMatchBackfill.</param>
        /// 
        /// <returns>Returns a  StartMatchBackfillResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        public virtual StartMatchBackfillResponse EndStartMatchBackfill(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMatchBackfillResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMatchmaking

        /// <summary>
        /// Uses FlexMatch to create a game match for a group of players based on custom matchmaking
        /// rules, and starts a new game for the matched players. Each matchmaking request specifies
        /// the type of match to build (team configuration, rules for an acceptable match, etc.).
        /// The request also specifies the players to find a match for and where to host the new
        /// game session for optimal performance. A matchmaking request might start with a single
        /// player or a group of players who want to play together. FlexMatch finds additional
        /// players as needed to fill the match. Match type, rules, and the queue used to place
        /// a new game session are defined in a <code>MatchmakingConfiguration</code>. 
        /// 
        ///  
        /// <para>
        /// To start matchmaking, provide a unique ticket ID, specify a matchmaking configuration,
        /// and include the players to be matched. You must also include a set of player attributes
        /// relevant for the matchmaking configuration. If successful, a matchmaking ticket is
        /// returned with status set to <code>QUEUED</code>. Track the status of the ticket to
        /// respond as needed and acquire game session connection information for successfully
        /// completed matches.
        /// </para>
        ///  
        /// <para>
        ///  <b>Tracking ticket status</b> -- A couple of options are available for tracking the
        /// status of matchmaking requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Polling -- Call <code>DescribeMatchmaking</code>. This operation returns the full
        /// ticket object, including current status and (for completed tickets) game session connection
        /// info. We recommend polling no more than once every 10 seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notifications -- Get event notifications for changes in ticket status using Amazon
        /// Simple Notification Service (SNS). Notifications are easy to set up (see <a>CreateMatchmakingConfiguration</a>)
        /// and typically deliver match status changes faster and more efficiently than polling.
        /// We recommend that you use polling to back up to notifications (since delivery is not
        /// guaranteed) and call <code>DescribeMatchmaking</code> only when notifications are
        /// not received within 30 seconds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Processing a matchmaking request</b> -- FlexMatch handles a matchmaking request
        /// as follows: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Your client code submits a <code>StartMatchmaking</code> request for one or more players
        /// and tracks the status of the request ticket. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FlexMatch uses this ticket and others in process to build an acceptable match. When
        /// a potential match is identified, all tickets in the proposed match are advanced to
        /// the next status. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the match requires player acceptance (set in the matchmaking configuration), the
        /// tickets move into status <code>REQUIRES_ACCEPTANCE</code>. This status triggers your
        /// client code to solicit acceptance from all players in every ticket involved in the
        /// match, and then call <a>AcceptMatch</a> for each player. If any player rejects or
        /// fails to accept the match before a specified timeout, the proposed match is dropped
        /// (see <code>AcceptMatch</code> for more details).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Once a match is proposed and accepted, the matchmaking tickets move into status <code>PLACING</code>.
        /// FlexMatch locates resources for a new game session using the game session queue (set
        /// in the matchmaking configuration) and creates the game session based on the match
        /// data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the match is successfully placed, the matchmaking tickets move into <code>COMPLETED</code>
        /// status. Connection information (including game session endpoint and player session)
        /// is added to the matchmaking tickets. Matched players can use the connection information
        /// to join the game. 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-notification.html">
        /// Set Up FlexMatch Event Notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-tasks.html">
        /// FlexMatch Integration Roadmap</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-match.html">
        /// How GameLift FlexMatch Works</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchmaking service method.</param>
        /// 
        /// <returns>The response from the StartMatchmaking service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        public virtual StartMatchmakingResponse StartMatchmaking(StartMatchmakingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StartMatchmakingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchmaking operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMatchmaking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        public virtual IAsyncResult BeginStartMatchmaking(StartMatchmakingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMatchmaking.</param>
        /// 
        /// <returns>Returns a  StartMatchmakingResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        public virtual StartMatchmakingResponse EndStartMatchmaking(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMatchmakingResponse>(asyncResult);
        }

        #endregion
        
        #region  StopFleetActions

        /// <summary>
        /// Suspends activity on a fleet. Currently, this operation is used to stop a fleet's
        /// auto-scaling activity. It is used to temporarily stop triggering scaling events. The
        /// policies can be retained and auto-scaling activity can be restarted using <a>StartFleetActions</a>.
        /// You can view a fleet's stopped actions using <a>DescribeFleetAttributes</a>.
        /// 
        ///  
        /// <para>
        /// To stop fleet actions, specify the fleet ID and the type of actions to suspend. When
        /// auto-scaling fleet actions are stopped, Amazon GameLift no longer initiates scaling
        /// events except in response to manual changes using <a>UpdateFleetCapacity</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFleetActions service method.</param>
        /// 
        /// <returns>The response from the StopFleetActions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        public virtual StopFleetActionsResponse StopFleetActions(StopFleetActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetActionsResponseUnmarshaller.Instance;

            return Invoke<StopFleetActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopFleetActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFleetActions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopFleetActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        public virtual IAsyncResult BeginStopFleetActions(StopFleetActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopFleetActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopFleetActions.</param>
        /// 
        /// <returns>Returns a  StopFleetActionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        public virtual StopFleetActionsResponse EndStopFleetActions(IAsyncResult asyncResult)
        {
            return EndInvoke<StopFleetActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  StopGameSessionPlacement

        /// <summary>
        /// Cancels a game session placement that is in <code>PENDING</code> status. To stop a
        /// placement, provide the placement ID values. If successful, the placement is moved
        /// to <code>CANCELLED</code> status.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopGameSessionPlacement service method.</param>
        /// 
        /// <returns>The response from the StopGameSessionPlacement service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        public virtual StopGameSessionPlacementResponse StopGameSessionPlacement(StopGameSessionPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StopGameSessionPlacementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopGameSessionPlacement operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopGameSessionPlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        public virtual IAsyncResult BeginStopGameSessionPlacement(StopGameSessionPlacementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopGameSessionPlacement.</param>
        /// 
        /// <returns>Returns a  StopGameSessionPlacementResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        public virtual StopGameSessionPlacementResponse EndStopGameSessionPlacement(IAsyncResult asyncResult)
        {
            return EndInvoke<StopGameSessionPlacementResponse>(asyncResult);
        }

        #endregion
        
        #region  StopMatchmaking

        /// <summary>
        /// Cancels a matchmaking ticket or match backfill ticket that is currently being processed.
        /// To stop the matchmaking operation, specify the ticket ID. If successful, work on the
        /// ticket is stopped, and the ticket status is changed to <code>CANCELLED</code>.
        /// 
        ///  
        /// <para>
        /// This call is also used to turn off automatic backfill for an individual game session.
        /// This is for game sessions that are created with a matchmaking configuration that has
        /// automatic backfill enabled. The ticket ID is included in the <code>MatchmakerData</code>
        /// of an updated game session object, which is provided to the game server.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the action is successful, the service sends back an empty JSON struct with the
        /// HTTP 200 response (not an empty HTTP body).
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMatchmaking service method.</param>
        /// 
        /// <returns>The response from the StopMatchmaking service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        public virtual StopMatchmakingResponse StopMatchmaking(StopMatchmakingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StopMatchmakingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMatchmaking operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMatchmaking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        public virtual IAsyncResult BeginStopMatchmaking(StopMatchmakingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMatchmaking.</param>
        /// 
        /// <returns>Returns a  StopMatchmakingResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        public virtual StopMatchmakingResponse EndStopMatchmaking(IAsyncResult asyncResult)
        {
            return EndInvoke<StopMatchmakingResponse>(asyncResult);
        }

        #endregion
        
        #region  SuspendGameServerGroup

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Temporarily stops activity on a game server group without terminating instances or
        /// the game server group. Activity can be restarted by calling <a>ResumeGameServerGroup</a>.
        /// Activities that can suspended are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Instance type replacement. This activity evaluates the current Spot viability of all
        /// instance types that are defined for the game server group. It updates the Auto Scaling
        /// group to remove nonviable Spot instance types (which have a higher chance of game
        /// server interruptions) and rebalances capacity across the remaining viable Spot instance
        /// types. When this activity is suspended, the Auto Scaling group continues with its
        /// current balance, regardless of viability. Instance protection, utilization metrics,
        /// and capacity autoscaling activities continue to be active. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To suspend activity, specify a game server group ARN and the type of activity to be
        /// suspended.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the SuspendGameServerGroup service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SuspendGameServerGroup">REST API Reference for SuspendGameServerGroup Operation</seealso>
        public virtual SuspendGameServerGroupResponse SuspendGameServerGroup(SuspendGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<SuspendGameServerGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SuspendGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSuspendGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SuspendGameServerGroup">REST API Reference for SuspendGameServerGroup Operation</seealso>
        public virtual IAsyncResult BeginSuspendGameServerGroup(SuspendGameServerGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendGameServerGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SuspendGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuspendGameServerGroup.</param>
        /// 
        /// <returns>Returns a  SuspendGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SuspendGameServerGroup">REST API Reference for SuspendGameServerGroup Operation</seealso>
        public virtual SuspendGameServerGroupResponse EndSuspendGameServerGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<SuspendGameServerGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns a tag to a GameLift resource. AWS resource tags provide an additional management
        /// tool set. You can use tags to organize resources, create IAM permissions policies
        /// to manage access to groups of resources, customize AWS cost breakdowns, etc. This
        /// action handles the permissions necessary to manage tags for the following GameLift
        /// resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Script
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GameSessionQueue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingRuleSet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To add a tag to a resource, specify the unique ARN value for the resource and provide
        /// a tag list containing one or more tags. The operation succeeds even if the list includes
        /// tags that are already assigned to the specified resource. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in the <i>AWS General Reference</i> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// AWS Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag that is assigned to a GameLift resource. Resource tags are used to organize
        /// AWS resources for a range of purposes. This action handles the permissions necessary
        /// to manage tags for the following GameLift resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Script
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GameSessionQueue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingRuleSet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To remove a tag from a resource, specify the unique ARN value for the resource and
        /// provide a string list containing one or more tags to be removed. This action succeeds
        /// even if the list includes tags that are not currently assigned to the specified resource.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in the <i>AWS General Reference</i> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// AWS Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAlias

        /// <summary>
        /// Updates properties for an alias. To update properties, specify the alias ID to be
        /// updated and provide the information to be changed. To reassign an alias to another
        /// fleet, provide an updated routing strategy. If successful, the updated alias record
        /// is returned.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual IAsyncResult BeginUpdateAlias(UpdateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual UpdateAliasResponse EndUpdateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBuild

        /// <summary>
        /// Updates metadata in a build resource, including the build name and version. To update
        /// the metadata, specify the build ID to update and provide the new values. If successful,
        /// a build object containing the updated metadata is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild service method.</param>
        /// 
        /// <returns>The response from the UpdateBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
        public virtual UpdateBuildResponse UpdateBuild(UpdateBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return Invoke<UpdateBuildResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
        public virtual IAsyncResult BeginUpdateBuild(UpdateBuildRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBuild.</param>
        /// 
        /// <returns>Returns a  UpdateBuildResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
        public virtual UpdateBuildResponse EndUpdateBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleetAttributes

        /// <summary>
        /// Updates fleet properties, including name and description, for a fleet. To update metadata,
        /// specify the fleet ID and the property values that you want to change. If successful,
        /// the fleet ID for the updated fleet is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetAttributes service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
        public virtual UpdateFleetAttributesResponse UpdateFleetAttributes(UpdateFleetAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
        public virtual IAsyncResult BeginUpdateFleetAttributes(UpdateFleetAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateFleetAttributesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
        public virtual UpdateFleetAttributesResponse EndUpdateFleetAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleetCapacity

        /// <summary>
        /// Updates capacity settings for a fleet. Use this action to specify the number of EC2
        /// instances (hosts) that you want this fleet to contain. Before calling this action,
        /// you may want to call <a>DescribeEC2InstanceLimits</a> to get the maximum capacity
        /// based on the fleet's EC2 instance type.
        /// 
        ///  
        /// <para>
        /// Specify minimum and maximum number of instances. Amazon GameLift will not change fleet
        /// capacity to values fall outside of this range. This is particularly important when
        /// using auto-scaling (see <a>PutScalingPolicy</a>) to allow capacity to adjust based
        /// on player demand while imposing limits on automatic adjustments.
        /// </para>
        ///  
        /// <para>
        /// To update fleet capacity, specify the fleet ID and the number of instances you want
        /// the fleet to host. If successful, Amazon GameLift starts or terminates instances so
        /// that the fleet's active instance count matches the desired instance count. You can
        /// view a fleet's current capacity information by calling <a>DescribeFleetCapacity</a>.
        /// If the desired instance count is higher than the instance type's limit, the "Limit
        /// Exceeded" exception occurs.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetCapacity service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        public virtual UpdateFleetCapacityResponse UpdateFleetCapacity(UpdateFleetCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetCapacityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetCapacity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        public virtual IAsyncResult BeginUpdateFleetCapacity(UpdateFleetCapacityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetCapacity.</param>
        /// 
        /// <returns>Returns a  UpdateFleetCapacityResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        public virtual UpdateFleetCapacityResponse EndUpdateFleetCapacity(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetCapacityResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleetPortSettings

        /// <summary>
        /// Updates port settings for a fleet. To update settings, specify the fleet ID to be
        /// updated and list the permissions you want to update. List the permissions you want
        /// to add in <code>InboundPermissionAuthorizations</code>, and permissions you want to
        /// remove in <code>InboundPermissionRevocations</code>. Permissions to be removed must
        /// match existing fleet permissions. If successful, the fleet ID for the updated fleet
        /// is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
        public virtual UpdateFleetPortSettingsResponse UpdateFleetPortSettings(UpdateFleetPortSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetPortSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetPortSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateFleetPortSettings(UpdateFleetPortSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetPortSettings.</param>
        /// 
        /// <returns>Returns a  UpdateFleetPortSettingsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
        public virtual UpdateFleetPortSettingsResponse EndUpdateFleetPortSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetPortSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGameServer

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Updates information about a registered game server. This action is called by a game
        /// server process that is running on an instance in a game server group. There are three
        /// reasons to update game server information: (1) to change the utilization status of
        /// the game server, (2) to report game server health status, and (3) to change game server
        /// metadata. A registered game server should regularly report health and should update
        /// utilization status when it is supporting gameplay so that GameLift FleetIQ can accurately
        /// track game server availability. You can make all three types of updates in the same
        /// request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To update the game server's utilization status, identify the game server and game
        /// server group and specify the current utilization status. Use this status to identify
        /// when game servers are currently hosting games and when they are available to be claimed.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To report health status, identify the game server and game server group and set health
        /// check to HEALTHY. If a game server does not report health status for a certain length
        /// of time, the game server is no longer considered healthy and will be eventually de-registered
        /// from the game server group to avoid affecting utilization metrics. The best practice
        /// is to report health every 60 seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To change game server metadata, provide updated game server data and custom sort key
        /// values.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Once a game server is successfully updated, the relevant statuses and timestamps are
        /// updated.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServer service method.</param>
        /// 
        /// <returns>The response from the UpdateGameServer service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServer">REST API Reference for UpdateGameServer Operation</seealso>
        public virtual UpdateGameServerResponse UpdateGameServer(UpdateGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerResponseUnmarshaller.Instance;

            return Invoke<UpdateGameServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServer">REST API Reference for UpdateGameServer Operation</seealso>
        public virtual IAsyncResult BeginUpdateGameServer(UpdateGameServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameServer.</param>
        /// 
        /// <returns>Returns a  UpdateGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServer">REST API Reference for UpdateGameServer Operation</seealso>
        public virtual UpdateGameServerResponse EndUpdateGameServer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGameServerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGameServerGroup

        /// <summary>
        /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
        /// is in preview release and is subject to change.</b> 
        /// 
        ///  
        /// <para>
        /// Updates GameLift FleetIQ-specific properties for a game server group. These properties
        /// include instance rebalancing and game server protection. Many Auto Scaling group properties
        /// are updated directly. These include autoscaling policies, minimum/maximum/desired
        /// instance counts, and launch template. 
        /// </para>
        ///  
        /// <para>
        /// To update the game server group, specify the game server group ID and provide the
        /// updated values.
        /// </para>
        ///  
        /// <para>
        /// Updated properties are validated to ensure that GameLift FleetIQ can continue to perform
        /// its core instance rebalancing activity. When you change Auto Scaling group properties
        /// directly and the changes cause errors with GameLift FleetIQ activities, an alert is
        /// sent.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-asgroups.html">Updating
        /// a GameLift FleetIQ-Linked Auto Scaling Group</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGameServerGroup service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServerGroup">REST API Reference for UpdateGameServerGroup Operation</seealso>
        public virtual UpdateGameServerGroupResponse UpdateGameServerGroup(UpdateGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGameServerGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServerGroup">REST API Reference for UpdateGameServerGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateGameServerGroup(UpdateGameServerGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameServerGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServerGroup">REST API Reference for UpdateGameServerGroup Operation</seealso>
        public virtual UpdateGameServerGroupResponse EndUpdateGameServerGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGameServerGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGameSession

        /// <summary>
        /// Updates game session properties. This includes the session name, maximum player count,
        /// protection policy, which controls whether or not an active game session can be terminated
        /// during a scale-down event, and the player session creation policy, which controls
        /// whether or not new players can join the session. To update a game session, specify
        /// the game session ID and the values you want to change. If successful, an updated <a>GameSession</a>
        /// object is returned. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession service method.</param>
        /// 
        /// <returns>The response from the UpdateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Resolve the conflict before
        /// retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        public virtual UpdateGameSessionResponse UpdateGameSession(UpdateGameSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateGameSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        public virtual IAsyncResult BeginUpdateGameSession(UpdateGameSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameSession.</param>
        /// 
        /// <returns>Returns a  UpdateGameSessionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        public virtual UpdateGameSessionResponse EndUpdateGameSession(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGameSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGameSessionQueue

        /// <summary>
        /// Updates settings for a game session queue, which determines how new game session requests
        /// in the queue are processed. To update settings, specify the queue name to be updated
        /// and provide the new settings. When updating destinations, provide a complete list
        /// of destinations. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-intro.html">
        /// Using Multi-Region Queues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSessionQueue service method.</param>
        /// 
        /// <returns>The response from the UpdateGameSessionQueue service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        public virtual UpdateGameSessionQueueResponse UpdateGameSessionQueue(UpdateGameSessionQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateGameSessionQueueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSessionQueue operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameSessionQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        public virtual IAsyncResult BeginUpdateGameSessionQueue(UpdateGameSessionQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameSessionQueue.</param>
        /// 
        /// <returns>Returns a  UpdateGameSessionQueueResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        public virtual UpdateGameSessionQueueResponse EndUpdateGameSessionQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGameSessionQueueResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMatchmakingConfiguration

        /// <summary>
        /// Updates settings for a FlexMatch matchmaking configuration. These changes affect all
        /// matches and game sessions that are created after the update. To update settings, specify
        /// the configuration name to be updated and provide the new settings. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-configuration.html">
        /// Design a FlexMatch Matchmaker</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchmakingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateMatchmakingConfiguration service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        public virtual UpdateMatchmakingConfigurationResponse UpdateMatchmakingConfiguration(UpdateMatchmakingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateMatchmakingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchmakingConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMatchmakingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateMatchmakingConfiguration(UpdateMatchmakingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMatchmakingConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateMatchmakingConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        public virtual UpdateMatchmakingConfigurationResponse EndUpdateMatchmakingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMatchmakingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRuntimeConfiguration

        /// <summary>
        /// Updates the current runtime configuration for the specified fleet, which tells Amazon
        /// GameLift how to launch server processes on instances in the fleet. You can update
        /// a fleet's runtime configuration at any time after the fleet is created; it does not
        /// need to be in an <code>ACTIVE</code> status.
        /// 
        ///  
        /// <para>
        /// To update runtime configuration, specify the fleet ID and provide a <code>RuntimeConfiguration</code>
        /// object with an updated set of server process configurations.
        /// </para>
        ///  
        /// <para>
        /// Each instance in a Amazon GameLift fleet checks regularly for an updated runtime configuration
        /// and changes how it launches server processes to comply with the latest version. Existing
        /// server processes are not affected by the update; runtime configuration changes are
        /// applied gradually as existing processes shut down and new processes are launched during
        /// Amazon GameLift's normal process recycling activity.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateRuntimeConfiguration service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        public virtual UpdateRuntimeConfigurationResponse UpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuntimeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuntimeConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateRuntimeConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        public virtual UpdateRuntimeConfigurationResponse EndUpdateRuntimeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuntimeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateScript

        /// <summary>
        /// Updates Realtime script metadata and content.
        /// 
        ///  
        /// <para>
        /// To update script metadata, specify the script ID and provide updated name and/or version
        /// values. 
        /// </para>
        ///  
        /// <para>
        /// To update script content, provide an updated zip file by pointing to either a local
        /// file or an Amazon S3 bucket location. You can use either method regardless of how
        /// the original script was uploaded. Use the <i>Version</i> parameter to track updates
        /// to the script.
        /// </para>
        ///  
        /// <para>
        /// If the call is successful, the updated metadata is stored in the script record and
        /// a revised script is uploaded to the Amazon GameLift service. Once the script is updated
        /// and acquired by a fleet instance, the new version is used for all new game sessions.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScript service method.</param>
        /// 
        /// <returns>The response from the UpdateScript service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateScript">REST API Reference for UpdateScript Operation</seealso>
        public virtual UpdateScriptResponse UpdateScript(UpdateScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScriptResponseUnmarshaller.Instance;

            return Invoke<UpdateScriptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScript operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateScript">REST API Reference for UpdateScript Operation</seealso>
        public virtual IAsyncResult BeginUpdateScript(UpdateScriptRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScriptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScript.</param>
        /// 
        /// <returns>Returns a  UpdateScriptResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateScript">REST API Reference for UpdateScript Operation</seealso>
        public virtual UpdateScriptResponse EndUpdateScript(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateScriptResponse>(asyncResult);
        }

        #endregion
        
        #region  ValidateMatchmakingRuleSet

        /// <summary>
        /// Validates the syntax of a matchmaking rule or rule set. This operation checks that
        /// the rule set is using syntactically correct JSON and that it conforms to allowed property
        /// expressions. To validate syntax, provide a rule set JSON string.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateMatchmakingRuleSet service method.</param>
        /// 
        /// <returns>The response from the ValidateMatchmakingRuleSet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ValidateMatchmakingRuleSet">REST API Reference for ValidateMatchmakingRuleSet Operation</seealso>
        public virtual ValidateMatchmakingRuleSetResponse ValidateMatchmakingRuleSet(ValidateMatchmakingRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<ValidateMatchmakingRuleSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateMatchmakingRuleSet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateMatchmakingRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ValidateMatchmakingRuleSet">REST API Reference for ValidateMatchmakingRuleSet Operation</seealso>
        public virtual IAsyncResult BeginValidateMatchmakingRuleSet(ValidateMatchmakingRuleSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateMatchmakingRuleSet.</param>
        /// 
        /// <returns>Returns a  ValidateMatchmakingRuleSetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ValidateMatchmakingRuleSet">REST API Reference for ValidateMatchmakingRuleSet Operation</seealso>
        public virtual ValidateMatchmakingRuleSetResponse EndValidateMatchmakingRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<ValidateMatchmakingRuleSetResponse>(asyncResult);
        }

        #endregion
        
    }
}
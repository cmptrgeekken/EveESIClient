﻿using System;
using System.Collections.Generic;
using System.Text;
using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Corporation;
using RestSharp;

namespace EveESIClient.Corporation
{
    public class CorporationClient
    {
        private readonly IHttpClient _client;
        internal CorporationClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Public information about a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>Public information about a corporation</returns>
        public ESIResponse<GetCorporationResponse> GetCorporation(Int64 corporationId)
        {
            var request = RestRequestHelper.CreateRestRequest($"corporations/{corporationId}/", Method.GET);

            return _client.Execute<GetCorporationResponse>(request);
        }

        /// <summary>
        /// Get a list of all the alliances a corporation has been a member of
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>Alliance history for the given corporation</returns>
        public ESIResponse<List<GetCorporationAllianceHistoryResponse>> GetCorporationAllianceHistory(Int64 corporationId)
        {
            var request = RestRequestHelper.CreateRestRequest($"corporations/{corporationId}/alliancehistory/", Method.GET);

            return _client.Execute<List<GetCorporationAllianceHistoryResponse>>(request);
        }

        /// <summary>
        /// Returns a list of blueprints the corporation owns
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>List of corporation blueprints</returns>
        public ESIResponse<List<GetCorporationBlueprintsResponse>> GetCorporationBlueprints(string authToken, Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/blueprints/",
                Method.GET, authToken);
            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetCorporationBlueprintsResponse>>(request);
        }

        /// <summary>
        /// Returns logs recorded in the past seven days from all audit log secure containers (ALSC) owned by a given corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>List of corporation ALSC logs</returns>
        public ESIResponse<List<GetCorporationContainerLogsResponse>> GetCorporationContainerLogs(string authToken,
            Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/containers/logs/",
                Method.GET, authToken);
            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetCorporationContainerLogsResponse>>(request);
        }

        /// <summary>
        /// Return corporation hangar and wallet division names, only show if a division is not using the default name
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>List of corporation division names</returns>
        public ESIResponse<GetCorporationDivisionsResponse> GetCorporationDivisions(string authToken,
            Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/divisions/",
                Method.GET, authToken);

            return _client.Execute<GetCorporationDivisionsResponse>(request);
        }

        /// <summary>
        /// Return a corporation’s facilities
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>List of corporation facilities</returns>
        public ESIResponse<List<GetCorporationFacilitiesResponse>> GetCorpotaionFacilities(string authToken,
            Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/facilities/",
                Method.GET, authToken);

            return _client.Execute<List<GetCorporationFacilitiesResponse>>(request);
        }

        /// <summary>
        /// Get the icon urls for a corporation
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>Urls for icons for the given corporation id and server</returns>
        public ESIResponse<GetCorporationIconResponse> GetCorporationIcon(Int64 corporationId)
        {
            var request = RestRequestHelper.CreateRestRequest($"corporations/{corporationId}/icons/",
                Method.GET);

            return _client.Execute<GetCorporationIconResponse>(request);
        }

        /// <summary>
        /// Returns a corporation’s medals
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of medals</returns>
        public ESIResponse<List<GetCorporationMetalsResponse>> GetCorporationMedals(string authToken,
            Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/medals/",
                Method.GET, authToken);
            request.AddParameter("page", page, ParameterType.QueryString);


            return _client.Execute<List<GetCorporationMetalsResponse>>(request);
        }

        /// <summary>
        /// Returns medals issued by a corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of issued medals</returns>
        public ESIResponse<List<GetCorporationIssuedMedals>> GetCorporationIssuedMedals(string authToken,
            Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/medals/issued/",
                Method.GET, authToken);
            request.AddParameter("page", page, ParameterType.QueryString);


            return _client.Execute<List<GetCorporationIssuedMedals>>(request);
        }

        /// <summary>
        /// Return the current member list of a corporation, the token’s character need to be a member of the corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>List of member character IDs</returns>
        public ESIResponse<List<Int64>> GetCorporationMembers(string authToken,
            Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/members/",
                Method.GET, authToken);

            return _client.Execute<List<Int64>>(request);
        }

        /// <summary>
        /// Return a corporation’s member limit, not including CEO himself
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>The corporation’s member limit</returns>
        public ESIResponse<int> GetCorporationMemberLimit(string authToken, Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/members/limit/",
                Method.GET, authToken);

            return _client.Execute<int>(request);
        }

        /// <summary>
        /// Returns a corporation’s members’ titles
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>A list of members and theirs titles</returns>
        public ESIResponse<List<GetCorporationMemberTitlesResponse>> GetCorporationMemberTitles(string authToken,
            Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/members/titles/",
                Method.GET, authToken);

            return _client.Execute<List<GetCorporationMemberTitlesResponse>>(request);
        }

        /// <summary>
        /// Returns additional information about a corporation’s members which helps tracking their activities
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>List of member character IDs</returns>
        public ESIResponse<List<GetCorporationMemberTracking>> GetCorporationMemberTracking(string authToken,
            Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/membertracking/",
                Method.GET, authToken);

            return _client.Execute<List<GetCorporationMemberTracking>>(request);
        }

        /// <summary>
        /// Get a list of corporation outpost IDs 
        /// </summary>
        /// <remarks>
        /// Note: This endpoint will be removed once outposts are migrated to Citadels as talked about in this blog: 
        /// https://community.eveonline.com/news/dev-blogs/the-next-steps-in-structure-transition/
        /// </remarks>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>List of corporation outpost IDs</returns>
        public ESIResponse<List<Int64>> GetCorporationOutposts(string authToken,
            Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/outposts/",
                Method.GET, authToken);
            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<Int64>>(request);
        }

        /// <summary>
        /// Get details about a given outpost.
        /// <remarks>
        /// Note: This endpoint will be removed once outposts are migrated to Citadels as talked about in this blog:
        /// https://community.eveonline.com/news/dev-blogs/the-next-steps-in-structure-transition/
        /// </remarks>
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="outpostId">A station (outpost) ID</param>
        /// <returns>Details about the given outpost</returns>
        public ESIResponse<GetCorporationOutpostDetailResponse> GetCorporationOutpostDetail(string authToken,
            Int64 corporationId, Int64 outpostId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/outposts/{outpostId}/",
                Method.GET, authToken);

            return _client.Execute<GetCorporationOutpostDetailResponse>(request);
        }

        /// <summary>
        /// Return the roles of all members if the character has the personnel manager role or any grantable role.
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="authToken">Access token to use</param>
        /// <returns>List of member character ID’s and roles</returns>
        public ESIResponse<List<GetCorporationMemberRolesResponse>> GetCorporationMemberRoles(string authToken,
            Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/roles/",
                Method.GET, authToken);

            return _client.Execute<List<GetCorporationMemberRolesResponse>>(request);
        }

        /// <summary>
        /// Return how roles have changed for a coporation’s members, up to a month
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>List of role changes</returns>
        public ESIResponse<List<GetCorporationMemberRolesHistoryResponse>> GetCorporationMemberRolesHistory(string authToken,
            Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/roles/history/",
                Method.GET, authToken);

            return _client.Execute<List<GetCorporationMemberRolesHistoryResponse>>(request);
        }

        /// <summary>
        /// Return the current shareholders of a corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>List of shareholders</returns>
        public ESIResponse<List<GetCorporationShareholdersResponse>> GetCorporationShareholders(string authToken,
            Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/shareholders/",
                Method.GET, authToken);
            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetCorporationShareholdersResponse>>(request);
        }

        /// <summary>
        /// Return corporation standings from agents, NPC corporations, and factions
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of standings</returns>
        public ESIResponse<List<GetCorporationStandingsResponse>> GetCorporationStandings(string authToken, Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/standings/",
                Method.GET, authToken);
            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetCorporationStandingsResponse>>(request);
        }

        /// <summary>
        /// Returns list of corporation starbases (POSes)
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>List of starbases (POSes)</returns>
        public ESIResponse<List<GetCorporationStarbasesResponse>> GetCorporationStarbases(string authToken, Int64 corporationId,
            int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/starbases/",
                Method.GET, authToken);
            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetCorporationStarbasesResponse>>(request);
        }

        /// <summary>
        /// Returns various settings and fuels of a starbase (POS)
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="starbaseId">An EVE starbase (POS) ID</param>
        /// <param name="systemId">The solar system this starbase (POS) is located in</param>
        /// <returns>List of starbases</returns>
        public ESIResponse<GetCorporationStarbaseDetailResponse> GetCorporationStarbaseDetail(string authToken,
            Int64 corporationId, Int64 starbaseId, Int64 systemId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/starbases/{starbaseId}/",
                Method.GET, authToken);
            request.AddParameter("system_id ", systemId, ParameterType.QueryString);

            return _client.Execute<GetCorporationStarbaseDetailResponse>(request);
        }

        /// <summary>
        /// Get a list of corporation structures
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>List of corporation structures’ information</returns>
        public ESIResponse<List<GetCorporationStructuresResponse>> GetCorporationStructures(string authToken,
            Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/structures/",
                Method.GET, authToken);
            request.AddParameter("page ", page, ParameterType.QueryString);

            return _client.Execute<List<GetCorporationStructuresResponse>>(request);
        }

        /// <summary>
        /// Update the vulnerability window schedule of a corporation structure
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="structureId">A structure ID</param>
        /// <param name="newSchedule">New vulnerability window schedule for the structure</param>
        /// <returns>IsSuccessful will be true o a successful call.</returns>
        public ESIResponse<object> UpdateCorporationStructureVulnerabilitySchedule(string authToken,
            Int64 corporationId, Int64 structureId,
            List<UpdateCorporationStructureVulnerabilityScheduleInput> newSchedule)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/structures/{structureId}/",
                Method.PUT, authToken);
            request.AddBody(newSchedule);

            return _client.Execute<object>(request);
        }

        /// <summary>
        /// Returns a corporation’s titles
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>A list of titles</returns>
        public ESIResponse<List<GetCorporationTitlesResponse>> GetCorporationTitles(string authToken,
            Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/titles/",
                Method.GET, authToken);

            return _client.Execute<List<GetCorporationTitlesResponse>>(request);
        }

        /// <summary>
        /// Resolve a set of corporation IDs to corporation names
        /// </summary>
        /// <param name="corporationIds">corporation IDs to resolve</param>
        /// <returns>List of id/name associations</returns>
        public ESIResponse<List<GetCorporationNamesResponse>> GetCorporationNames(Int64[] corporationIds)
        {
            var request = RestRequestHelper.CreateRestRequest($"corporations/names/", Method.GET);
            request.AddParameter("corporation_ids", string.Join(",", corporationIds), ParameterType.QueryString);

            return _client.Execute<List<GetCorporationNamesResponse>>(request);
        }

        /// <summary>
        /// Get a list of npc corporations
        /// </summary>
        /// <returns>A list of npc corporation ids</returns>
        public ESIResponse<List<Int64>> GetNpcCorporations()
        {
            var request = RestRequestHelper.CreateRestRequest($"corporations/npccorps/", Method.GET);

            return _client.Execute<List<Int64>>(request);
        }
    }
}
﻿//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading.Tasks;
//using WebAPI.ViewModels.Common;
//using WebAPI.ViewModels.System.Languages;

//namespace WebAPI.ApiIntegration
//{
//    public class LanguageApiClient : BaseApiClient, ILanguageApiClient
//    {
//        public LanguageApiClient(IHttpClientFactory httpClientFactory,
//                   IHttpContextAccessor httpContextAccessor,
//                    IConfiguration configuration)
//            : base(httpClientFactory, httpContextAccessor, configuration)
//        {
//        }
//        public async Task<ApiResult<List<LanguageVm>>> GetAll()
//        {
//            return await GetAsync<ApiResult<List<LanguageVm>>>("/api/languages");
//        }
//    }
//}

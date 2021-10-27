﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Datahub.Core.UserTracking;
using Datahub.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Datahub.Tests
{
    public class DbTests
    {
        private ServiceProvider _serviceProvider;
        private string _cosmosCxnStr = @"AccountEndpoint=https://dh-portal-cosmosdb-dev.documents.azure.com:443/;AccountKey=QAwclaaNFK2G5foH4g9NqGa2xBJfLS46n53LW3LKOqYMiGxBI4J9H3sOSSAwx9ZI7YHqPQzc5w3QZD29vSZBDg==;";
        private string _userId = "myuserid";
        [Fact]
        public async void GivenCosmosCxnStr_ValidateConnection()
        {
            LoadServices();

            using (var scope = _serviceProvider.CreateScope())
            {


                var myDataService = scope.ServiceProvider.GetService<UserLocationManagerService>();
                var userRecentActions = await myDataService.ReadRecentNavigations(_userId);

                if (userRecentActions != null)
                {
                    await myDataService.DeleteUserRecent(_userId);
                }

                userRecentActions = await myDataService.ReadRecentNavigations(_userId);
                Assert.True(userRecentActions == null);

                var userRecentActions1 = new UserRecentLink() { UserRecentActionId = Guid.NewGuid(), DataProject = "ABC", DatabricksURL = "https://databricks", accessedTime = DateTimeOffset.Now };
                var userRecentActions2 = new UserRecentLink() { UserRecentActionId = Guid.NewGuid(), DataProject = "ABC", DatabricksURL = "https://databricks", accessedTime = DateTimeOffset.Now };
                var userRecentActions3 = new UserRecentLink() { UserRecentActionId = Guid.NewGuid(), DataProject = "ABC", DatabricksURL = "https://databricks", accessedTime = DateTimeOffset.Now };
                var userRecentActions4 = new UserRecentLink() { UserRecentActionId = Guid.NewGuid(), DataProject = "ABC", DatabricksURL = "https://databricks", accessedTime = DateTimeOffset.Now };
                var userRecentActions5 = new UserRecentLink() { UserRecentActionId = Guid.NewGuid(), DataProject = "ABC", DatabricksURL = "https://databricks", accessedTime = DateTimeOffset.Now };
                var userRecent = new UserRecent() { UserId = _userId };
                userRecent.UserRecentActions.Add(userRecentActions1);
                userRecent.UserRecentActions.Add(userRecentActions2);
                userRecent.UserRecentActions.Add(userRecentActions3);
                userRecent.UserRecentActions.Add(userRecentActions4);
                userRecent.UserRecentActions.Add(userRecentActions5);


                await myDataService.RegisterNavigation(userRecent);
                userRecentActions = await myDataService.ReadRecentNavigations(_userId);

                Assert.True(userRecentActions.UserRecentActions.Count == 5);
            }
        }


       

        private void LoadServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<UserTrackingContext>(options =>
            {

                options.UseCosmos(
                   _cosmosCxnStr,
                    databaseName: "datahub-catalog-db"
               );
            });


            serviceCollection.AddLogging(builder =>
            {
                builder.ClearProviders();
                builder.AddConsole();
            });
            serviceCollection.AddScoped<UserLocationManagerService>();
            serviceCollection.AddSingleton<IKeyVaultService, KeyVaultService>();
            serviceCollection.AddScoped<UserLocationManagerService>();
            serviceCollection.AddSingleton<CommonAzureServices>();
            serviceCollection.AddScoped<DataLakeClientService>();

            serviceCollection.AddScoped<IUserInformationService, OfflineUserInformationService>();
            serviceCollection.AddSingleton<IMSGraphService, OfflineMSGraphService>();

            serviceCollection.AddScoped<IApiService, ApiService>();
            serviceCollection.AddScoped<IApiCallService, ApiCallService>();


            _serviceProvider = serviceCollection.BuildServiceProvider();
        }




        //Task InitializeAsync()
        //{


        //    return Task.CompletedTask;
        //}
    }
}

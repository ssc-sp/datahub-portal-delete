using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NRCan.Datahub.Portal.Services;
using NRCan.Datahub.Shared.Data;
using NRCan.Datahub.Shared.Services;

namespace NRCan.Datahub.Portal.Controllers
{
    [Route("[controller]/[action]")]
    [AllowAnonymous]
    public class PublicController: Controller
    {
        private ILogger<PublicController> _logger { get; set; }
        private IApiService _apiService { get; set; }
        private IPublicDataFileService _pubFileService { get; set; }

        public PublicController(
            ILogger<PublicController> logger, 
            IApiService apiService,
            IPublicDataFileService pubFileService
            )
        {
            _logger = logger;
            _apiService = apiService;
            _pubFileService = pubFileService;
        }

        public IActionResult HelloWorld()
        {
            _logger.LogDebug("Unauthenticated hello world");
            return Ok("hello world");
        }

        public async Task<IActionResult> BlobTest()
        {
            var filemd = new FileMetaData()
            {
                filename = "privacy.html",
                name = "privacy.html"
            };

            var project = "canmetrobo";

            _logger.LogDebug($"Downloading {filemd.filename} from project {project}");

            var uri = await _apiService.GetUserDelegationSasBlob(filemd, project);

            return Redirect(uri.ToString());
        }

        public async Task<IActionResult> DataLakeTest()
        {
            var filemd = new FileMetaData()
            {
                folderpath = "nrcan-rncan.gc.ca/alexander.khavich",
                filename = "serious.gif"
            };

            _logger.LogDebug($"Downloading {filemd.filename}");

            var uri = await _apiService.DownloadFile(filemd);
            return Redirect(uri.ToString());
        }

        [Route("{fileId}")]
        public async Task<IActionResult> DownloadFile(string fileId)
        {
            try
            {
                var fileIdGuid = Guid.Parse(fileId);
                var result = await _pubFileService.DownloadPublicUrlSharedFile(fileIdGuid);
                if (result == null)
                {
                    _logger.LogError($"File not found: {fileId}");
                    return NotFound();
                }
                else
                {
                    return Redirect(result.ToString());
                }
            }
            catch (FormatException)
            {
                _logger.LogError($"Invalid file id (not a guid): {fileId}");
                return NotFound();
            }
        }
    }
}
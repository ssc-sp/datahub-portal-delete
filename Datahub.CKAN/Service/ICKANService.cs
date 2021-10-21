﻿using Datahub.Metadata.DTO;
using System.Threading.Tasks;

namespace Datahub.CKAN.Service
{
    public interface ICKANService
    {
        Task<CKANApiResult> CreatePackage(FieldValueContainer fieldValues);
    }

    public record CKANApiResult(bool Succeeded, string ErrorMessage);
}
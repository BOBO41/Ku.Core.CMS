﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vino.Core.CMS.Core.DependencyResolver;
using Vino.Core.CMS.Domain.Dto.System;

namespace Vino.Core.CMS.Service.System
{
    public interface IFunctionService
    {
        Task<(int count, List<FunctionDto> list)> GetListAsync(long? parentId, int pageIndex, int pageSize);

        Task SaveAsync(FunctionDto dto);

        Task<List<FunctionDto>> GetParentsAsync(long parentId);

        Task<FunctionDto> GetByIdAsync(long id);

        Task DeleteAsync(long id);

        Task<List<FunctionDto>> GetSubModulesAsync(long? parentId);

    }
}
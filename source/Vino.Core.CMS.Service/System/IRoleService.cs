﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vino.Core.CMS.Core.DependencyResolver;
using Vino.Core.CMS.Domain.Dto.System;

namespace Vino.Core.CMS.Service.System
{
    public interface IRoleService
    {
        Task<(int count, List<RoleDto> items)> GetListAsync(int pageIndex, int pageSize);

        Task<List<RoleDto>> GetAllAsync();

        Task<RoleDto> GetByIdAsync(long id);

        Task SaveAsync(RoleDto dto);

        Task DeleteAsync(long id);

        Task<List<FunctionDto>> GetFunctionsWithRoleAuthAsync(long roleId, long? parentFunctionId);

        Task SaveRoleAuthAsync(long RoleId, long FunctionId, bool hasAuth);
    }
}

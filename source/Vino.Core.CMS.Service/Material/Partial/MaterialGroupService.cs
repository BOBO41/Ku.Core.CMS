//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//
// <copyright file="IMaterialGroupService.cs">
//        最后生成时间：2018-01-26 20:52
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Vino.Core.Cache;
using Vino.Core.CMS.Data.Common;
using Vino.Core.CMS.Data.Repository.Material;

namespace Vino.Core.CMS.Service.Material
{
    public partial interface IMaterialGroupService
    {
    }

    public partial class MaterialGroupService : BaseService, IMaterialGroupService
    {
        protected readonly IMaterialGroupRepository _repository;

        public MaterialGroupService(VinoDbContext context, ICacheService cache, IMapper mapper, IMaterialGroupRepository repository)
            : base(context, cache, mapper)
        {
            this._repository = repository;
        }
    }
}
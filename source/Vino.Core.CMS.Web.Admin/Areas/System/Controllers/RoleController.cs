﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vino.Core.CMS.Core.Exceptions;
using Vino.Core.CMS.Domain.Dto.System;
using Vino.Core.CMS.Service.System;
using Vino.Core.CMS.Web.Base;

namespace Vino.Core.CMS.Web.Admin.Areas.System.Controllers
{
    [Area("System")]
    [Authorize]
    public class RoleController : BaseController
    {
        private IRoleService service;
        private IFunctionModuleService fmService;
        public RoleController(IRoleService _service, IFunctionModuleService _fmService)
        {
            this.service = _service;
            this.fmService = _fmService;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> GetList(int page, int rows)
        {
            var data = await service.GetListAsync(page, rows);
            return PagerData(data.items, page, rows, data.count);
        }

        public async Task<IActionResult> Edit(long? id)
        {
            if (id.HasValue)
            {
                //编辑
                var model = await service.GetByIdAsync(id.Value);
                if (model == null)
                {
                    throw new VinoDataNotFoundException("无法取得角色数据!");
                }
                ViewData["Mode"] = "Edit";
                return View(model);
            }
            else
            {
                //新增
                RoleDto dto = new RoleDto();
                dto.IsEnable = true;
                ViewData["Mode"] = "Add";
                return View(dto);
            }
        }

        /// <summary>
        /// 保存角色
        /// </summary>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Save(RoleDto model)
        {
            await service.SaveAsync(model);
            return JsonData(true);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(long id)
        {
            await service.DeleteAsync(id);
            return JsonData(true);
        }

        [Authorize]
        public IActionResult RoleAuth()
        {
            return View();
        }

        [Authorize]
        public IActionResult GetRoleAuth(long pid)
        {
            //var menus = service.GetMenusByParentId(pid);
            return JsonData(null);
        }
    }
}

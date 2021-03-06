﻿//----------------------------------------------------------------
// Copyright (C) 2018 kulend 版权所有
//
// 文件名：PictureDto.cs
// 功能描述：图片素材 数据传输类
//
// 创建者：kulend@qq.com
// 创建时间：2018-02-04 19:13
//
//----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Ku.Core.EventBus;

namespace Ku.Core.CMS.Domain.Dto.Material
{
    /// <summary>
    /// 图片素材
    /// </summary>
    public class PictureDto : MaterialDto
    {
        public string ThumbPath { set; get; }

        /// <summary>
        /// 是否已压缩
        /// </summary>
        public bool IsCompressed { set; get; }

        public int TryCompressCount { set; get; } = 0;
    }
}

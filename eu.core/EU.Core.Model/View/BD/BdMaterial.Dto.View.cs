﻿/*  代码由框架生成,任何更改都可能导致被代码生成器覆盖，可自行修改。
* BdMaterial.cs
*
*功 能： N / A
* 类 名： BdMaterial
*
* Ver    变更日期 负责人  变更内容
* ───────────────────────────────────
*V0.01  2024/10/29 13:14:28  SimonHsiao   初版
*
* Copyright(c) 2024 EU Corporation. All Rights Reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　作者：SimonHsiao                                                  │
*└──────────────────────────────────┘
*/

namespace EU.Core.Model.Models;

/// <summary>
/// 物料管理(Dto.View)
/// </summary>
public class BdMaterialDto : BdMaterial
{

    /// <summary>
    /// 物料名称
    /// </summary>
    public string MaterialName { get; set; }

    /// <summary>
    /// 单位
    /// </summary>
    public string UnitName { get; set; }
}

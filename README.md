<h1 align="center">🌍 miniK GIS 系统</h1>

<p align="center">
轻量级 ArcGIS Engine 桌面程序，用于空间分析、图层管理与 AI 目标识别扩展 💻🧠
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Platform-Windows-blue?logo=windows&style=plastic"/>
  <img src="https://img.shields.io/badge/Language-C%23-68217A?logo=c-sharp&style=plastic"/>
  <img src="https://img.shields.io/badge/GIS-ArcGIS--Engine-118822?style=plastic"/>
</p>


---
<div align ="center">
  
## 📌 项目简介

| 项目名称 | miniK GIS 桌面系统 |
|----------|--------------------|
| 适用专业 | 地理信息科学 / 空间分析 |
| 核心框架 | C# + WinForms + ArcGIS Engine |
| 项目特性 | 可扩展、轻量、集成空间分析与 AI 接口 |
| 目标用途 | 学术研究 / 学生项目 / 空间数据可视化实验平台 |

</div>
---
<div align ="center">
  
## ✨ 当前功能一览

| 功能 | 描述 |
|------|------|
| ✅ 授权绑定 | 自动调用 `ESRI.ArcGIS.RuntimeManager.Bind` 绑定 Runtime |
| 🔐 登录验证 | 弹出窗口验证账号密码（miniKsa / 123123） |
| 🪟 主界面 | 多功能菜单栏与地图控件预留区域 |
| ℹ️ 关于弹窗 | 弹出包含作者与版本信息的窗口 |
| 📈 KDE 模块 | （预留）核密度分析工具，用于空间热点识别 |
| 🤖 YOLO AI 接口 | （预留）图像识别并映射到地图上 |

</div>
---
<div align ="center">
  
## 🧱 技术栈总表

| 类别 | 使用技术 | 描述 |
|------|----------|------|
| 编程语言 | `C#` | 主开发语言 |
| UI 框架 | `WinForms` | Windows 桌面 UI |
| GIS 引擎 | `ArcGIS Engine` | 提供地图展示、图层操作等功能 |
| 授权组件 | `ESRI.ArcGIS.RuntimeManager` | 管理 Engine 授权许可 |
| AI 模块（可选） | `YOLOv5` | 图像目标检测与空间叠加（未来扩展） |

</div>
---
<div align ="center">
  
## ⚙️ 环境与构建要求

| 要求项 | 描述 |
|--------|------|
| 系统 | Windows 10 / 11 |
| IDE | Visual Studio 2019 / 2022 |
| SDK | ArcGIS Engine SDK（推荐 10.2+） |
| .NET Framework | 4.7.2 或以上 |
| 依赖包 | `ESRI.ArcGIS.*` DLL 集合 |
| 登录账户 | 用户名：`miniKsa`，密码：`123123` |

</div>
---
<div align ="center">

## 🔮 规划功能

| 状态 | 功能模块 | 说明 |
|------|----------|------|
| 🟩 规划中 | ArcGIS 地图控件集成 | 支持地图显示与交互 |
| 🟩 规划中 | 图层加载 / 导入 | 支持 Shapefile、Raster |
| 🟩 规划中 | 核密度分析（KDE） | 基于 ArcEngine 或 GDAL |
| 🟩 规划中 | YOLO 图像识别 | 加载识别结果并空间映射 |
| 🟩 规划中 | 热力图可视化 | 支持颜色渐变渲染 |
| 🟩 规划中 | 导出地图 | 保存为图片 / PDF 文件 |

</div>

---


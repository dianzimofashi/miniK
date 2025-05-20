# miniK
原型计划、零号项目、毕业设计前瞻

# miniK GIS 系统 🗺️

> 轻量级 GIS 桌面程序，集成 ArcGIS Engine，支持空间分析、图层管理、目标识别等功能的可拓展平台。

---

## 📌 项目简介

`miniK` 是一个面向地理信息科学应用场景开发的 Windows 桌面 GIS 系统，基于 **C# WinForms** 与 **ArcGIS Engine SDK** 构建。目标是为用户提供一个可集成的空间数据分析环境，支持基础的图层加载、KDE 核密度分析，以及未来接入 AI 图像识别（如 YOLO）与遥感处理功能。

---

## ✨ 当前功能

- ✅ ArcGIS Runtime 授权自动绑定  
- ✅ 登录验证窗口（用户名/密码）  
- ✅ 主窗体界面与菜单系统  
- ✅ “关于 miniK” 信息弹窗  
- 🚧 可扩展：ArcGIS MapControl 地图加载、核密度分析、目标检测叠加...

---

## 🧱 技术栈

| 组件              | 描述 |
|------------------|------|
| `C#` + `WinForms` | 桌面界面开发 |
| `ArcGIS Engine`   | 地图展示与空间分析 |
| `ESRI.ArcGIS`     | 授权与工具支持 |
| `YOLO` (可选)     | 图像目标识别（计划集成） |

---

## 🚀 快速开始

### 环境要求

- Windows 10+
- Visual Studio 2019 / 2022
- 安装 ArcGIS Engine Runtime & SDK（建议 10.2+）
- .NET Framework 4.7.2+

### 构建步骤

```bash
git clone https://github.com/你的账号/miniK.git
cd miniK
# 用 Visual Studio 打开 miniK_independent.sln
# 构建并运行

<h1 align="center">🌍 miniK GIS 系统</h1>

<p align="center">
轻量级桌面 GIS 应用，内置 ArcGIS Engine、支持空间分析与 AI 模块扩展 💻🧠
</p>

<p align="center">
  <img src="https://img.shields.io/badge/platform-Windows-blue?logo=windows&style=for-the-badge"/>
  <img src="https://img.shields.io/badge/language-C%23-blueviolet?logo=c-sharp&style=for-the-badge"/>
  <img src="https://img.shields.io/badge/GIS-ArcGIS--Engine-green?style=for-the-badge"/>
</p>

---

## 📌 项目简介

`miniK` 是一个专为地理信息科学专业开发的 Windows 桌面 GIS 系统，基于 **C# WinForms** 与 **ArcGIS Engine SDK** 构建。该系统支持用户进行空间数据加载、分析与未来 AI 图像识别（如 YOLO）的扩展。

---

## ✨ 功能特色

| 功能模块                  | 描述                                                                 |
|---------------------------|----------------------------------------------------------------------|
| ✅ 授权绑定               | 启动时自动绑定 ArcGIS Runtime 授权                                   |
| 🔐 登录窗口               | 用户名 + 密码验证 (`miniKsa` / `123123`)                             |
| 🪟 主窗体界面             | 菜单栏、可拓展控件区域                                               |
| ℹ️ 关于窗口               | 弹窗展示作者、版本信息                                               |
| 📈 KDE 核密度分析         | （预留接口）用于空间热点分析计算                                     |
| 🤖 YOLO AI 模块（计划）   | 接入图像识别算法，用于空间对象检测与叠加                             |

---

## 🧱 技术栈总览

| 技术         | 说明                       |
|--------------|----------------------------|
| `C#`         | 主开发语言                 |
| `WinForms`   | 桌面 UI 框架               |
| `ArcGIS Engine` | GIS 分析与地图展示       |
| `ESRI.ArcGIS` DLLs | 授权与地图控件支持   |
| `YOLO` (可选) | 图像目标识别（扩展模块） |

---

## 🚀 快速开始

### ⚙️ 环境要求

- 🪟 Windows 10 / 11
- 🧰 Visual Studio 2019 / 2022
- 🧭 ArcGIS Engine Runtime + SDK（推荐 10.2+）
- 💡 .NET Framework 4.7.2+

---

### 🔧 构建运行

```bash
git clone https://github.com/dianzimofashi/miniK.git
cd miniK
# 在 Visual Studio 中打开 .sln 并运行

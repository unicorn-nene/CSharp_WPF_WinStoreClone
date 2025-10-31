###
- This project is for personal learning and resume/portfolio purposes only.
- The source code was written/recreated by me as a learning exercise, based on course materials.
- It is not for commercial use, and the original content is not distributed.
- It serves as an example for learning C#, WPF GUI programming, and event handling.
- It is intended as a portfolio piece for C#/WPF/XMAL desktop application development

- 本项目仅供个人学习和简历展示使用  
- 源代码是我自己根据课程内容练习学习编写/复现  
- 不用于商业用途，也不对外传播原始内容
- 个人学习 C# 和 WPF 编程的桌面程序
- 作为 C#/WPF/XMAL 桌面程序的作品集展示
###

Windows Store Clone (WPF + MahApps.Metro)

Overview

  This project is a Windows Store–style desktop application built with WPF and MahApps.Metro.
It simulates the modern, fluent design of the Microsoft Store app, featuring page navigation, animated transitions, and modular UI composition through reusable UserControls and Pages.
The application demonstrates MVVM-friendly UI architecture, page navigation using Frame, and custom content management through event-driven programming in C#.

Key Features

Modern Fluent-style UI
 - Built with MahApps.Metro, providing acrylic effects, shadows, and Metro styling
 - Fully resizable window with adaptive layout
   
Page-based Architecture
 - Organized in /Pages and /UserControls modules
 - Seamless navigation among main content, app details, and top apps view
 - Implements event-driven communication between pages
   
Dynamic Content Loading
 - Uses a single Frame control (MainWindowFrame) to host all content
 - Switches between views (Main, TopAppsWrapped, DownloadsAndUpdates, AppDetails) dynamically
 - Back navigation support via NavigationService
   
Modular UI Components
 - UserControl/AppDetailsTabContent: shows app detail tabs (e.g. Overview, Reviews)
 - UserControl/HamburgerMenuViews: sidebar-style navigation elements
 - Pages/: main content pages with event callbacks for interactions


Technical Highlights
- Built with WPF (.NET 6/7) and C# 10+
- UI styled using MahApps.Metro for a clean, Windows 11–like look
- Uses event binding (AppClicked, BackButtonClicked, etc.) for decoupled navigation
- Demonstrates Frame-based content hosting and dependency injection–ready structure

项目概述
  本项目是一个使用 WPF + MahApps.Metro 框架构建的 Windows 商店界面克隆程序，模仿了微软商店（Microsoft Store）的现代化 Fluent 风格。
程序采用 页面导航机制 与 模块化 UserControl 架构，通过 C# 事件机制实现不同页面之间的交互与切换。

主要特性
现代化 Fluent UI 界面
- 使用 MahApps.Metro 提供的 Metro 风格与圆角窗口
- 自适应布局与响应式界面

页面化结构设计
- /Pages 目录用于存放主页面（Main、TopAppsWrapped、DownloadsAndUpdates）
- /UserControls 目录封装独立 UI 模块，如应用卡片、菜单栏等
- 通过事件（AppClicked, BackButtonClicked）在页面间通信

动态页面加载
- 使用单一 Frame 控件 (MainWindowFrame) 动态加载内容
- 支持页面切换与回退 (NavigationService.GoBack()

技术亮点
- 使用 C# 10 + WPF (.NET 6) 开发
- UI 框架：MahApps.Metro
- 事件驱动导航系统
- 结构清晰，便于扩展或应用于其他桌面项目

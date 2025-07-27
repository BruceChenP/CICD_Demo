## 概述
本專案展示了一套完整的 CI/CD 流程，針對 .NET 9 Web API 實作自動化建置與部署。整體流程包含：
- 從 GitHub 自動拉取專案原始碼
- 透過 Docker 將應用程式打包為映像檔
- 將映像檔推送至 AWS ECR
- 最終部署至 AWS EKS 上的 Kubernetes 環境

## Overview
This project showcases a complete CI/CD pipeline for a .NET 9 Web API. The workflow begins by pulling the source code from GitHub, followed by automated builds using Jenkins. The application is then containerized with Docker, the resulting image is pushed to AWS ECR, and finally deployed to a Kubernetes environment on AWS EKS.
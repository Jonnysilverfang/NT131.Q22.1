# Lab04 - Nhiệm vụ 2.3 - Quét với plugin được chỉ định trong Nessus

## 1. Thông tin nhóm

- Lớp: NT101.Q22.1
- Nhóm: 07
- Công cụ sử dụng: Nessus, tcpdump, nmap
- Máy quét: Ubuntu/server
- Máy mục tiêu: Metasploitable 2

## 2. Môi trường thực nghiệm

| Thiết bị | Vai trò | Địa chỉ IP |
|---|---|---|
| Ubuntu/server | Máy cài Nessus và thực hiện quét | `192.168.125.128/24` |
| Metasploitable 2 | Máy mục tiêu | `192.168.125.129/24` |

Trước khi thực hiện scan, nhóm kiểm tra kết nối giữa máy Ubuntu và máy Metasploitable 2 bằng `ping`, đồng thời kiểm tra port RPC 111 bằng `nmap`.

```bash
ping -c 4 192.168.125.129
nmap -p 111 192.168.125.129

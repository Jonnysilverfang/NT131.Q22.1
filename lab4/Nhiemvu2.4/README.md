
# Lab04 - Task 2.4 - Vulnerability Scanning with Trivy

## Thông tin nhóm
- Lớp: NT101.Q22.1
- Nhóm: 07

## Công cụ lựa chọn
- Trivy

## Môi trường thực nghiệm
- Máy thực hành: Ubuntu trên VMware Workstation
- Mạng lab: 192.168.125.0/24
- IP máy Ubuntu: 192.168.125.128/24

## Nội dung thực hiện
1. Cài đặt Trivy trên Ubuntu.
2. Quét container image nginx:1.18.
3. Lọc các lỗ hổng mức HIGH và CRITICAL.
4. Xuất kết quả quét ra file TXT và JSON.
5. Quét file system cục bộ bằng Trivy.

## Các lệnh chính

```bash
trivy --version
trivy image nginx:1.18
trivy image --severity HIGH,CRITICAL nginx:1.18
trivy image --severity HIGH,CRITICAL nginx:1.18 > results/trivy-nginx-high-critical.txt
trivy image --format json --output results/trivy-nginx-report.json nginx:1.18
trivy fs --scanners vuln --severity HIGH,CRITICAL ~/Lab04-Trivy

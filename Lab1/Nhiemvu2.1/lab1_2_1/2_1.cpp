#include <iostream>
#include <string>

using namespace std;

int main() {
    string encodedText;
    int k;

    cout << "--- CHUONG TRINH GIAI MA CAESAR ---" << endl;

    cout << "Nhap ban ma (da bi khoa): ";
    getline(cin, encodedText);

    cout << "Nhap do dich chuyen (key): ";
    cin >> k;

    k = k % 26;

    for (int i = 0; i < encodedText.length(); i++) {
        char c = encodedText[i];

        if (c >= 'A' && c <= 'Z') {

            encodedText[i] = (c - 'A' - k + 26) % 26 + 'A';
        }
        // Trường hợp là chữ thường (a-z)
        else if (c >= 'a' && c <= 'z') {
            encodedText[i] = (c - 'a' - k + 26) % 26 + 'a';
        }
 
    }

    cout << "----------------------------------" << endl;
    cout << "Ket qua giai ma: " << encodedText << endl;

    return 0;
}
#include <iostream>
using namespace std;

int main() {

    string name;
    int age;
    string gender;
    string medicalHistory;

    cout << "Enter patient's name: ";
    getline(cin, name);

    cout << "Enter patient's age: ";
    cin >> age;

    cout << "Enter patient's gender (Male/Female/Other): ";
    cin >> gender;

    cin.ignore();

    cout << "Enter patient's medical history: ";
    getline(cin, medicalHistory);

    cout << "\n----- Patient Details -----\n";
    cout << "Name: " << name << endl;
    cout << "Age: " << age << endl;
    cout << "Gender: " << gender << endl;
    cout << "Medical History: " << medicalHistory << endl;

    return 0;
}

#include <iostream>
#include <cstring>
using namespace std;

int main()
{
    char str[100];  
    cout << "Enter a string: ";
    cin >> str;

    int length = strlen(str);  

    cout << "String entered character-wise is:" << endl;
    for (int i = 0; i < length; i++)
    {
        cout << str[i] << endl;
    }
    cout << "String entered in reverse order is:" << endl;
    for (int i = length - 1; i >= 0; i--)
    {
        cout << str[i] << endl;
    }
    return 0;
}

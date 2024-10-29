#include<iostream>
using namespace std;
void multiply(int n1,int n2);
int main()
{
	int n1,n2;
	cout<<"Enter 2 num :";
	cin>>n1>>n2;
	multiply(n1,n2);
}
void multiply(int n1,int n2)
{
	int result=n1*n2;
	cout<<"Result="<<result<<endl;
}
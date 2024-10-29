#include<iostream>
using namespace std;
void number(int num);
int main()
{
	int num;
	cout<<"Enter num:";
	cin>>num;
	number(num);
}
void number(int num)
{
	if(num%2==0)
	{
		cout<<"It is even num"<<endl;
	}
	else
	{
		cout<<"It is odd num";
	}
}
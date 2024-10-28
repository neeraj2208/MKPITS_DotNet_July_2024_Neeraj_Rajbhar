#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0;
	char op;
	cout<<"Enter 2 num :";
	cin>>n1>>n2;
	cout<<"Enter op (+,-,*,/)";
	cin>>op;
	while(n1>0 && n2>0)
	{
	
	if(op=='+')
	{
		sum=n1+n2;
	}
	else if(op=='-')
	{
		sum=n1-n2;
	}
	else if(op=='*')
	{
		sum=n1*n2;
	}
	else if(op=='/')
	{
		sum=n1/n2;
	}
	cout<<"sum is ="<<sum;
	return 0;
	}
}
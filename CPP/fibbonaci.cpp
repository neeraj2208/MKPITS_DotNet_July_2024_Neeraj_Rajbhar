#include<iostream>
using namespace std;
int main()
{
	int n, n1=0, n2=1, add, int i;
	cout<<"Enter num:"<<endl;
	cin>>n;
	for(i=0;i<=n;i++)
	{
		cout<<add<<endl;
		add=n1+n2;
		n1=n2;
		n2=add;
		
	}
	return 0;
}
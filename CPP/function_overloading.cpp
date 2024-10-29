#include<iostream>
using  namespace std;
class adittion
{
	int add(int n1,int n2)
	{
		return n1+n2;
	}
	int  add(int n1,int n2,int n3)
	{
		return n1+n2+n3;
	}
};
int main()
{
	adittion a;
	int n1,n2,n3;
	cout<<"Addition of 2 num="<<a.add(n1,n2)<<endl;
	cout<<"Adittion of 3 num="<<a.add(n1,n2,n3)<<endl;
	return 0;
}
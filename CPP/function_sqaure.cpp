#include<iostream>
using namespace std;
void square(int num);
int main()
{
	int num;
	cout<<"Enter num:";
	cin>>num;
	square(num);
}
void square(int num)
{
	int res=num*num;
	cout<<"Square is ="<<res<<endl;
}
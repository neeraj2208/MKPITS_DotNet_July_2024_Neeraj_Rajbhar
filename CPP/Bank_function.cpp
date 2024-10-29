#include<iostream>
using namespace std;
void deposit(int amt,int bal);
void withdrawl(int amt,int bal);
int main()
{
	int bal=1000;
	int amt;
	cout<<"Enter amount=";
	cin>>amt;
	deposit(amt,bal);
	withdrawl(amt,bal);
	
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
	cout<<"Balance deposit="<<bal<<endl;
}
void withdrawl(int amt,int bal)
{
	bal=bal-amt;
	cout<<"Balance withdraw="<<bal<<endl;
}
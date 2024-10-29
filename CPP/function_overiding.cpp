#include<iostream>
using namespace std;
class Account
{
	public:
		int acno;
		int bal;
		void deposit(int amt)
		{
			cout<<"Hello account";
		}
};
class Saving:public  Account
{
	public:
		void deposit(int amt)
		{
			int intrest=500;
			bal=bal+intrest+amt;
			cout<<"Balance with intrest ="<<bal<<endl;
		}
};
class Current:public Account
{
	public:
		void deposit(int amt)
		{
			bal=bal+amt;
			cout<<"Balance is ="<<bal<<endl;
		}
};
int main()
{
	Saving s;
	s.acno=123;
	s.bal=1000;
	s.deposit(500);
	
	Current c;
	c.acno=456;
	c.bal=1000;
	c.deposit(500);
	return 0;
}
	
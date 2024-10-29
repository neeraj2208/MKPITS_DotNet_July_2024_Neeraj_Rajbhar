#include<iostream>
using namespace std;
int main()
{
	string name;
	int total,id,unit;
	cout<<"Enter name:";
	cin>>name;
	cout<<"Enter Id";
	cin>>id;
	cout<<"Enter unit:";
	cin>>unit;
	
	if(unit<100)
	{
		total=unit*1;
	}
	else if(unit>200 && unit<400)
	{
		total=unit*2;
	}
	else
	{
		total=unit*3;
	}
	cout<<"Name is "<<name<<endl;
        cout<<"Id is "<<id<<endl;
	cout<<"Unit is "<<unit<<endl;
	cout<<"Total is "<<total<<endl;	
}
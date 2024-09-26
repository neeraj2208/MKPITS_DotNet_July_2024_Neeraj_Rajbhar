#include<iostream>
using namespace std;
int main()
{
	int x,y;
	cout<<"Enter x and y";
	cin>>x>>y;
	
	if(x>0 && y>0)
	{
		cout<<"Co ordinates point are lies in First Quadrant";
	}
	else if(x<0 && y>0)
	{
		cout<<"Co ordinates point are lies in Second Quadrant";
	}
	else if(x<0 && y<0)
	{
		cout<<"Co ordinates point are lies in Third Quadrant";
	}
	else if(x>0 && y<0)
	{
		cout<<"Co ordinates point are lies in Fourth Quadrant";
	}
	
	
}
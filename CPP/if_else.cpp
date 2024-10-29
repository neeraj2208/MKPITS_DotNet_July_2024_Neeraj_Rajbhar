#include<iostream>
using namespace std;

int main()
{
  int choice,n1,n2,total;
  cout<<"1.Add\n2.Sub\n3.Mul\n4.Div\n";
  cin>>choice;
  if(choice==1)
  {
  	cout<<"Enter num1 and num2\n";
  	cin>>n1>>n2;
  	total=n1+n2;
  	cout<<"Total is "<<total;
  }
  else if(choice==2)
  {
  	cout<<"Enter num1 and num2\n";
  	cin>>n1>>n2;
  	total=n1-n2;
  	cout<<"Total is "<<total;
  }
  else if(choice==3)
  {
  	cout<<"Enter num1 and num2\n";
  	cin>>n1>>n2;
  	total=n1*n2;
  	cout<<"Total is "<<total;
  }
  else if(choice==4)
  {
  	cout<<"Enter num1 and num2\n";
  	cin>>n1>>n2;
  	total=n1/n2;
  	cout<<"Total is "<<total;
  }
  		
}
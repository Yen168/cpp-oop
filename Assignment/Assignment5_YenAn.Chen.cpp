#include <iostream>

using namespace std;

void greetUser(void);
void getInput(double&,double&,double&); 
double computeInflation(double,double);

int main(){

	/*
		Assignment #5 - Inflation Calculator
		Yen-An Chen

		Compute inflation rates for two successive years and determines whether the inflation is increasing or decreasing.

		Input:
		C: current price
		P: price from previous year
		T: price from two years ago

		Output:
		inf1 = current year's inflation
	    inf2 = last year's inflation

	*/

	double C = 0, P = 0, T = 0;
	double inf1 = 0, inf2 = 0;
	
	greetUser();
	getInput(C,P,T);

	inf1 = computeInflation(C,P);
	inf2 = computeInflation(P,T);

	cout << "The current year's inflation: " << inf1 * 100 << "%" << endl;
	cout << "The last year's inflation: " << inf2 * 100 << "%" << endl << endl;

	// rise, decline or unchanged
	if (inf1 > inf2)
		cout << "The inflation is on the rise!" << endl;
	else if (inf1 < inf2)
		cout << "The inflation is on decline!" << endl;
	else
		cout << "No change in inflation!" << endl;

	system("PAUSE");
	return 0;
}

void greetUser(void){
	
	cout << "Welcome to inflation calculator!" << endl << endl; 
}

void getInput(double& c,double& p,double& t){

	cout << "Please enter the current price of an item? ";
	cin >> c;

	cout << "For the same item, please enter the price from previous year? ";
	cin >> p;

	cout << "For the same item, please enter the price from two years ago? ";
	cin >> t;
}

double computeInflation(double currentPrice,double previousPrice){

	return (currentPrice - previousPrice) / previousPrice;
}


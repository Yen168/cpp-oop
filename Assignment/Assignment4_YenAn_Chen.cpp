#include <iostream>

using namespace std;

int main(){

	/*
	Assignment #4 - YAA Award 
	Yen-An Chen

	Purpose: take the number of months from user and create a loop to compute the payments for each month and output on screen

	Input:
	months: from user

	Output:
	awards: initial value = one dollar

	*/

	double awards = 1;
	int months = 0;

	cout << "**************************************************************************\n"
		 << "                              Congratulations!!\n"
		 << "If you are using this program, that means you won the You-Are-Awesome award!\n"
		 << "**************************************************************************\n\n";

	cout << "I am sure you are dying to know how much you won, let's compute!\n" << endl;
	cout << "For how many months did they say you will receive payments? ";
	cin >> months;
	cout << "\nHere are the monthly installment amounts:\n" << endl;
	
	// computing by rule A and rule B
	for(int i = 0;i < months;i++){

		cout << "Month " << i+1 << ":\t" << "$" << awards << endl;

		if (i%2 == 1)
			awards *= 3; //Rule B - Triple the installment amount.
		else
			awards *= 2; //Rule A - Double the installment amount.

	}

	system("PAUSE");
	return 0;
}
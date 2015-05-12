#include <iostream>
#include<cstdlib>

using namespace std;

int main(){

	/*
	Assignment2 Yen-An Chen

	Purpose: compute average grade of a student

	Input:
	grade[]: grade scores

	Ourput:
	sum: sum of the grades
	average: average of the grades

	*/

	// number of grades
	int num = 4;
	// input
	double grade[num];
	//output
	double sum = 0;
	double average = 0;

	//processing
	for(int i=0; i<num; i++){

		cout << "Please Enter Grade " << i+1 << " : ";
		cin >> grade[i];

		sum += grade[i];

	}

	average = sum / num;

	// output
	cout << endl << "The sum of the grades: " << sum << endl << "The average of the grades: " << average << endl;

	system("PAUSE");
	return 0;



}

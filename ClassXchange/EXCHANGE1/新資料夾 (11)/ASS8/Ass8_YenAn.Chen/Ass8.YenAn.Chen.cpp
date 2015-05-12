#include <iostream>
#include <string>
#include <fstream>

using namespace std;

int main(){

	/*

	Assignment #8: Yen-An Chen
	(LIPA)
	*/

	int choice = -1; // user's choice ,-1 initial value
	//City Data[10000]; // 20 tables

	//Load(Data);

	cout << "LIPA" << endl
		<< "Writen by Yen-An Chen" << endl << endl;


	while(choice != 0){

		cout << "\n1. Query City" << endl
			<< "2. City With Most Outage" << endl
			<< "0. Exit Program" << endl;

		cout << "Make Your Choice now: ";
		cin >> choice;

		if (choice == 1)
		//	QueryCity(Data);
		cout << "\n1. Query City" << endl;
		else if (choice == 2)
		//	CityWithMostOutage(Data);
		cout << "\n1. Query City" << endl;
		else if (choice == 0){

			cout << "See you next time!!!" << endl;

			break;
		}


	}


	system("PAUSE");
	return 0;


}
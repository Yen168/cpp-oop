#include <iostream>
#include <string>
#include <fstream>

using namespace std;

class City{// class for City

public:

	string Name;
	double NumOfOutages;
	double TotalCust;

};

//void Save(Data[]);
void Load(City[]);

int main(){

	/*

	Assignment #8: Yen-An Chen
	(LIPA)
	*/

	int choice = -1; // user's choice ,-1 initial value
	City Data[10000]; // 20 tables

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

/*
void Save(City table[])
{
	ofstream fileIn;
	fileIn.open("LabExercise5_YenAn.Chen.txt");

	for(int i=0; i < 20; i++){
		fileIn << table[i].IsReserved <<  " ";
		fileIn << table[i].ReserveName <<  " ";
	}
	
	fileIn.close();
}
*/
void Load(City data[])
{
	ifstream fileOut;
	fileOut.open("data.txt");

	while (true){
		fileOut >> data[i].Name;
		fileOut >> data[i].NumOfOutages;
		fileOut >> data[i].TotalCust;
		
		if( fileOut.eof() ) 
			break;
	}
	
	fileOut.close();
}
#include <iostream>
#include <string>
#include <algorithm>
#include <ctype.h>
#include <fstream>

using namespace std;

class City{// class for City

public:

	string Name;
	double NumOfOutages;
	double TotalCust;

};

void QueryCity(City[],int);
void CityWithMostOutage(City[],int);

int Load(City[]);

int main(){

	/*
	Assignment #8: Yen-An Chen
	(LIPA)
	*/

	int choice = -1; // user's choice ,-1 initial value
	int count = 0;// num of city

	City Data[1000]; 

	count = Load(Data);

	cout << "LIPA" << endl
		<< "Writen by Yen-An Chen" << endl << endl;


	while(choice != 0){

		cout << "\n1. Query City" << endl
			<< "2. City With Most Outage" << endl
			<< "0. Exit Program" << endl;

		cout << "Make Your Choice now: ";
		cin >> choice;

		if (choice == 1)
			QueryCity(Data,count);
		else if (choice == 2)
			CityWithMostOutage(Data,count);
		else if (choice == 0){

			cout << "See you next time!!!" << endl;

			break;
		}


	}


	system("PAUSE");
	return 0;


}

int Load(City data[])
{
	ifstream fileOut;
	fileOut.open("data.txt");

	int i = 0;

	while (!fileOut.eof()){

		fileOut >> data[i].Name;
		fileOut >> data[i].NumOfOutages;
		fileOut >> data[i].TotalCust;
		i++;

		if( fileOut.eof() ) 
			break;
	}

	fileOut.close();
	return i; // num of city
}

void QueryCity(City data[],int count){

	string CityName;
	int found = 0;// city found != 0;
	cout << "\nEnter the name of City: ";
	cin >> CityName;

	// upper cast the whole string
	transform(CityName.begin(), CityName.end(), CityName.begin(),toupper);

	for(int i = 0; i < count;i++){

		if (data[i].Name == CityName){

			cout << endl <<data[i].Name << endl;
			cout << "------------------------"<< endl;
			cout << "Nmber of customers without power: " << data[i].NumOfOutages << endl;
			cout << "Total number of customers in that city: " << data[i].TotalCust << endl<< endl;

			found++;

		}

	}

	if(found == 0)
		cout << endl <<"Can not find the City!!!" << endl<< endl;

}

void CityWithMostOutage(City data[],int count){

	double temp = 0;// inital value
	double percentage = 0;
	int city = -1; // city index

	for(int i = 0; i < count;i++){
		
		if(data[i].NumOfOutages == 0 && data[i].TotalCust == 0)
			percentage = 0;
		else
			percentage = data[i].NumOfOutages/data[i].TotalCust;

		if(temp < percentage*100){
			temp = percentage*100;
			city = i;
		}

		cout << "NO:"<< i << ": " << percentage*100 <<endl;
	}

	cout << endl <<data[city].Name << endl;
	cout << "------------------------"<< endl;
	cout << "Percentage of customers without power: " << temp << "%" << endl;
	cout << "The city with the most percentage of customers without power!!!"  << endl<< endl;


}
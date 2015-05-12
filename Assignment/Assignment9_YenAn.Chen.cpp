#include <iostream>
#include <string>
#include <fstream>

using namespace std;

class Jobs{// class for Jobs

public:

	string ActorName;
	string TVshow;
	double Paid;

};

int Load(Jobs[]);
void DisplayByJob(Jobs[],int);
void DisplayAll(Jobs[],int);
void DisplayHighestPay(Jobs[],int);


int main(){

	/*
	Bad Boys Casting Agency
	Yen-An Chen

	*/

	int count = 0; // Number of Ticket.  

	Jobs Data[1000]; // inital

	cout << "Bad Boys Casting Agency" << endl
		<< "Writen by Yen-An Chen" << endl << endl;

	count = Load(Data);

	int check = -1; // input check inital (-1) = no input

	while(check != 0){

		cout << "\n\n1) Display Talents By Job.\n"
			 << "2) Display the Highest Paying Job.\n"
			 << "3) Display All.\n"
			 << "0) Exit.\n"
			 << "Please Enter Your Choice (0 - 3): ";
		
		cin >> check;

		if(check == 1)
			DisplayByJob(Data,count);

		else if(check == 2)
			DisplayHighestPay(Data,count);

		else if (check == 3)
			DisplayAll(Data,count);

		else if (check == 0)
			break;

	}


	cout << "See You Again!!!" << endl;

	system("pause");

	return 0;


}

int Load(Jobs data[])
{
	ifstream fileOut;
	fileOut.open("data.txt");

	int i = 0;

	while (!fileOut.eof()){ 

		fileOut >> data[i].ActorName >> data[i].TVshow >> data[i].Paid;	

		if( fileOut.eof() ) 
			break;

		i++;
	}

	fileOut.close();

	return i; // num of Jobs
}

void DisplayByJob(Jobs data[], int count)
{
	string jobname, MaxName, minName;
	double total = 0, MAX = -1, min = 0;
	int countJob = 0;

	cout << "\nPlease enter a job name: ";
	cin >> jobname;

	for(int i = 0 ; i <= count ; i++){

		if(data[i].TVshow == jobname){

			cout << data[i].ActorName << " Paid: " <<data[i].Paid << endl;

			if(MAX == -1){ // judge wether used or not

				MAX = data[i].Paid;
				min = data[i].Paid;
				MaxName = data[i].ActorName;
				minName = data[i].ActorName;

			}
			else{

				if(MAX < data[i].Paid){

					MAX = data[i].Paid;
					MaxName = data[i].ActorName;
				}

				if(min > data[i].Paid){

					min = data[i].Paid;
					minName = data[i].ActorName;

				}


			}

			countJob++;
			total += data[i].Paid;

		}

	}

	cout << "\nThe total amount paid to all talents in the job: $" << total << endl;
	cout << "The highest paid: $" << MAX << " to " << MaxName << endl;
	cout << "The lowest paid: $" << min << " to " << minName << endl;
	cout << "The average paid: $" << total/countJob << endl;

}

void DisplayAll(Jobs data[],int count){

	if(count < 100){

		for(int i = 0; i <= count ;i++){

			cout << "Talent: " << data[i].ActorName <<" Job: " << data[i].TVshow << " Paid: " << data[i].Paid << endl;

		}
	}
	else{

		cout << "\nOnly First 100 records will be showed below: \n"<< endl;

		for(int i = 0; i <= 99 ;i++){

			cout << "Talent: " << data[i].ActorName <<" Job: " << data[i].TVshow << " Paid: " << data[i].Paid << endl;

		}

	}

}

void DisplayHighestPay(Jobs data[],int count){

	string temp = data[0].TVshow, highestPay;
	double total = 0;
	double MAXpay = -1;


	for(int i = 0 ; i <= count ;i++){

		if(temp == data[i].TVshow){

			total += data[i].Paid;

		}else{

			temp = data[i].TVshow;

			if(MAXpay < total){
				MAXpay = total;
				highestPay = data[i-1].TVshow; // last job name
			}
			total = 0;// set 0 to anther job's begining balance
			total += data[i].Paid;
		}

	}

	// check last total value whether MAXpay or not

	if(MAXpay < total){
		highestPay = data[count].TVshow; // final records
		MAXpay = total;
	}
	cout << "\n\nThe Highest Paying Job is "<< highestPay << ". Total $" << MAXpay << endl;

}
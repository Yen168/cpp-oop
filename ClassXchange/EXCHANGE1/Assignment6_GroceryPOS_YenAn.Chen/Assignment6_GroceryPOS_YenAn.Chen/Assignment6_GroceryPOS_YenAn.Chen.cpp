#include <iostream>
#include <string>

using namespace std;

class Product{// class for product

public:
	
	string Name;
	double Quantity;
	double SalePrice;

	void MakeSale(double SoldQuantity){
	
		if(SoldQuantity <= Quantity)
			Quantity -= SoldQuantity;
		else
			cout << "Not enough inventory for sale!!!" <<endl;
		
	}

};

void newProduct(Product[],int&);
void changeInventory(Product[],int);
void makeSale(Product[],int);
void report(Product[],int);
int search(string,Product[],int);

int main(){

	/*
	Assignment #6 - GROCERY POINT OF SALE SYSTEM(Rewrite by using class) - by Yen-An Chen

	*/

	int choice = -1; // user's choice ,-1 initial value
	int productCount = 0; // quantity of product upto now
	Product list[100];// Product object 

	cout << "GROCERY POINT OF SALE SYSTEM" << endl
		<< "Writen by Yen-An Chen" << endl << endl;


	while(choice != 0){

		cout << "\n1. Enter a Product" << endl
			<< "2. Change Inventory" << endl
			<< "3. Make Sale" << endl
			<< "4. Inventory Report" << endl
			<< "0. Exit" << endl;

		cout << "Make Your Choice now: ";
		cin >> choice;

		if (choice == 1)
			newProduct(list, productCount);
		else if (choice == 2)
			changeInventory(list, productCount);
		else if (choice == 3)
			makeSale(list, productCount);
		else if (choice == 4)
			report(list, productCount);
		else if (choice == 0){
			cout << "See you next time!!!" << endl;
			break;
		}


	}



	system("PAUSE");
	return 0;

}

int search(string newname,Product list[],int productCount){

	for(int i = 0; i < productCount ;i++){

		if (list[i].Name == newname)
			return i; // item index
	}

	return -1; // can not find the item
}

void newProduct(Product list[], int &productCount){

	string newname;
	cout << "\nPlease enter a new product name: ";
	cin >> newname;

	if(search(newname,list,productCount) == -1){

		list[productCount].Name = newname;
		cout << "Please enter the quantity of new product: ";
		cin >> list[productCount].Quantity;
		cout << "Please enter the price of new product: ";
		cin >> list[productCount].SalePrice;

		productCount++;

	}
	else
		cout << "The product already exited" << endl;
}

void changeInventory(Product list[],int productCount){



	cout << "\nPlease enter the name of product which you want to change its quantity: ";
	string pname;
	cin >> pname;

	int index = search(pname,list,productCount);

	if(index != -1){ // -1: not found

		cout << "Please enter the quantity of you want to change: ";
		cin >> list[index].Quantity;

	}
	else
		cout << "The item does not exist!" <<endl;

}

void report(Product list[], int productCount){

	double total_v = 0;

	cout << "\n\n......................................"  
		<< "\nInventory Report: " << endl;

	for (int i = 0 ;i< productCount; i++){

		cout << "Item "<< i+1 << " " << list[i].Name 
			<< " ,Quantity: " << list[i].Quantity
		<< " ,Sale Price: " << list[i].SalePrice 
		<< " ,Worth of this item: " << list[i].Quantity*list[i].SalePrice<< endl;

		total_v += list[i].Quantity*list[i].SalePrice; // total inventory
	}

	cout << "The Total Value of the whole inventory: " << total_v << endl
		 << "......................................\n" << endl;

}

void makeSale(Product list[],int productCount){


	cout << "\nPlease enter the name of product which you made a sale: ";
	string pname;
	double sale = 0;
	cin >> pname;

	int index = search(pname,list,productCount);

	if(index != -1){ // -1: not found

		cout << "Please enter the quantity of you made a sale: ";
		cin >> sale;

		if(sale <= list[index].Quantity)
			list[index].MakeSale(sale);// call object function
		else
			cout << "Not enough inventory for sale!!!" <<endl;

	}
	else
		cout << "The item does not exist!" <<endl;
}
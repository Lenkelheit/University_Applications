#include <iostream>
using namespace std;

void main()
{
	//моя задача
	//21. Скільки одиниць товару вартістю k грн можна придбати на суму n
	//грн ? Скільки грошей залишиться ?
	int amount_of_money, price_one_good, amount_of_goods, amount_remain_money;
	cout << "Input amount of money: ";
	cin >> amount_of_money;
	cout << "Input price of one good: ";
	cin >> price_one_good;
	__asm
	{
		mov ecx, price_one_good
		mov eax, amount_of_money
		cdq//розширюю значення регістра, аби мати можливість зберегання остачі від ділення

		div ecx//ділю eax на ecx, тобто amount_of_money/price_one_good

		mov amount_of_goods, eax
		mov amount_remain_money, edx
	}
	cout << "Amount of goods: " << amount_of_goods << endl;
	cout << "Amount of remain money: " << amount_remain_money << endl;


	// *************
	// OTHER PROGRAM
	// *************

	int year, leap;
	cout << endl << "Input year: ";
	cin >> year;
	__asm
	{
		mov ebx, 0
		mov ecx, 400
		mov eax, year
		cdq//розширюю значення регістра, аби мати можливість зберегання остачі від ділення

		div ecx//ділю eax на ecx, тобто year/400
		test edx, edx//якщо остача від ділення = 0, тобто результат логічного множення = 0, то ZF = 1

		jz is_leap//виконається, якщо ZF = 1
		mov eax, year
		cdq//розширюю значення регістра, аби мати можливість зберегання остачі від ділення
		mov ecx, 4
		div ecx//ділю eax на ecx, тобто year/4
		test edx, edx//якщо остача від ділення = 0, тобто результат логічного множення = 0, то ZF = 1
		jz maybe_leap//виконається, якщо ZF = 1
		jmp result
		is_leap :
		mov ebx, 1
			jmp result
			maybe_leap :
		mov eax, year
			cdq//розширюю значення регістра, аби мати можливість зберегання остачі від ділення
			mov ecx, 100
			div ecx
			test edx, edx//якщо остача від ділення = 0, то ZF = 1
			jz result//виконається, якщо ZF = 1
			jmp is_leap//сюди перейду, якщо ZF = 0
			result :
		mov leap, ebx
	}
	if (leap > 0)
	{
		cout << "Yes" << endl;
	}
	else
	{
		cout << "No" << endl;
	}
	system("pause");
}
#include <iostream>
using namespace std;

//для Hello world
char FORMAT_1[] = "%s %s\n";
char HELLO[] = "Hello";
char WORLD[] = "world";

//Design by Nazariy Tymtsiv, 2017; тут year - масив char`ів
char FORMAT_2[] = "%s %s %s %s\n";
char Design[] = "Design";
char by[] = "by";
char Nazariy[] = "Nazariy Tymtsiv,";
char year[] = "2017";

//Design by Nazariy Tymtsiv, 2017; тут year_int - int
int year_int = 2017;
char FORMAT_4[] = "%s %s %s %d\n";//%d - специфікатор ціле десяткове зі знаком

void main()
{
	__asm
	{	// початок асемблерного коду
		//Hello world
		mov eax, offset WORLD//присвоюю регістру eax значення змінної WORLD за адресою
		push eax//заношу значення в стек
		mov eax, offset HELLO
		push eax
		mov eax, offset FORMAT_1
		push eax
		mov edi, printf
		call edi //через edi викликаю функцію printf

		// Очищую стек для коректного завершення процедури main
		pop ebx
		pop ebx
		pop ebx

		//Design by Nazariy Tymtsiv, 2017; тут year - масив char`ів
		mov eax, offset year//присвоюю регістру eax значення змінної year за адресою
		push eax//заношу значення в стек
		mov eax, offset Nazariy
		push eax
		mov eax, offset by
		push eax
		mov eax, offset Design
		push eax
		mov eax, offset FORMAT_2
		push eax

		call printf//викликаю функцію printf

		// Очищую стек для коректного завершення процедури main
		pop ebx
		pop ebx
		pop ebx
		pop ebx
		pop ebx

		//Design by Nazariy Tymtsiv, 2017; тут year_int - int
		mov eax, year_int//присвоюю регістру eax значення змінної year_int
		push eax//заношу значення в стек
		mov eax, offset Nazariy//присвоюю регістру eax значення змінної WORLD за адресою
		push eax
		mov eax, offset by
		push eax
		mov eax, offset Design
		push eax
		mov eax, offset FORMAT_4
		push eax

		call printf//викликаю функцію printf

		// Очищую стек для коректного завершення процедури main
		pop ebx
		pop ebx
		pop ebx
		pop ebx
		pop ebx

	} // кінець асемблерного коду
	system("pause");
}

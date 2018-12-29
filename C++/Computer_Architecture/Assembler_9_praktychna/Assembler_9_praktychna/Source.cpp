#include <iostream>
using namespace std;

int a, y_1, y_2, x;// x = 0, 1, 2, 3, 4
int values[5]; // масив для збереження у(х)
void main()
{
	a = 5;
	__asm
	{
		mov eax, offset values
		push eax // заштовхую у стек адресу початку масиву
		mov cx, 5 // кількість проходів циклу
				  // початок циклу
				  start:
		mov ax, 5 // для обчислення x = 5 - сх
			sub ax, cx // отримую поточне значення х
			cwde // розширюю ax до eax
			mov ebx, eax // записую x в ebx
			mov eax, a // стала а
			cmp ebx, 0 // порівнюю х з нулем
			je equals_null // якщо х дорівнює 0, переходжу до equals_null
		// якщо х не дорівнює 0, переходжу до мітки not_equals_null

		cdq // розширюю a до четвірного слова
			idiv ebx // a/x
			mov x, ebx
			mov ebx, 1
			cdq
			div ebx// |a/x|
			mov y_2, eax
			mov eax, x
			mov ebx, 3
			cdq // розширюю x до четвірного слова
			idiv ebx // ділю x на 3
			cmp edx, 1 // порівнюю остачу від ділення x на 3 з одиницею
			jne not_equals_one // якщо остача не дорівнює 1, переходжу до мітки not_equals_one
			je equals_one// якщо остача дорівнює 1
			equals_one :
		mov eax, y_2
			add eax, ebx
			jmp result // переходжу до мітки result
			result :
		pop ebx // виштовхую зі стеку адресу масиву
			mov[ebx], eax // записую результат за поточною адресою
			add ebx, 4 // зсуваю вказівник масиву
			push ebx // заштовхую в стек нову адресу
			loop start // кінець циклу
			jmp exit_
			equals_null :
		mov y_2, 4
			mov eax, x
			mov ebx, 3
			cdq // розширюю x до четвірного слова
			idiv ebx // ділю x на 3
			cmp edx, 1 // порівнюю остачу від ділення x на 3 з одиницею
			jne not_equals_one // якщо остача не дорівнює 1, переходжу до мітки not_equals_one
							   // якщо остача дорівнює 1
			je equals_one// якщо остача дорівнює 1
			not_equals_one :
		mov eax, x
			mov ebx, a // стала a
			sub eax, ebx // x-a
			add eax, y_2
			jmp result // переходжу до мітки result
			
			exit_ :
			pop ebx// очищую стек від масиву values[5]
	}

	for (int i = 0; i < 5; i++)
	{
		cout << values[i] << endl;
	}

	system("pause");
}
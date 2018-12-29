#include <iostream>
using namespace std;

void arr_int_to_binary(__int32* arr, int size)
{
	for (int i = 0;i < size;++i)
	{
		for (int j = 0; j <24; ++j)
		{
			if (!(j % 8))
			{
				cout << " ";
			}
			cout << ((arr[i] >> (23 - j)) & 1);
		}
		cout << endl;
	}
}

void main()
{
	//Задано масив з 6 байт.Порахувати кількість байт, число одиниць в яких не перевищує 3.
	static __int32 arr[2] =
	{
		7'162'641,//01101101 01001011 00010001
		8'210'754//01111101 01001001 01000010
	};
	static __int32 res = 0;
	static __int32 i = 1;
	__asm {
		mov eax, offset arr//arr[]
		push eax
		mov cx, 6 // кількість проходів циклу
		start_outer: // початок зовнішнього циклу (по байтах)
		mov bx, 8 // кількість проходів внутрішнього циклу
			xor di, di // обнулення лічильника одиниць
			start_inner : // початок внутрішного циклу (по бітах)
		pop edx//зі стеку беремо адресу arr[]
			mov eax, edx//зберігаємо адресу arr[]
			mov edx, [edx]//отримуємо значення arr[]
			push eax//закидуємо назад у стек
			and edx, i // накладання маски
			jz go_next // якщо результат логічного множення — 0
			inc di // якщо результат логічного множення — 1, збільшуємо лічильник
			go_next :
		shl i, 1 // побітовий зсув вліво на 1 біт
			dec bx // зменшуємо лічильник проходів на 1
			test bx, bx // перевіряємо умову завершення циклу
			jnz start_inner// повторюємо цикл, якщо результат не 0
			cmp cx, 4
			jne skip_equals//якщо не дорівнює
			pop eax
			add eax, 4
			push eax//закидуємо назад у стек
			mov i, 1
			skip_equals :
		cmp di, 3//порівняння чи не перевищує 3
			jg end_ // якщо перевищує 3
			inc res // якщо не перевищує 3, збільшуємо лічильник
			end_ :
		loop start_outer // закінчення зовнішнього циклу
			pop eax
	}

	cout << "Array with 6 bytes:" << endl;
	arr_int_to_binary(arr, 2);
	cout << "Number bytes, in which amount of 1 doesn't exceed 3: " << res << endl;
	system("pause");
}

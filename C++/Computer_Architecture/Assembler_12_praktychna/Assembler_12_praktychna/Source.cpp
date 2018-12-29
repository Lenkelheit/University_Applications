#include <iostream>
#include <cmath>
using namespace std;

const int n = 5; // кількість значень змінної a
float twelve = 12;
float eleven = 11;
float one = 1;
float c;
float a[n]; // значення змінної
float res[n]; // значення виразу

void calculateASM()
{
	__asm
	{ // заповнення регістрів
		lea esi, a // адреса початку масиву a
		lea edi, res // адреса початку масиву res
		mov ecx, n // розмір масиву
		finit // ініціалізація співпроцесора
		iteration : // початок циклу
		fld twelve // значення 12 в стек співпроцесора
			fld c// значення c в стек співпроцесора

			fpatan// Обчислення часткового арктангенса : z = arctg(12 / c)
			fadd eleven//arctg(12 / c)+11
			fld[esi] // значення a в стек співпроцесора
			fmul[esi]//множення a*a
			fsub one//віднімання а*а-1
			fdiv // (arctg(12 / c)+11)/(a*a-1)
			fstp[edi] // запис значення виразу в масив res
					  // перехід до наступних елементів масивів
			add esi, 4
			add edi, 4
			loop iteration // кінець циклу
	}
}

void enteringData()
{
	cout << " Введiть c : ";
	cin >> c;
	cout << " Введiть a[i] :" << endl;
	for (int i = 0; i < n; ++i)
	{
		cout << " a[" << i << "] = ";
		cin >> a[i];
	}
}

void printRes(char* sym)
{
	cout << " Обчислено в " << sym << endl;
	for (int i = 0; i < n; ++i)
	{
		cout << " result: [" << i << "] = " << res[i] << endl;
	}
}

void calculateCpp()
{
	for (int i = 0; i < n; ++i)
	{
		res[i] = (atan(12 / c) + 11) / (a[i] * a[i] - 1);
	}
}

void main()
{
	setlocale(LC_ALL, "ukr");
	enteringData();
	calculateASM();
	printRes("ASM");
	calculateCpp();
	printRes("C++");
	system("pause");
}

/*

#include <iostream>
#include <cmath>
using namespace std;
const int n = 3; // кількість значень змінної х
const float neg4 = -4;
float d;
float x[n]; // значення змінної
float res[n]; // значення виразу
void calculateASM()
{
__asm
{ // заповнення регістрів
lea esi, x // адреса початку масиву х
lea edi, res // адреса початку масиву res
mov ecx, n // розмір масиву
finit // ініціалізація співпроцесора
iteration : // початок циклу
fld[esi] // значення х в стек співпроцесора
fadd d // x + d
fsincos // sin(x+d) i cos(x+d) в стек
fmul // sin(x+d)*cos(x+d)

fld neg4 // -4 в стек
fdiv // sin(x+d)cos(x+d)/(-4)
fstp[edi] // запис значення виразу в масив
// перехід до наступних елементів масивів
add esi, 4
add edi, 4
loop iteration // кінець циклу

}
}
void enteringData()
{
cout << " Введiть d : ";
cin >> d;
cout << " Введiть x[i] :" << endl;
for (int i = 0; i < n; ++i)
{
cout << " x[" << i << "] = ";
cin >> x[i];
}
}
void printRes(char* sym)
{
cout << " Обчислено в " << sym << endl;
for (int i = 0; i < n; ++i)
{
cout << " result: [" << i + 1 << "] = " << res[i] << endl;
}
}
void calculateCpp()
{
for (int i = 0; i < n; i++)
{
res[i] = -0.125 * sin(2 * (d + x[i]));
}
}
void main()
{
setlocale(LC_ALL, "ukr");
enteringData();
calculateASM();
printRes("ASM");
calculateCpp();
printRes("C++");
system("pause");
}

*/

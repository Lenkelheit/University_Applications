#include <iostream>
#include <cmath>
using namespace std;

const int n = 5; // ������� ������� ����� a
float twelve = 12;
float eleven = 11;
float one = 1;
float c;
float a[n]; // �������� �����
float res[n]; // �������� ������

void calculateASM()
{
	__asm
	{ // ���������� �������
		lea esi, a // ������ ������� ������ a
		lea edi, res // ������ ������� ������ res
		mov ecx, n // ����� ������
		finit // ����������� ������������
		iteration : // ������� �����
		fld twelve // �������� 12 � ���� ������������
			fld c// �������� c � ���� ������������

			fpatan// ���������� ���������� ����������� : z = arctg(12 / c)
			fadd eleven//arctg(12 / c)+11
			fld[esi] // �������� a � ���� ������������
			fmul[esi]//�������� a*a
			fsub one//�������� �*�-1
			fdiv // (arctg(12 / c)+11)/(a*a-1)
			fstp[edi] // ����� �������� ������ � ����� res
					  // ������� �� ��������� �������� ������
			add esi, 4
			add edi, 4
			loop iteration // ����� �����
	}
}

void enteringData()
{
	cout << " ����i�� c : ";
	cin >> c;
	cout << " ����i�� a[i] :" << endl;
	for (int i = 0; i < n; ++i)
	{
		cout << " a[" << i << "] = ";
		cin >> a[i];
	}
}

void printRes(char* sym)
{
	cout << " ��������� � " << sym << endl;
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
const int n = 3; // ������� ������� ����� �
const float neg4 = -4;
float d;
float x[n]; // �������� �����
float res[n]; // �������� ������
void calculateASM()
{
__asm
{ // ���������� �������
lea esi, x // ������ ������� ������ �
lea edi, res // ������ ������� ������ res
mov ecx, n // ����� ������
finit // ����������� ������������
iteration : // ������� �����
fld[esi] // �������� � � ���� ������������
fadd d // x + d
fsincos // sin(x+d) i cos(x+d) � ����
fmul // sin(x+d)*cos(x+d)

fld neg4 // -4 � ����
fdiv // sin(x+d)cos(x+d)/(-4)
fstp[edi] // ����� �������� ������ � �����
// ������� �� ��������� �������� ������
add esi, 4
add edi, 4
loop iteration // ����� �����

}
}
void enteringData()
{
cout << " ����i�� d : ";
cin >> d;
cout << " ����i�� x[i] :" << endl;
for (int i = 0; i < n; ++i)
{
cout << " x[" << i << "] = ";
cin >> x[i];
}
}
void printRes(char* sym)
{
cout << " ��������� � " << sym << endl;
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
#include <iostream>
using namespace std;

//��� Hello world
char FORMAT_1[] = "%s %s\n";
char HELLO[] = "Hello";
char WORLD[] = "world";

//Design by Nazariy Tymtsiv, 2017; ��� year - ����� char`��
char FORMAT_2[] = "%s %s %s %s\n";
char Design[] = "Design";
char by[] = "by";
char Nazariy[] = "Nazariy Tymtsiv,";
char year[] = "2017";

//Design by Nazariy Tymtsiv, 2017; ��� year_int - int
int year_int = 2017;
char FORMAT_4[] = "%s %s %s %d\n";//%d - ������������ ���� ��������� � ������

void main()
{
	__asm
	{	// ������� ������������ ����
		//Hello world
		mov eax, offset WORLD//�������� ������� eax �������� ����� WORLD �� �������
		push eax//������ �������� � ����
		mov eax, offset HELLO
		push eax
		mov eax, offset FORMAT_1
		push eax
		mov edi, printf
		call edi //����� edi �������� ������� printf

		// ������ ���� ��� ���������� ���������� ��������� main
		pop ebx
		pop ebx
		pop ebx

		//Design by Nazariy Tymtsiv, 2017; ��� year - ����� char`��
		mov eax, offset year//�������� ������� eax �������� ����� year �� �������
		push eax//������ �������� � ����
		mov eax, offset Nazariy
		push eax
		mov eax, offset by
		push eax
		mov eax, offset Design
		push eax
		mov eax, offset FORMAT_2
		push eax

		call printf//�������� ������� printf

		// ������ ���� ��� ���������� ���������� ��������� main
		pop ebx
		pop ebx
		pop ebx
		pop ebx
		pop ebx

		//Design by Nazariy Tymtsiv, 2017; ��� year_int - int
		mov eax, year_int//�������� ������� eax �������� ����� year_int
		push eax//������ �������� � ����
		mov eax, offset Nazariy//�������� ������� eax �������� ����� WORLD �� �������
		push eax
		mov eax, offset by
		push eax
		mov eax, offset Design
		push eax
		mov eax, offset FORMAT_4
		push eax

		call printf//�������� ������� printf

		// ������ ���� ��� ���������� ���������� ��������� main
		pop ebx
		pop ebx
		pop ebx
		pop ebx
		pop ebx

	} // ����� ������������ ����
	system("pause");
}
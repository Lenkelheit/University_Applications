#include <iostream>
using namespace std;

int a, y_1, y_2, x;// x = 0, 1, 2, 3, 4
int values[5]; // ����� ��� ���������� �(�)
void main()
{
	a = 5;
	__asm
	{
		mov eax, offset values
		push eax // ��������� � ���� ������ ������� ������
		mov cx, 5 // ������� ������� �����
				  // ������� �����
				  start:
		mov ax, 5 // ��� ���������� x = 5 - ��
			sub ax, cx // ������� ������� �������� �
			cwde // �������� ax �� eax
			mov ebx, eax // ������� x � ebx
			mov eax, a // ����� �
			cmp ebx, 0 // ������� � � �����
			je equals_null // ���� � ������� 0, ��������� �� equals_null
		// ���� � �� ������� 0, ��������� �� ���� not_equals_null

		cdq // �������� a �� ��������� �����
			idiv ebx // a/x
			mov x, ebx
			mov ebx, 1
			cdq
			div ebx// |a/x|
			mov y_2, eax
			mov eax, x
			mov ebx, 3
			cdq // �������� x �� ��������� �����
			idiv ebx // ��� x �� 3
			cmp edx, 1 // ������� ������ �� ������ x �� 3 � ��������
			jne not_equals_one // ���� ������ �� ������� 1, ��������� �� ���� not_equals_one
			je equals_one// ���� ������ ������� 1
			equals_one :
		mov eax, y_2
			add eax, ebx
			jmp result // ��������� �� ���� result
			result :
		pop ebx // ��������� � ����� ������ ������
			mov[ebx], eax // ������� ��������� �� �������� �������
			add ebx, 4 // ������ �������� ������
			push ebx // ��������� � ���� ���� ������
			loop start // ����� �����
			jmp exit_
			equals_null :
		mov y_2, 4
			mov eax, x
			mov ebx, 3
			cdq // �������� x �� ��������� �����
			idiv ebx // ��� x �� 3
			cmp edx, 1 // ������� ������ �� ������ x �� 3 � ��������
			jne not_equals_one // ���� ������ �� ������� 1, ��������� �� ���� not_equals_one
							   // ���� ������ ������� 1
			je equals_one// ���� ������ ������� 1
			not_equals_one :
		mov eax, x
			mov ebx, a // ����� a
			sub eax, ebx // x-a
			add eax, y_2
			jmp result // ��������� �� ���� result
			
			exit_ :
			pop ebx// ������ ���� �� ������ values[5]
	}

	for (int i = 0; i < 5; i++)
	{
		cout << values[i] << endl;
	}

	system("pause");
}
#include <stdio.h>
#include <stdlib.h>

void queens(int x);
void print(void);

unsigned int n, num;
char** checkerboard;
int* column;
int* right;
int* left;

int main(void)
{
	int i, j;

	printf("�п�J n ���j�p: ");
	scanf("%d", &n);

	// �ʺA���t�O����
	column = (int *)malloc(sizeof(int) * n);
	right = (int *)malloc(sizeof(int) * (2 * n - 1));
	left = (int *)malloc(sizeof(int) * (2 * n - 1));
	checkerboard = (char **)malloc(sizeof(char*) * n);

	// �ܼƪ�l��
	num = 0;
	for (i = 0; i < n; i++)
	{
		column[i] = 1;

		checkerboard[i] = (char *)malloc(sizeof(char) * n);
		for (j = 0; j < n; j++)
		{
			checkerboard[i][j] = 'x';
		}
	}

	for (i = 0; i < 2 * n - 1; i++)
	{
		right[i] = left[i] = 1;
	}

	queens(0);

	printf("\n�`�@�� %d �رƪk\n\n", num);

	// ����O����Ŷ�
	for (i = 0; i < n; i++)
	{
		free(checkerboard[i]);
	}

	free(checkerboard);
	free(column);
	free(right);
	free(left);

	system("pause");
}

void queens(int x)
{
	if (x < n)
	{
		int i;
		for (i = 0; i < n; i++)
		{
			int j = i - x + n - 1;
			int k = i + x;

			if (column[i] && right[j] && left[k])
			{
				// �аO�ӦZ��m, �û��j��m�U�@��
				column[i] = right[j] = left[k] = 0;
				checkerboard[x][i] = 'Q';

				queens(x + 1);

				column[i] = right[j] = left[k] = 1;
				checkerboard[x][i] = 'x';
			}
		}
	}
	else
	{
		// ��X�ѽL
		print();
		num++;
	}
}

void print(void)
{
	int i, j;

	printf("\n");
	for (i = 0; i < n; i++)
	{
		for (j = 0; j < n; j++)
		{
			printf("%c", checkerboard[i][j]);
		}

		printf("\n");
	}
}
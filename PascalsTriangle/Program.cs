// Четем число от потребителя
int number = int.Parse(Console.ReadLine());

// Създаваме масива с number дължина
int[,] rows = new int[number, number];

// Винаги първия ред е единица
rows[0, 0] = 1;

for (int row = 1; row < rows.GetLength(0); row++)
{
	for (int column = 0; column < row + 1; column++)
	{
		if (IsOutOfBounds(row - 1, column - 1))
		{
			// Ако сме извън матрицата, събираме числото над текущото с нула.
			rows[row, column] = 0 + rows[row - 1, column];
        }
		else
		{
			// Иначе събираме горното число и това от ляво на горното,
			// за да получим резултата на новата клетка.
			rows[row, column] = rows[row - 1, column - 1] + rows[row - 1, column];
        }
	}
}

// Принтираме матрицата
for (int row = 0; row < rows.GetLength(0); row++)
{
	for (int column = 0; column < rows.GetLength(1); column++)
	{
		if (rows[row, column] != 0)
		{
            Console.Write($"{rows[row, column]} ");
        }
	}

	Console.WriteLine();
}

bool IsOutOfBounds(int row, int column)
{
	// Проверява дали сме извън масива
	if (row < 0 || column < 0)
	{
		return true;
	}

	return false;
}

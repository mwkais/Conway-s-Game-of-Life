using System;

namespace Session3Scratch3
{
	class Program
	{
		static void Main(string[] args)
		{
			int gridsize = 20;

			int[,] grid = new int[gridsize + 2, gridsize + 2];

			// Add a known shape
			Random randNum = new Random();
			for (int i = 0; i < 125; i++)
			{
				int x = randNum.Next(1, 20);
				int y = randNum.Next(1, 20);
				grid[x, y] = 1;
			}

			while (true)
			{
				int Alive = 0;
				// create a new temporary grid
				int[,] new_grid = new int[gridsize + 2, gridsize + 2];

				for (int i = 1; i < gridsize; i++)
				{
					for (int j = 1; j < gridsize; j++)
					{
						//new_grid[i, j] = grid[i, j];

						if (grid[i, j] == 0) //Evaluating Dead Cells
						{
							if (grid[i - 1, j] == 1)
							{
								Alive++;
							}
							if (grid[i, j - 1] == 1)
							{
								Alive++;
							}
							if (grid[i - 1, j - 1] == 1)
							{
								Alive++;
							}
							if (grid[i + 1, j] == 1)
							{
								Alive++;
							}
							if (grid[i, j + 1] == 1)
							{
								Alive++;
							}
							if (grid[i + 1, j + 1] == 1)
							{
								Alive++;
							}
							if (grid[i + 1, j - 1] == 1)
							{
								Alive++;
							}
							if (grid[i - 1, j + 1] == 1)
							{
								Alive++;
							}

							if (Alive == 3)
							{
								new_grid[i, j] = 1;
							}
							else
								new_grid[i, j] = 0;
							Alive = 0;
						}

						if (grid[i, j] == 1)
						{
							if (grid[i - 1, j] == 1)
							{
								Alive++;
							}
							if (grid[i, j - 1] == 1)
							{
								Alive++;
							}
							if (grid[i - 1, j - 1] == 1)
							{
								Alive++;
							}
							if (grid[i + 1, j] == 1)
							{
								Alive++;
							}
							if (grid[i, j + 1] == 1)
							{
								Alive++;
							}
							if (grid[i + 1, j + 1] == 1)
							{
								Alive++;
							}
							if (grid[i + 1, j - 1] == 1)
							{
								Alive++;
							}
							if (grid[i - 1, j + 1] == 1)
							{
								Alive++;
							}
							if (Alive == 2 || Alive == 3)
							{
								new_grid[i, j] = 1;
							}
							else
							{
								new_grid[i, j] = 0;
							}
							Alive = 0;
						}
					}
				}

				// copy temp grid over original grid
				grid = new_grid;
				// clear the screen
				Console.Clear();
				// print our grid
				for (int i = 1; i < gridsize; i++)
				{
					for (int j = 1; j < gridsize; j++)
					{
						if (grid[i, j] == 0)
						{
							Console.Write(" ");
						}
						if (grid[i, j] == 1)
						{
							Console.Write("_");
						}
					}
					Console.WriteLine();
				}

				System.Threading.Thread.Sleep(TimeSpan.FromSeconds(.075));
			}
		}
	}
}


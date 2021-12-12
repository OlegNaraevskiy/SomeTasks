/*===================================================================
 * Copyright (c) 2021 Oleg Naraevskiy                   Date: 12.2021
 * Version IDE: MS VS 2019
 * Designed by: Oleg Naraevskiy / noa.oleg96@gmail.com      [12.2021]
 *===================================================================*/

using System;

namespace SomeTasks
{
	public class BinaryGap
	{
		public int Find(int number)
		{
			if (number <= 0)
			{
				return 0;
			}

			int result = 0;

			string binNumber = Convert.ToString(number, 2);

			char[] numArray = binNumber.ToCharArray();

			int[] gapsCounter = new int[numArray.Length];
			int zeroCounter = 0;

			for (int i = 0; i < numArray.Length; i++)
			{
				if (numArray[i] == '1')
				{

				}
				else if (numArray[i] == '0')
				{
					zeroCounter++
				}
			}

			return result;
		}
	}
}

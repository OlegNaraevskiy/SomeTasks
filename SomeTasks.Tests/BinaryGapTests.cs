/*===================================================================
 * Copyright (c) 2021 Oleg Naraevskiy                   Date: 12.2021
 * Version IDE: MS VS 2019
 * Designed by: Oleg Naraevskiy / noa.oleg96@gmail.com      [12.2021]
 *===================================================================*/

using Xunit;
 
namespace SomeTasks.Tests
{
	public class BinaryGapTests
	{
		[Fact]
		public void IndexViewDataMessage()
		{
			// Arrange
			BinaryGap binaryGap = new BinaryGap();
			int number = 20;
			int resultNumber = 1;

			// Act
			int result = binaryGap.Find(number);

			// Assert
			Assert.Equal(resultNumber, result);
		}
	}
}

#region License
// MIT License
//
// Copyright (c) 2021 MissingExtensions
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

namespace MissingExtensions.Collections.Tests;

[TestFixture]
public class ForEachTests
{
	[Test]
	public void Should_Throw_NullReferenceException_When_Sequence_Is_Null()
	{
		// Arrange
		IEnumerable<object>? source = null;

		// Act & Assert
		Assert.Throws<NullReferenceException>(() => source.ForEach(_ => { }));
	}

	[Test]
	public void Should_Iterate_Zero_Times_When_Sequence_Is_Empty()
	{
		// Arrange
		IEnumerable<object> source = Array.Empty<object>();
		int iterator = 0;

		// Act
		source.ForEach(_ => iterator++);

		// Assert
		Assert.AreEqual(source.Count(), iterator);
	}

	[Test]
	public void Should_Iterate_One_Time_When_Sequence_Has_One_Element()
	{
		// Arrange
		IEnumerable<object> source = new[] {"0"};
		int iterator = 0;

		// Act
		source.ForEach(_ => iterator++);

		// Assert
		Assert.AreEqual(source.Count(), iterator);
	}

	[Test]
	public void Should_Iterate_Multiple_Times_When_Sequence_Has_Multiple_Elements()
	{
		// Arrange
		IEnumerable<object> source = new[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
		int iterator = 0;

		// Act
		source.ForEach(_ => iterator++);

		// Assert
		Assert.AreEqual(source.Count(), iterator);
	}
}
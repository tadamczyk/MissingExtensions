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

[TestFixture]
public class IsNullOrEmptyTests
{
	[Test]
	public void Should_Be_True_When_Sequence_Is_Null()
	{
		IEnumerable<object>? source = null;

		Assert.IsTrue(source.IsNullOrEmpty());
	}

	[Test]
	public void Should_Be_True_When_Sequence_Is_Empty()
	{
		IEnumerable<object> source = Array.Empty<object>();

		Assert.IsTrue(source.IsNullOrEmpty());
	}

	[Test]
	public void Should_Be_False_When_Sequence_Is_Not_Empty()
	{
		IEnumerable<object> source = new[] {"0"};

		Assert.IsFalse(source.IsNullOrEmpty());
	}
}
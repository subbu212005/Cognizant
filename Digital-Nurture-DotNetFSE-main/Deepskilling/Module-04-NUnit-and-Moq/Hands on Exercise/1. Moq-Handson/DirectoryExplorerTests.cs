using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using MagicFilesLib;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private Mock<IDirectoryExplorer> _mockDirectoryExplorer = null!;
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [OneTimeSetUp]
        public void Init()
        {
            _mockDirectoryExplorer = new Mock<IDirectoryExplorer>();

            // Setup the mock to return our hardcoded files list when GetFiles is called
            var mockedFiles = new List<string> { _file1, _file2 };
            _mockDirectoryExplorer
                .Setup(x => x.GetFiles(It.IsAny<string>()))
                .Returns(mockedFiles);
        }

        [TestCase]
        public void GetFiles_ShouldReturnMockedFileList()
        {
            // Act
            ICollection<string> result = _mockDirectoryExplorer.Object.GetFiles("C:\\dummy-path");

            // Assert
            // 1. the collection is not null
            Assert.That(result, Is.Not.Null);

            // 2. the collection count is equal to 2
            Assert.That(result.Count, Is.EqualTo(2));

            // 3. the collection contains _file1
            Assert.That(result, Contains.Item(_file1));
        }
    }
}

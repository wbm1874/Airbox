using Airbox.Models;
using Airbox.Services;
using Airbox.ViewModels;
using Moq;

namespace Airbox.DataTests.ViewModels;

[TestClass]
public class TestImageListViewModel
{
    [TestMethod]
    public void TestImageListChanging1()
    {
        var mockDeviceInformation = new Mock<IDeviceInformation>();

        mockDeviceInformation.Setup(di => di.GetDisplaySize()).Returns(new Size(100.0, 100.0));

        var vm = new ImageListViewModel(mockDeviceInformation.Object)
        {
            ImageList = new ImageList("Title", new[] { "1" }),
            FullScreenImage = "test.jpg"
        };

        mockDeviceInformation.Verify(di => di.GetDisplaySize(), Times.Once);
        mockDeviceInformation.VerifyNoOtherCalls();

        Assert.AreEqual(92.0, vm.ImageWidth, "ImageWidth");
        Assert.AreEqual(1, vm.Span, "Span");
        Assert.IsNull(vm.FullScreenImage, "FullScreenImage");
    }
}

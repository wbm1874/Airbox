namespace Airbox.Services
{
    public class DeviceInformation : IDeviceInformation
    {
        public Size GetDisplaySize()
        {
            if (Application.Current?.MainPage is { } page)
            {
                return page.Bounds.Size;
            }

            return Size.Zero;
        }
    }
}

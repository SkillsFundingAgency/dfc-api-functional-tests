namespace DFC.API.JobProfiles.FunctionalTests.Support.CommonAction.Interface
{
    internal interface IGeneralSupport
    {
        string RandomString(int length);

        byte[] ConvertObjectToByteArray(object obj);

        T GetResource<T>(string resourceName);
    }
}
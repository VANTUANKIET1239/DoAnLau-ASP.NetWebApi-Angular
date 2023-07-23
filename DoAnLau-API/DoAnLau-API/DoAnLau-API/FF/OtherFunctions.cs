namespace DoAnLau_API.FF
{
    public static class OtherFunctions
    {
        public static byte[] PathImage2Byte(string path)
        {
            try
            {
                string imagePath = path; 
                byte[] imageBytes = File.ReadAllBytes(imagePath);

               
                return imageBytes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return null;
        }
    }
}

namespace LawyerTasks.Classes
{
    public static class SaveFile
    {
        public static string Save()
        {
            string file = "";

            SaveFileDialog saveFile = new SaveFileDialog();
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                file = $@"{saveFile.FileName}.pdf";
            }
            return file;
        }
    }
}

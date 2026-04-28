namespace MVC_Project1.Services
{
    public class DocumentSettings
    {
        public static async Task<string> UploadFileAsync(IFormFile file, string folderName)
        {
            // 1. تحديد مسار المجلد (wwwroot/images مثلاً)
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName);

            // 2. توليد اسم فريد للملف
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            // 3. دمج المسار مع اسم الملف
            var filePath = Path.Combine(folderPath, fileName);

            // 4. حفظ الملف
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // 5. نرجع اسم الملف عشان نخزنه في الداتا بيز
            return fileName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamer
{
    class FileObject : ICloneable
    {
        public string FileName { get; set; }              // 파일명
        public string FilePath { get; set; }              // 파일경로
        public string FileFullPath { get; set; }          // 파일명 + 파일경로 + 확장자
        public string FileExtension { get; set; }         // 파일 확장자

        public string BackupFileName { get; set; }        // 파일명 (복구용)
        public string BackupFilePath { get; set; }        // 파일경로 (복구용)
        public string BackupFileFullPath { get; set; }    // 파일명 + 파일경로 + 확장자 (복구용)
        public string BackupFileExtension { get; set; }   // 파일 확장자

        public long FileSize { get; set; }
        public string ModifyTime { get; set; }
        public string CreateTime { get; set; }

        public FileObject()
        {
            FileName = string.Empty;
            FilePath = string.Empty;
            FileFullPath = string.Empty;
            FileExtension = string.Empty;

            BackupFileName = string.Empty;
            BackupFilePath = string.Empty;
            BackupFileFullPath = string.Empty;
            BackupFileExtension = string.Empty;

            FileSize = 0L;
            ModifyTime = string.Empty;
            CreateTime = string.Empty;
        }

        public void SetFile(string strPath)
        {
            FileFullPath = strPath;
            BackupFileFullPath = strPath;

            int nLastSeparator = strPath.LastIndexOf(Path.DirectorySeparatorChar);
            FilePath = strPath.Substring(0, nLastSeparator + 1);
            BackupFilePath = FilePath;

            int nExtensionSeparator = strPath.LastIndexOf(".");
            FileName = strPath.Substring(nLastSeparator + 1, nExtensionSeparator - nLastSeparator - 1);
            BackupFileName = FileName;
            FileExtension = strPath.Substring(nExtensionSeparator + 1);
            BackupFileExtension = FileExtension;

            FileInfo fileInfo = new FileInfo(strPath);
            FileSize = fileInfo.Length / (long)Global.FileSize.KB;
            ModifyTime = fileInfo.LastWriteTime.ToString();
            CreateTime = fileInfo.CreationTime.ToString();
        }

        public FileObject DeepCopy()
        {
            FileObject fileObject = (FileObject)MemberwiseClone();

            fileObject.FileName = string.Copy(FileName);
            fileObject.FilePath = string.Copy(FilePath);
            fileObject.FileFullPath = string.Copy(FileFullPath);
            fileObject.FileExtension = string.Copy(FileExtension);

            fileObject.BackupFileName = string.Copy(BackupFileName);
            fileObject.BackupFilePath = string.Copy(BackupFilePath);
            fileObject.BackupFileFullPath = string.Copy(BackupFileFullPath);
            fileObject.BackupFileExtension = string.Copy(BackupFileExtension);

            fileObject.FileSize = FileSize;
            fileObject.ModifyTime = string.Copy(ModifyTime);
            fileObject.CreateTime = string.Copy(CreateTime);

            return fileObject;
        }

        public FileObject ShallowCopy()
        {
            return (FileObject)MemberwiseClone();
        }

        public FileObject Clone()
        {
            return DeepCopy();
        }

        object ICloneable.Clone()
        {
            return DeepCopy();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamer
{
    public class Global
    {
        public enum ListSize
        {
            CurName = 250,
            ReName = 250,
            FilePath = 250,
            FullPath = 250,
            FileSize = 100,
            ModifyTime = 100,
            CreateTime = 100
        }

        public enum ListColumn
        {
            CurName,
            ReName,
            FilePath,
            FullPath,
            FileSize,
            ModifyTime,
            CreateTime
        }

        public enum FormType
        {
            AddNameFront,
            AddNameBack,
            ChangeExtension,
        }
    }
}

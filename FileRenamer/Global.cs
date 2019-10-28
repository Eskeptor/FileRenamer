using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamer
{
    public class Global
    {
        /// <summary>
        /// ListView의 헤더 항목별 크기
        /// </summary>
        public enum ListSize
        {
            CurName = 250,      // 현재 이름
            ReName = 250,       // 바꿀 이름
            FilePath = 250,     // 파일 경로
            FullPath = 250,     // 전체 경로
            FileSize = 100,     // 파일 크기
            ModifyTime = 160,   // 변경 시간
            CreateTime = 160    // 생성 시간
        }

        /// <summary>
        /// ListView의 헤더 순서
        /// </summary>
        public enum ListColumn
        {
            CurName,            // 현재 이름
            ReName,             // 바꿀 이름
            FilePath,           // 파일 경로
            FullPath,           // 전체 경로
            FileSize,           // 파일 크기
            ModifyTime,         // 변경 시간
            CreateTime,         // 생성 시간
            Max
        }

        /// <summary>
        /// 다이나믹 폼의 생성 타입
        /// </summary>
        public enum FormType
        {
            AddName,            // 이름 추가
            ChangeExtension,    // 확장자 변경
        }

        public enum FileSize
        {
            KB = 1024,
            MB = 1024 * 1024
        }

        public enum ButtonInitMode
        {
            All = 0,    // 버튼 전체
            Load        // 파일 불러오기 모드 (선택항목 위로, 아래로 버튼 제외)
        }

        public const string NAMELIST_EXTENSION_FILTER = "NameList (*.nlt)|*.nlt";
    }
}

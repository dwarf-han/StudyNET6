using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyApp.Model
{
    /// <summary>
    /// 책 모델
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 생성 일자 
        /// </summary>
        public DateTime CreatedTime { get; set; }


        /// <summary>
        /// 책 종류
        /// </summary>
        public BookType Type { get; set; }

        /// <summary>
        /// 책 이름 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 책을 생성합니다.
        ///     1) 요약 1
        ///     2) 요약 2
        ///         3) 요약 3
        ///         4) 요약 4
        ///         5) 요약 5
        /// </summary>
        /// <param name="createdTime" type="DateTime">생성 일자</param>
        /// <param name="type" type="BookType">종류</param>
        /// <param name="title" type="string">이름</param>
        /// <code>
        /// var game = new Book(DateTime.Now, BookType.Game, "Diablo II");
        /// var history = new Book(DateTime.Now, BookType.History, "Korea");
        /// </code>
        public Book(DateTime createdTime, BookType type, string title)
        {
            CreatedTime = createdTime;
            Type = type;
            Title = title;
        }

        /// <summary>
        /// 책 정보 출력
        /// </summary>
        /// <returns>책 정보를 출력</returns>
        public override string ToString()
        {
            return $"{CreatedTime} {Type}";
        }
    }

    /// <summary>
    /// 북 종류
    /// </summary>
    public enum BookType
    {
        /// <summary>
        /// 게임
        /// </summary>
        Game,

        /// <summary>
        /// 역사
        /// </summary>
        History
    }
}

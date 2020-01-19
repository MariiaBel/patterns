using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prototype
{

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    class PagePrototype : IClone /*ICloneable*/
    {
        private readonly int _symbolsOnPage = 100;

        public DateTime Time { set; get; }
        public string Content { get; set; }

        public IdInfo IdInfo;

        public int Pages
        {
            get
            {
                if (Content != null)
                {
                    return Content.Length / _symbolsOnPage + 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Создать новый экземпляр клонируемого текста.
        /// </summary>
        /// <param name="content"> Текстовые данные. </param>
        public PagePrototype(string content)
        {
            if (string.IsNullOrEmpty(content)) throw new ArgumentNullException(nameof(content));

            Content = content;
        }

        /// <summary>
        /// Клонировать объект.
        /// </summary>
        /// <returns> Дубликат объекта. </returns>
        public object Clone()
        {
            // Поверхностное копирование.
            //return this.MemberwiseClone();

            // Глубокое копирование.
            var newContent = Content.Clone().ToString();
            var newPage = new PagePrototype(newContent);
            newPage.IdInfo = new IdInfo(IdInfo.IdNumber);
            return newPage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии ПРО");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии ПРО");
        }
    }
    class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован"); ;
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт"); ;
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}

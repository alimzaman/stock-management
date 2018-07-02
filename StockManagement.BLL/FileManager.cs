using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories;

namespace StockManagement.BLL
{
    public class FileManager
    {
        FileRepository _fileRepository = new FileRepository();

        public bool Add(File file)
        {
            return _fileRepository.Add(file);
        }
    }
}

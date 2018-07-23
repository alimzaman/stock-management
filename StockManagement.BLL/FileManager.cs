using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories;
using StockManagement.Repositories.Base;

namespace StockManagement.BLL
{
    public class FileManager
    {
        Repository<File> _fileRepository;

        public FileManager(Repository<File> fileRepository)
        {
            this._fileRepository = fileRepository;
        }

        public bool Add(File file)
        {
            return _fileRepository.Add(file);
        }
    }
}

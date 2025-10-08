using ReadBookRepo.Entity.Chapters.Dto;
using ReadBookRepo.Entity.Chapters.Entity;
using ReadBookService.Base;

namespace ReadBookService.IService.Chapters
{
    public interface IChapterService : IBaseService<ChapterEntity, ChapterDto>
    { 
        
    }
}

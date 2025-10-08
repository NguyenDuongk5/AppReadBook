using ReadBookRepo.Base.IRepo;
using ReadBookRepo.Entity.Chapters.Dto;
using ReadBookRepo.Entity.Chapters.Entity;

namespace ReadBookRepo.IRepo.Chapters
{
    public interface IChapterRepo : IMySqlBaseRepo<ChapterEntity, ChapterDto>
    {
        
    }
}

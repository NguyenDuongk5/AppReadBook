using ReadBookRepo.Base.IRepo;
using ReadBookRepo.Base.Repo;
using ReadBookRepo.Entity.Chapters.Dto;
using ReadBookRepo.Entity.Chapters.Entity;
using ReadBookRepo.IRepo.Chapters;

namespace ReadBookRepo.Repo.Chapters
{
    public class MysqlChapterRepo :MySqlBaseRepo<ChapterEntity, ChapterDto>, IChapterRepo
    {
        
    }
}

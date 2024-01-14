using BlazorApp1.Data;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class KhataEntryManager : IKhataEntry
    {
        private ApplicationDbContext _applicationDbContext { get; set; }

        public KhataEntryManager(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void AddEntry(KhataEntry khataEntry)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntry(int id)
        {
            throw new NotImplementedException();
        }

        public List<KhataEntry> GetEntry()
        {
            return _applicationDbContext.KhataEntries.ToList();
        }

        public KhataEntry GetEntry(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntry(KhataEntry khataEntry)
        {
            throw new NotImplementedException();
        }
    }
}

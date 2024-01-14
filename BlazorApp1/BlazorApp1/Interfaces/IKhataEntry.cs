using BlazorApp1.Data;

namespace BlazorApp1.Interfaces
{
    public interface IKhataEntry
    {
        public List<KhataEntry> GetEntry();
        public void AddEntry(KhataEntry khataEntry);
        public void UpdateEntry(KhataEntry khataEntry);
        public KhataEntry GetEntry(int id);
        public void DeleteEntry(int id);
    }
}

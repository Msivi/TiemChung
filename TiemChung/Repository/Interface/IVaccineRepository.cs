﻿using TiemChung.Entity;

namespace TiemChung.Repository.Interface
{
    public interface IVaccineRepository
    {
        Task<ICollection<VaccineEntity>> GetAllVaccine(string sortBy, int page);
        Task<VaccineEntity> GetVaccineById(string Id);
        Task<ICollection<VaccineEntity>> SearchVaccine(string searchKey);
        Task<string> CreateVaccine(VaccineEntity entity);
        Task UpdateVaccine(string id, VaccineEntity entity);
        Task<VaccineEntity> DeleteVaccine(string entity, bool isPhysical);
    }
}

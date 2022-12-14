using Leave_Management.Contracts;
using Leave_Management.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leave_Management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public DbSet<LeaveType> dbset;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
       

        public bool Create(LeaveType entity)
        {
             _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();

        }

        public ICollection<LeaveType> FindAll()
        {
            var leaveTypes = _db.LeaveTypes.ToList();
            return leaveTypes;
        }

        public LeaveType FindById(int id)
        {
            var leaveType = _db.LeaveTypes.Find(id);
            return leaveType;

        }
      

        public bool Save()
        {
            var save = _db.SaveChanges();
            return save > 0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }
        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            var leaves = _db.LeaveTypes.Where(i => i.Id == id).ToList();
            return leaves;
        }
    }
}

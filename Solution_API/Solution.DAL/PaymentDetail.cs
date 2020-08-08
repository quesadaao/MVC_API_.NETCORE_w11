using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
using Solution.DO.Interfaces;
using Solution.DAL.EF;
using Solution.Repository;

namespace Solution.DAL
{
    public class PaymentDetail : ICRUD<data.PaymentDetail>
    {
        private Repository<data.PaymentDetail> _repository = null;

        public PaymentDetail(SolutionDBContext solutionDBContext) {
            _repository = new Repository<data.PaymentDetail>(solutionDBContext);        
        }
        public void Delete(data.PaymentDetail t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.PaymentDetail> GetAll()
        {
            return _repository.GetAll();
        }

        public data.PaymentDetail GetOneById(int id)
        {
            return _repository.GetOnebyId(id);
        }

        public void Insert(data.PaymentDetail t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Updated(data.PaymentDetail t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}

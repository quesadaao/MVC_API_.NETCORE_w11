using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
using Solution.DO.Interfaces;
using Solution.DAL.EF;
using Solution.DAL;

namespace Solution.BS
{
    public class PaymentDetail : ICRUD<data.PaymentDetail>
    {
        private SolutionDBContext _solutionDBContext = null;

        public PaymentDetail(SolutionDBContext solutionDBContext) {
            _solutionDBContext = solutionDBContext;        
        }

        public void Delete(data.PaymentDetail t)
        {
            new Solution.DAL.PaymentDetail(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.PaymentDetail> GetAll()
        {
            return new Solution.DAL.PaymentDetail(_solutionDBContext).GetAll();
        }

        public data.PaymentDetail GetOneById(int id)
        {
            return new Solution.DAL.PaymentDetail(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.PaymentDetail t)
        {
            t.PMId = null;
            new Solution.DAL.PaymentDetail(_solutionDBContext).Insert(t);
        }

        public void Updated(data.PaymentDetail t)
        {
            new Solution.DAL.PaymentDetail(_solutionDBContext).Updated(t);
        }
    }
}

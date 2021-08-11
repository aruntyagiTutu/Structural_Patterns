using System.Collections;
using System.Collections.Generic;

namespace Composite_Pattern
{
    interface IEmployee
    {
        void UpdateTask();
    }

    #region [implement using extenstion]
    public class Employee : IEnumerable<Employee>, IEmployee
    {
        // Manager can have list of reportee
        public List<Employee> reportee = new List<Employee>();

        public void UpdateTask()
        {
            throw new System.NotImplementedException();
        }

        #region [IEnumerable implementation]
        public IEnumerator<Employee> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }

    //extension 
    public static class ExtensionMethods
    {
        public static void AddReportee(this Employee managers, Employee employee)
        {
            managers.reportee.Add(employee);
        }
    }

    #endregion

    #region [implement using Leaf and tree node]
   
    //Non leaf Node
    class Manager : IEmployee
    {
        public void UpdateTask()
        {
            throw new System.NotImplementedException();
        }
    }

    class Developer : IEmployee
    {
        public void UpdateTask()
        {
            throw new System.NotImplementedException();
        }
    }

    class TeamDirectory : IEmployee
    {
        private List<IEmployee> employees = new List<IEmployee>();
        public void UpdateTask()
        {
            throw new System.NotImplementedException();
        }

        public void AddEmployee(IEmployee emp)
        {
            employees.Add(emp);
        }
    }


    // client

    class client
    {
        void Run()
        {
            Developer dev1 = new Developer();
            Developer dev2 = new Developer();

            TeamDirectory engs = new TeamDirectory();
            engs.AddEmployee(dev1);
            engs.AddEmployee(dev2);



            Developer man1 = new Developer();
            Developer man2 = new Developer();

            TeamDirectory mangs = new TeamDirectory();
            mangs.AddEmployee(man1);
            mangs.AddEmployee(man2);

            TeamDirectory team = new TeamDirectory();
            team.AddEmployee(engs);
            team.AddEmployee(mangs);




        }
    }

    #endregion
}
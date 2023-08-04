using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;


namespace Architecture_Construct
{
    [Serializable]
    public abstract class Employee
    {
        ///attributes
        private string employeeID;
        private string employeeName;
        private string checkIn;
        private string checkOut;
        private string equipmentAvailable;

        //constructors
        public Employee()
        {
            employeeID = "ID";
            employeeName = "N/A";
            checkIn = "N/A";
            checkOut = "N/A";
            equipmentAvailable ="Equipment Available" ;
        }
        public Employee(string employeeID, string employeeName, string checkIn, string checkOut, string equipmentAvailable)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.equipmentAvailable = equipmentAvailable;
        }

        //behaviors
        public override string ToString()
        {
            return "Employee ID: " + employeeID + ", Name: " + employeeName 
                + ", Equipment Check In: " + checkIn + ", Equipment Check Out: " + checkOut
                + ", Number of Available Equipment:" + equipmentAvailable;
        }
        
        //properties
        public string EmployeeID
        {
            get { return employeeID; }
            set => employeeID = value;  //employee.employeeID = "0013"
        }

        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        public string CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        public string EquipmentAvailable
        {
            get { return equipmentAvailable; }
            set { equipmentAvailable = value; }
        }
    }
    public abstract class Supervisor
    {
        ///attributes
        private string employeeID;
        private string employeeName;
        private string checkIn;
        private string checkOut;
        private DateTime dateTime;
        private string equipmentAvailable;
        private DateTime terminationDate;

        //constructors
        public Supervisor()
        {
            employeeID = "ID";
            employeeName = "N/A";
            checkIn = "N/A";
            checkOut = "N/A";
            dateTime = terminationDate;
            equipmentAvailable = "Equipment Available"; 
        }
        public Supervisor(string employeeID, string employeeName, string checkIn, string checkOut, string equipmentAvailable, DateTime dateTime, DateTime terminationDate)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.dateTime = terminationDate;
            this.equipmentAvailable = equipmentAvailable;
        }

        //behaviors
        public override string ToString()
        {
            return "Employee ID: " + employeeID + ", Name: " + employeeName
                + ", Equipment Check In: " + checkIn + ", Equipment Check Out: " + checkOut
                + ", Number of Available Equipment:" + equipmentAvailable + ",Termination Date: " + terminationDate;
        }

        //properties
        public string EmployeeID
        {
            get { return employeeID; }
            set => employeeID = value;  //employee.employeeID = "0013"
        }

        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        public string CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        public string EquipmentAvailable
        {
            get { return equipmentAvailable; }
            set { equipmentAvailable = value; }
        }

        public string TerminationDate
        {
            get {return TerminationDate; }
            set { TerminationDate = value; }
        }
    }
    public abstract class Equipment
    {
        ///attributes
        private string employeeID;
        private string checkIn;
        private string checkOut;
        private string equipmentAvailable;

        //constructors
        public Equipment()
        {
            employeeID = "ID";
            checkIn = "N/A";
            checkOut = "N/A";
            equipmentAvailable = "Equipment Available";
        }
        public Equipment(string employeeID, string checkIn, string checkOut, string equipmentAvailable)
        {
            this.employeeID = employeeID;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.equipmentAvailable = equipmentAvailable;
        }

        //behaviors
        public override string ToString()
        {
            return "Employee ID: " + employeeID + ", Equipment Check In: " + checkIn + ", Equipment Check Out: " + checkOut
                + ", Number of Available Equipment:" + equipmentAvailable;
        }

        //properties
        public string EmployeeID
        {
            get { return employeeID; }
            set => employeeID = value;  //employee.employeeID = "0013"
        }

        public string CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        public string CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        public string EquipmentAvailable
        {
            get { return equipmentAvailable; }
            set { equipmentAvailable = value; }
        }
    }
    public abstract class Termination
    {
        ///attributes
        private string employeeID;
        private string checkIn;
        private string checkOut;
        private DateTime dateTime;
        private DateTime terminationDate;

        //constructors
        public Termination()
        {
            employeeID = "ID";
            checkIn = "N/A";
            checkOut = "N/A";
            dateTime = terminationDate;
        }
        public Termination(string employeeID, string employeeName, string checkIn, string checkOut, string equipmentAvailable, DateTime dateTime, DateTime terminationDate)
        {
            this.employeeID = employeeID;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.dateTime = terminationDate;
        }

        //behaviors
        public override string ToString()
        {
            return "Employee ID: " + employeeID + ", Equipment Check In: " + checkIn + ", Equipment Check Out: " + checkOut
                + ", Termination Date:" + terminationDate;
        }

        //properties
        public string EmployeeID
        {
            get { return employeeID; }
            set => employeeID = value;  //employee.employeeID = "0013"
        }

        public string CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        public string CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        public string TerminationDate
        {
            get { return TerminationDate; }
            set { TerminationDate = value; }
        }
    }
}

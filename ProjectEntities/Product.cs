using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities
{
    public class Product
    {
        private static int _maxId = 0;
        public int Id;
        private string _name;
        private DateTime? _shelf_life;//срок годности (годен до)
        private DateTime? _date_come;//дата поступления
        private DateTime? _date_util;//дата утилизации
        private DateTime? _date_out;//дата отгрузки

        private const string _errorSymbol = "1234567890'~`!@#$%^&*()_+=?:%;№\\//{}[]";       

           

        public Product()
        {
            Id = -1;
            _name = "";
            _shelf_life = new DateTime();
            _date_come = new DateTime();
            _date_util = new DateTime();
            _date_out = new DateTime();
        }
        public Product(int id, string name, DateTime? s_l, DateTime? d_c, DateTime? d_u, DateTime? d_o)
        {
            if (((DateTime)d_c).CompareTo((DateTime)d_o) == 1)
                throw new Exception("Date come later then date out");
            for (int i = 0; i < _errorSymbol.Length; i++)
                if (name.Contains(_errorSymbol[i]))
                    throw new Exception("Incorrect Name");
            if (id < 0) throw new Exception("Incorrect Id");

            Id = id;
            _name = (name);
            _shelf_life = (s_l);
            _date_come = (d_c);
            _date_util = (d_u);
            _date_out = (d_o);
        }
        public Product(int id, string name, DateTime? s_l, DateTime? d_c, DateTime? d_o)
        {
            if (((DateTime)d_c).CompareTo((DateTime)d_o) == 1)
                throw new Exception("Date come later then date out");
            for (int i = 0; i < _errorSymbol.Length; i++)
                if (name.Contains(_errorSymbol[i]))
                    throw new Exception("Incorrect Name");
            if (id < 0) throw new Exception("Incorrect Id");

            Id = (id);
            _name = (name);
            _shelf_life = (s_l);
            _date_come = (d_c);
            _date_out = (d_o);
            SetDateUtil();
        }
        public Product( string name, DateTime? s_l, DateTime? d_c, DateTime? d_u, DateTime? d_o)
        {
           if( ((DateTime)d_c).CompareTo((DateTime)d_o) == 1)
                throw new Exception("Date come later then date out");
            for (int i = 0; i < _errorSymbol.Length; i++)
                if (name.Contains(_errorSymbol[i]))
                    throw new Exception("Incorrect Name");

            Id = _maxId++;
            _name = (name);
            _shelf_life = (s_l);
            _date_come = (d_c);
            _date_util = (d_u);
            _date_out = (d_o);
        }

        private void SetDateUtil()
        {
            _date_util = new DateTime();
        }

        public string ProductName
        {
            get { return _name; }
            set { this._name = value; }
        }
        public DateTime? ShelfLife
        {
            get { return _shelf_life; }
            set { this._shelf_life = value; }
        }
        public DateTime? DateCome
        {
            get { return _date_come; }
            set { this._date_come = value; }
        }
        public DateTime? DateUtilization
        {
            get { return _date_util; }
            set { this._date_util = value; }
        }
        public DateTime? DateOut
        {
            get { return _date_out; }
            set { this._date_out = value; }
        }

        public int CompareTo(Product el)
        {
            return this.Id.CompareTo(el.Id);
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("id = " + Id + '\n');
            res.Append("Name = " + _name + '\n');
            res.Append("Date Come = " + _date_come + '\n');
            if (_date_util == new DateTime())
            {
                res.Append("Date Utilized = " + "No in Util" + '\n');
            }
            else res.Append("Date Utilized = " + _date_util + '\n');

            res.Append("Date Out = " + _date_out + '\n');
            res.Append("Shelf Life = " + _shelf_life + '\n');
            return res.ToString();

        }

    }
}

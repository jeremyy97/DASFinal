using DBAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class TableLogic
    {
        /// <summary>
        /// Gestion de las mesas
        /// Se crean nuevas mesas
        /// Eliminar mesas previamente registradas
        /// </summary>
        List<Table> Tables = new List<Table>();

        public TableLogic()
        {
            Tables = DBAccessConnection.GetTables();
        }

        public Table AddTable(int id, int people)
        {
            if (people > 0 && SearchById(id) == null)
            {
                Table table = new Table { ID = id, People = people, Available = 1 };
                DBAccessConnection.CreateTable(table);
                Tables = DBAccessConnection.GetTables();       
                return table;
            }
            else return null;
        }

        public Table SearchById(int id)
        {
            foreach (var table in Tables)
            {
                if (table.ID == id)
                {
                    return table;
                }
            }
            return null;
        }

        public Table SearchByPeople(int people)
        {
            foreach (var table in Tables)
            {
                if (table.People == people && table.Available == 1)
                {
                    return table;
                }
            }
            return null;
        }

        public Table PickTable(int id)
        {
            foreach (var table in Tables)
            {
                if (table.ID == id)
                {
                    if (table.Available==1)
                    {
                        DBAccessConnection.UpdateTableAvailability(table, 0);
                        Tables = DBAccessConnection.GetTables();
                        return table;
                    }
                }
            }
            return null;
        }

        public Table FreeTable(int id)
        {
            foreach (var table in Tables)
            {
                if (table.ID == id)
                {
                    if (table.Available == 0)
                    {
                        DBAccessConnection.UpdateTableAvailability(table, 1);
                        Tables = DBAccessConnection.GetTables();
                        return table;
                    }
                }
            }
            return null;
        }

        public List<Table> GetAvailableTables()
        {
            List<Table> TablesA = new List<Table>();
            foreach (var table in Tables)
            {
                if (table.Available==1)
                {
                    TablesA.Add(table);
                }
            }
            return TablesA;
        }

        public List<Table> GetTables()
        {
            return Tables;
        }

        public List<Table> GetUnavailableTables()
        {
            List<Table> TablesU = new List<Table>();
            foreach (var table in Tables)
            {
                if (table.Available==0)
                {
                    TablesU.Add(table);
                }
            }
            return TablesU;
        }

    }
}

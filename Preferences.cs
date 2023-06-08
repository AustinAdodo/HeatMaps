using System;

namespace HeatMaps
{
    public static class Preferences
    {
        //import database context containing route settings
        public const string Route1 = "/index";
        public const string Route2 = "/update";
        public const string Route3 = "/delete";
        public const string Route4 = "/add";
        public const string Route5 = "/get";
        public const string Route6 = "/get/:date";
        public const string Route7 = "/get/:id";
        public const string Route8 = "/delete";
        public static List<Sale> TempSalesRecords()
        {
            List<Sale> records = new List<Sale> {
            new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
             new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
              new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
               new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                 new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                  new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                   new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                    new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                     new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                      new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                       new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                        new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                         new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                          new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                           new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                            new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                             new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                              new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                               new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                                new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                                 new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                                  new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                                   new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
                                    new Sale {SalesId = "xyz",Discription= "Tissue", Amount = 2.12,Date = DateTime.Parse("21-11-22"),id = 1, Time =TimeOnly.Parse("09:22:12")},
            };
            return records;
        }
    }
}

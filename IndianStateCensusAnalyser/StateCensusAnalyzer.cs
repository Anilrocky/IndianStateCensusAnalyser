﻿using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace IndianStateCensusAnalyser
{
    public class StateCensusAnalyzer
    {
        public int ReadStateCensusData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StateCensusDAO>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data);
                }
                return records.Count() - 1;
            }
        }
    }
}
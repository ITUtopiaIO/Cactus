﻿using Cactus.ExcelConverter.MiniExcelConverter;
using System.Runtime.Serialization;
using Cactus.Cucumber;


namespace Cactus.ExcelConverter
{
    public class Converter
    {
        IConverter converter;

        public Converter() 
        {
            converter = new MiniExcelConverter.Converter();
        }

        public string ConvertExcelToFeature(string excelFileName)
        {
            return converter.ConvertExcelToFeature(excelFileName);
        }
    }


}
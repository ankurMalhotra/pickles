﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="ExcelScenarioFormatter.cs" company="PicklesDoc">
//  Copyright 2011 Jeffrey Cameron
//  Copyright 2012-present PicklesDoc team and community contributors
//
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using ClosedXML.Excel;

using PicklesDoc.Pickles.ObjectModel;
using PicklesDoc.Pickles.TestFrameworks;

namespace PicklesDoc.Pickles.DocumentationBuilders.Excel
{
    public class ExcelScenarioFormatter
    {
        private readonly ExcelStepFormatter excelStepFormatter;
        private readonly Configuration configuration;
        private readonly ITestResults testResults;

        public ExcelScenarioFormatter(
            ExcelStepFormatter excelStepFormatter,
            Configuration configuration,
            ITestResults testResults)
        {
            this.excelStepFormatter = excelStepFormatter;
            this.configuration = configuration;
            this.testResults = testResults;
        }

        public void Format(IXLWorksheet worksheet, Scenario scenario, ref int row)
        {
            int originalRow = row;
            worksheet.Cell(row, "B").Style.Font.SetBold();
            worksheet.Cell(row++, "B").Value = scenario.Name;
            worksheet.Cell(row++, "C").Value = scenario.Description;

            var results = this.testResults.GetScenarioResult(scenario);
            if (this.configuration.HasTestResults && results != TestResult.Inconclusive)
            {
                worksheet.Cell(originalRow, "B").Style.Fill.SetBackgroundColor(
                    results == TestResult.Passed
                        ? XLColor.AppleGreen
                        : XLColor.CandyAppleRed);
            }

            foreach (Step step in scenario.Steps)
            {
                this.excelStepFormatter.Format(worksheet, step, ref row);
            }
        }
    }
}

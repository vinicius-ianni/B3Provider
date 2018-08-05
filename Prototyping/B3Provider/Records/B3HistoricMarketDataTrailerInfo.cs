﻿#region License
/*
 * B3HistoricMarketDataTrailerInfo.cs
 *
 * The MIT License
 *
 * Copyright (c) 2018 Felipe Bahiana Almeida
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 * 
 * Contributors:
 * - Felipe Bahiana Almeida <felipe.almeida@gmail.com> https://www.linkedin.com/in/felipe-almeida-ba222577
 */
#endregion

namespace B3Provider.Records
{
    using System;

    public class B3HistoricMarketDataTrailerInfo
    {
        //public int Tipo { get; set; }            //TIPO DE REGISTRO
        public int Type { get; set; }            //TIPO DE REGISTRO
        //public string NomeArquivo { get; set; }     //NOME DO ARQUIVO
        public string FileName { get; set; }     //NOME DO ARQUIVO
        //public string Origem { get; set; }          //CÓDIGO DA ORIGEM
        public string Origin { get; set; }          //CÓDIGO DA ORIGEM
        //public DateTime DataGeracao { get; set; }   //DATA DA GERAÇÃO DO ARQUIVO
        public DateTime Generated{ get; set; }   //DATA DA GERAÇÃO DO ARQUIVO
        //public int TotalRegistros { get; set; }     //TOTAL DE REGISTROS
        public int NumberOfRecords { get; set; }     //TOTAL DE REGISTROS
    }
}
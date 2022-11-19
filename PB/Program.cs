﻿// See https://aka.ms/new-console-template for more information
using sun.tools.tree;

Console.WriteLine("Hello, World!");

var logging = org.apache.commons.logging.LogFactory.getFactory();
var logger = logging.getInstance(typeof(org.apache.pdfbox.text.PDFTextStripper));

logger.error("this works");

using var netStream = File.OpenRead(@"examples\custom-render-demo.pdf");

using var jioStream = new ikvm.io.InputStreamWrapper(netStream);

var doc = org.apache.pdfbox.pdmodel.PDDocument.load(jioStream);

var pageCount = doc.getNumberOfPages();

Console.Out.WriteLine($"Pages: {pageCount}");

var stripper = new org.apache.pdfbox.text.PDFTextStripper();

var output = new java.io.StringWriter();

stripper.writeText(doc, output);

var result = output.toString();

Console.Out.WriteLine(result);